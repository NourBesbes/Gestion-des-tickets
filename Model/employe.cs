using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectV2.Model
{
    class employe
    {

        [Key]
        public int empl_Id { get; set; }

        public string login { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string tel { get; set; }
        public virtual ICollection<ticket>  tickets { get; set; }
    }
}
