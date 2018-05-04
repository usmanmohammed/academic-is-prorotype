namespace SchoolManagement.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    public class DatabaseContext : DbContext
    {
        private static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string appDirectory = $"{appData}\\School Management\\LocalCache";

        public DatabaseContext()
            : base($"Data Source={appDirectory}\\LocalDatabase.sdf")
        {
            if (!Directory.Exists(appDirectory))
            {
                Directory.CreateDirectory(appDirectory);
            }
        }

        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<GradeSetting> GradeSettings { get; set; }
        public virtual DbSet<ResultEntry> Results { get; set; }
    }

    public class DatabaseContextInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {
            //Add Admin Account
            db.UserAccounts.Add(new UserAccount()
            {
                UserName = "admin",
                FullName = "Administrator",
                Password = Cryptography.Encrypt("Password"),
                CreatedBy = "admin",
                DateCreated = DateTime.UtcNow.AddHours(1),
                UpdatedBy = "admin",
                DateUpdated = DateTime.UtcNow.AddHours(1),
                IsActive = true
            });
            base.Seed(db);
        }
    }
}