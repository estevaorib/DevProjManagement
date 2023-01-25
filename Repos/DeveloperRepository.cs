using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    public class DeveloperRepository
    {
        public static void Save(Developer dev)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (dev.Id == 0)
                    {
                        dbContext.Developers.Add(dev);
                    }
                    else
                    {
                        dbContext.Entry(dev).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AddDeveloper(string name, DateTime birth, char level, string email, string password, bool active, bool admin)
        {
            using(Repository dbcontext = new Repository())
            {
                Developer d1 = new Developer();
                d1.Name = name;
                d1.Birth = birth;
                d1.Level = level;

                Credential c1 = new Credential();
                c1.Email = email;
                c1.Password = password;
                c1.Active = active;
                c1.Administrator = admin;

                d1.Credential = c1;

                Save(d1);
            }
        }

        public static List<Developer> FindByPartialName(string partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers
                        .Where(d => d.Name.ToLower().Contains(partialName.ToLower()))
                        .ToList<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
