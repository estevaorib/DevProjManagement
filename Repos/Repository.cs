using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    public class Repository : DbContext
    {
        private static MySqlConnection _databaseconnection;

        public DbSet<Developer> Developers { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Allocation> Allocations { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {
                Repository repository = this;

                Developer d = new Developer("Estevão", new DateTime(2006, 11, 23), 'P');
                Credential c = new Credential("estevao@gmail.com", "asdf1234", true, true);
                Project p = new Project("Test", new DateTime(2020, 10, 23), new DateTime(2020, 10, 23), new DateTime(2022, 11, 23));
                Allocation a = new Allocation(new DateTime(2020, 11, 23), new DateTime(2022, 11, 23), 5, 60000, d, p);
                Task t = new Task("Main task");

                d.Credential = c;
                a.Developer = d;
                a.Project = p;

                repository.Developers.Add(d);
                repository.Allocations.Add(a);
                repository.SaveChanges();
            }
        }

        // Singleton
        public static MySqlConnection GetDbConnection()
        {
            if (_databaseconnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ManagementConnectionString"].ConnectionString;
                _databaseconnection = new MySqlConnection(connectionString);
            }
            return _databaseconnection;
        }
    }
}
