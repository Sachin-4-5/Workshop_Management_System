using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WorkshopManagementSystem.Models;

namespace WorkshopManagementSystem.DAL
{
    public class WorkshopRepository
    {
        public List<Workshop> GetAll()
        {
            var list = new List<Workshop>();
            string sql = "SELECT WorkshopID, Title, Description, Date, Capacity FROM Workshops ORDER BY Date";
            var dt = DbHelper.ExecuteDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Workshop
                {
                    WorkshopID = Convert.ToInt32(row["WorkshopID"]),
                    Title = row["Title"]?.ToString(),
                    Description = row["Description"] as string,
                    Date = Convert.ToDateTime(row["Date"]),
                    Capacity = Convert.ToInt32(row["Capacity"])
                });
            }
            return list;
        }

        public Workshop GetById(int id)
        {
            string sql = "SELECT WorkshopID, Title, Description, Date, Capacity FROM Workshops WHERE WorkshopID = @WorkshopID";
            var dt = DbHelper.ExecuteDataTable(sql, new SqlParameter("@WorkshopID", id));
            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            return new Workshop
            {
                WorkshopID = Convert.ToInt32(row["WorkshopID"]),
                Title = row["Title"]?.ToString(),
                Description = row["Description"] as string,
                Date = Convert.ToDateTime(row["Date"]),
                Capacity = Convert.ToInt32(row["Capacity"])
            };
        }

        public bool Add(Workshop workshop)
        {
            string sql = @"INSERT INTO Workshops (Title, Description, Date, Capacity)
                           VALUES (@Title, @Description, @Date, @Capacity)";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Title", workshop.Title ?? (object)DBNull.Value),
                new SqlParameter("@Description", workshop.Description ?? (object)DBNull.Value),
                new SqlParameter("@Date", workshop.Date),
                new SqlParameter("@Capacity", workshop.Capacity)
            };

            return DbHelper.ExecuteNonQuery(sql, parameters) > 0;
        }

        public int GetRegistrationCount(int workshopId)
        {
            string sql = "SELECT COUNT(*) FROM Registrations WHERE WorkshopID = @WorkshopID";
            var obj = DbHelper.ExecuteScalar(sql, new SqlParameter("@WorkshopID", workshopId));
            return Convert.ToInt32(obj ?? 0);
        }
    }
}
