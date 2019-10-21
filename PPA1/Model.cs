using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class LogContext : DbContext
    {
        public string connectionString = "";
        virtual public DbSet<BMILog> BMILogs { get; set; }
        virtual public DbSet<DistanceLog> DistanceLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (connectionString != "")
            {
                options.UseSqlServer(connectionString);
            }
        }

        public LogContext() { }
        public LogContext(DbContextOptions<LogContext> options)
        : base(options)
        {

        }
        public LogContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }

    public class BMILog
    {
        [Key]
        public System.DateTime timestamp { get; set; }
        public double heightFeet { get; set; }
        public double heightInches { get; set; }
        public double weight { get; set; }
        public string result { get; set; }

        public BMILog(System.DateTime timestamp, double heightFeet, double heightInches, double weight, string result)
        {
            this.timestamp = timestamp;
            this.heightFeet = heightFeet;
            this.heightInches = heightInches;
            this.weight = weight;
            this.result = result;
        }
    }
    public class DistanceLog
    {
        [Key]
        public System.DateTime timestamp { get; set; }
        public double x1 { get; set; }
        public double y1 { get; set; }
        public double x2 { get; set; }
        public double y2 { get; set; }
        public double result { get; set; }

        public DistanceLog(System.DateTime timestamp, double x1, double y1, double x2, double y2, double result)
        {
            this.timestamp = timestamp;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.result = result;
        }
    }
}