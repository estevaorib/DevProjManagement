using DevProjectManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    public class TaskRepository
    {
        public static void Save(Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (task.Id == 0)
                    {
                        dbContext.Tasks.Add(task);
                    }
                    else
                    {
                        dbContext.Entry(task).State
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

        public static List<object> Find(string description)
        {
            List<object> returnedValues = new List<object>();
            using (var dbContext = new Repository())
            {
                var developers = dbContext.Developers.Where(d => d.Name.Contains(description) && d.Allocations.Any()).ToList();
                var projects = dbContext.Projects.Where(p => p.Name.Contains(description) && p.Allocations.Any()).ToList();
                returnedValues.AddRange(developers);
                returnedValues.AddRange(projects);
            }
            return returnedValues;
        }

        public static List<Allocation> FindAllocation(string description)
        {
            using (var dbContext = new Repository())
            {
                var allocations = dbContext.Allocations
                    .Join(dbContext.Developers.Where(d => d.Name.Contains(description)),
                          a => a.Id,
                          d => d.Id,
                          (a, d) => a)
                    .Union(
                        dbContext.Allocations
                        .Join(dbContext.Projects.Where(p => p.Name.Contains(description)),
                              a => a.Id,
                              p => p.Id,
                              (a, p) => a)
                    ).ToList();
                return allocations;
            }
        }

        public static List<Allocation> FindAllocationsByProject(string name)
        {
            using (var dbContext = new Repository())
            {
                var allocations = dbContext.Allocations
                    .Include(a => a.Project)
                    .Where(a => a.Project.Name == name)
                    .ToList();

                return allocations;
            }
        }

        public static List<Allocation> FindAllocationByDeveloper(string name)
        {
            using (var dbContext = new Repository())
            {
                var allocations = dbContext.Allocations
                    .Include(a => a.Developer)
                    .Where(a => a.Developer.Name == name)
                    .ToList();

                return allocations;
            }
        }
    }
}
