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
        
        public static void AddAllocation(Developer developer, Project project, DateTime beginning, DateTime end, byte hours, decimal remuneration)
        {
            using(Repository dbcontext = new Repository())
            {
                if(developer.Id != 0)
                {
                    Allocation a1 = new Allocation();
                    a1.Developer = developer;
                    a1.Project = project;
                    a1.Beginning = beginning;
                    a1.End = end;
                    a1.HoursPerWeek = hours;
                    a1.Remuneration = remuneration;

                    Save(a1);
                }
            }
        }
    }
}
