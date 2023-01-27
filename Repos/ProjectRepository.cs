using DevProjectManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement.Repos
{
    public class ProjectRepository
    {
        public static void Save(Project project)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (project.Id == 0)
                    {
                        dbContext.Projects.Add(project);
                    }
                    else
                    {
                        dbContext.Entry(project).State
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

        public static List<Project> FindByPartialName(string partialName)
        {
            try
            {
                using (Repository dbcontext = new Repository())
                {
                    return dbcontext.Projects
                        .Where(p => p.Name.ToLower().Contains(partialName.ToLower())).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
