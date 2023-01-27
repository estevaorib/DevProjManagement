using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    [Table("Projects")]
    public class Project
    {
        [Required]
        public Int64 Id { get; set; }

        [Required]
        [StringLength(35)]
        public String Name { get; set; }

        public DateTime Beginning { get; set; }

        public DateTime EndPlanned { get; set; }

        public DateTime End { get; set; }

        public List<Allocation> Allocations { get; set; }

        public Project()
        {
            Allocations = new List<Allocation>();
        }

        public Project(string name, DateTime beginning, DateTime endPlanned, DateTime end)
        {
            Name = name;
            Beginning = beginning;
            EndPlanned = endPlanned;
            End = end;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
