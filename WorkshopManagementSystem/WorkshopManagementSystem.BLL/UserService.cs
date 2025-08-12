using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using WorkshopManagementSystem.DAL;
using WorkshopManagementSystem.Models;

namespace WorkshopManagementSystem.BLL
{
    public class UserService
    {
        private readonly UserRepository _repo = new UserRepository();


        // Register user (stores salt:hash in PasswordHash). roleId typically 2 (User)
        public bool RegisterUser(string fullName, string email, string password, int roleId = 2)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("All fields are required.");

            var existing = _repo.GetByEmail(email);
            if (existing != null) return false;

            string salt = GenerateSalt();
            string hash = HashPassword(password, salt);
            string stored = salt + ":" + hash;

            var user = new User
            {
                FullName = fullName,
                Email = email,
                PasswordHash = stored,
                RoleID = roleId
            };

            return _repo.Add(user);
        }



        // Authenticate — returns User on success otherwise null
        public User AuthenticateUser(string email, string password)
        {
            var user = _repo.GetByEmail(email);
            if (user == null) return null;

            var stored = user.PasswordHash ?? string.Empty;
            if (stored.Contains(":"))
            {
                var parts = stored.Split(':');
                if (parts.Length != 2) return null;
                var salt = parts[0];
                var storedHash = parts[1];
                var enteredHash = HashPassword(password, salt);
                if (enteredHash == storedHash) return user;
                return null;
            }
            else
            {
                // legacy plaintext fallback
                if (stored == password) return user;
                return null;
            }
        }



        public List<Role> GetRoles() => _repo.GetRoles();

        // Password helper - PBKDF2
        private string GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var saltBytes = new byte[16];
                rng.GetBytes(saltBytes);
                return Convert.ToBase64String(saltBytes);
            }
        }



        private string HashPassword(string password, string saltBase64)
        {
            var saltBytes = Convert.FromBase64String(saltBase64);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
