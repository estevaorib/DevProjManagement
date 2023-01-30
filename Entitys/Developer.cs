using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevProjectManagement
{
    public class Developer
    {
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(45)]
        public String Name { get; set; }

        public DateTime Birth { get; set; }

        [NotMapped]
        public Char Level { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public String LevelDB
        {
            get
            {
                return Level.ToString();
            }
            set
            {
                Level = value[0];
            }
        }

        public Credential Credential { get; set; }

        public List<Allocation> Allocations { get; set; }

        public Developer()
        {
            Allocations = new List<Allocation>();
        }

        public Developer(string name, DateTime birth, char level, Credential credential)
        {
            Name = name;
            Birth = birth;
            Level = level;
            Credential = credential;
        }

        public override String ToString()
        {
            return Name;        
        }
    }
}
