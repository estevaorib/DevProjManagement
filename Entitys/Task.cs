using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    public class Task
    {
        public Int64 Id { get; set; }

        [MaxLength(200)]
        public String Description { get; set; }

        public Task()
        {

        }

        public Task(String description)
        {
            Description = description;
        }
    }
}
