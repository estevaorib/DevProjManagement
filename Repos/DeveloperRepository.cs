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
