using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WorkshopManagementSystem.Models;

namespace WorkshopManagementSystem.DAL
{
    public class UserRepository
    {
        public bool Add(User user)
        {
            string sql = @"INSERT INTO Users (FullName, Email, PasswordHash, RoleID)
                           VALUES (@FullName, @Email, @PasswordHash, @RoleID)";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", user.FullName ?? (object)DBNull.Value),
                new SqlParameter("@Email", user.Email ?? (object)DBNull.Value),
                new SqlParameter("@PasswordHash", user.PasswordHash ?? (object)DBNull.Value),
                new SqlParameter("@RoleID", user.RoleID)
            };

            return DbHelper.ExecuteNonQuery(sql, parameters) > 0;
        }


        public User GetByEmail(string email)
        {
            string sql = @"SELECT u.UserID, u.FullName, u.Email, u.PasswordHash, u.RoleID, r.RoleName
                           FROM Users u
                           LEFT JOIN Roles r ON u.RoleID = r.RoleID
                           WHERE u.Email = @Email";

            var dt = DbHelper.ExecuteDataTable(sql, new SqlParameter("@Email", email ?? (object)DBNull.Value));
            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            return new User
            {
                UserID = Convert.ToInt32(row["UserID"]),
                FullName = row["FullName"] == DBNull.Value ? null : row["FullName"].ToString(),
                Email = row["Email"] == DBNull.Value ? null : row["Email"].ToString(),
                PasswordHash = row["PasswordHash"] == DBNull.Value ? null : row["PasswordHash"].ToString(),
                RoleID = row["RoleID"] == DBNull.Value ? 0 : Convert.ToInt32(row["RoleID"]),
                RoleName = row["RoleName"] == DBNull.Value ? null : row["RoleName"].ToString()
            };
        }


        public List<Role> GetRoles()
        {
            var list = new List<Role>();
            var dt = DbHelper.ExecuteDataTable("SELECT RoleID, RoleName FROM Roles ORDER BY RoleID");
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new Role
                {
                    RoleID = Convert.ToInt32(r["RoleID"]),
                    RoleName = r["RoleName"].ToString()
                });
            }
            return list;
        }


        public List<User> GetAll()
        {
            var list = new List<User>();
            var dt = DbHelper.ExecuteDataTable(@"SELECT u.UserID, u.FullName, u.Email, u.RoleID, r.RoleName
                                                FROM Users u LEFT JOIN Roles r ON u.RoleID = r.RoleID
                                                ORDER BY u.FullName");
            foreach (DataRow r in dt.Rows)
            {
                list.Add(new User
                {
                    UserID = Convert.ToInt32(r["UserID"]),
                    FullName = r["FullName"]?.ToString(),
                    Email = r["Email"]?.ToString(),
                    RoleID = r["RoleID"] == DBNull.Value ? 0 : Convert.ToInt32(r["RoleID"]),
                    RoleName = r["RoleName"]?.ToString()
                });
            }
            return list;
        }
    }
}
