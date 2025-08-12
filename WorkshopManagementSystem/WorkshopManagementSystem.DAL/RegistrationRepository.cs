using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WorkshopManagementSystem.Models;

namespace WorkshopManagementSystem.DAL
{
    public class RegistrationRepository
    {
        public bool Add(int userId, int workshopId)
        {
            string sql = @"INSERT INTO Registrations (UserID, WorkshopID) VALUES (@UserID, @WorkshopID)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userId),
                new SqlParameter("@WorkshopID", workshopId)
            };

            return DbHelper.ExecuteNonQuery(sql, parameters) > 0;
        }

        public Registration GetByUserAndWorkshop(int userId, int workshopId)
        {
            string sql = @"SELECT TOP 1 RegistrationID, UserID, WorkshopID, RegistrationDate
                           FROM Registrations
                           WHERE UserID = @UserID AND WorkshopID = @WorkshopID";
            var dt = DbHelper.ExecuteDataTable(sql,
                new SqlParameter("@UserID", userId),
                new SqlParameter("@WorkshopID", workshopId));

            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new Registration
            {
                RegistrationID = Convert.ToInt32(r["RegistrationID"]),
                UserID = Convert.ToInt32(r["UserID"]),
                WorkshopID = Convert.ToInt32(r["WorkshopID"]),
                RegistrationDate = Convert.ToDateTime(r["RegistrationDate"])
            };
        }

        public List<Registration> GetByUserId(int userId)
        {
            var list = new List<Registration>();
            string sql = @"SELECT r.RegistrationID, r.UserID, r.WorkshopID, r.RegistrationDate,
                                  w.Title, w.Date
                           FROM Registrations r
                           INNER JOIN Workshops w ON r.WorkshopID = w.WorkshopID
                           WHERE r.UserID = @UserID
                           ORDER BY r.RegistrationDate DESC";

            var dt = DbHelper.ExecuteDataTable(sql, new SqlParameter("@UserID", userId));
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Registration
                {
                    RegistrationID = Convert.ToInt32(row["RegistrationID"]),
                    UserID = Convert.ToInt32(row["UserID"]),
                    WorkshopID = Convert.ToInt32(row["WorkshopID"]),
                    RegistrationDate = Convert.ToDateTime(row["RegistrationDate"]),
                    WorkshopTitle = row["Title"]?.ToString(),
                    WorkshopDate = Convert.ToDateTime(row["Date"])
                });
            }
            return list;
        }

        public int GetCountByWorkshop(int workshopId)
        {
            string sql = "SELECT COUNT(*) FROM Registrations WHERE WorkshopID = @WorkshopID";
            var obj = DbHelper.ExecuteScalar(sql, new SqlParameter("@WorkshopID", workshopId));
            return Convert.ToInt32(obj ?? 0);
        }
    }
}
