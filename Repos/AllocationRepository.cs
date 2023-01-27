using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    public class AllocationRepository
    {
        public static void Save(Allocation allocation)
        {
            try
            {
                using(Repository dbcontext = new Repository())
                {
                    dbcontext.Entry(allocation.Developer).State = EntityState.Unchanged;
                    dbcontext.Entry(allocation.Project).State = EntityState.Unchanged;

                    if(allocation.Id == 0)
                    {
                        dbcontext.Allocations.Add(allocation);
                    }
                    else
                    {
                        dbcontext.Entry(allocation).State = EntityState.Modified;
                    }

                    dbcontext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        } 
    }
}
