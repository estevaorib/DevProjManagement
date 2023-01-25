using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    [Table("Allocation")]
    public class Allocation
    {
        public Int64 Id { get; set; }

        public DateTime Beginning { get; set; }

        public DateTime End { get; set; }

        public Byte HoursPerWeek { get; set; }

        public Decimal Remuneration { get; set; }

        [Required]
        public Developer Developer { get; set; }

        [Required]
        public Project Project { get; set; }

        public Allocation()
        {
           
        }

        public Allocation(DateTime begginning, DateTime end, byte hoursPerWeek, decimal remuneration)
        {
            Beginning = begginning;
            End = end;
            HoursPerWeek = hoursPerWeek;
            Remuneration = remuneration;
        }

        //public override string ToString()
        //{
        //    return "Beginning: " + Beginning + "\nEnd: " + End + "\nHous of Work per Week: " + HoursPerWeek + "\nRemuneration: " + Remuneration + "\nDeveloper" + Developer + "\nProject: " + Project;
        //}
    }
}
