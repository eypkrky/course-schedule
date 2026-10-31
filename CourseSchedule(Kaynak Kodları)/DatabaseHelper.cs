using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace CourseSchedule
{
    internal class DatabaseHelper
    {
        private static string connectionString =
            "Server=localhost;Database=CourseSchedule;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}