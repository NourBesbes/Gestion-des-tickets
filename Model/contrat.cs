using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectV2.Model
{
    class contrat
    {
        [Key]
        public int contrat_Id { get; set; }
        public string raison_Sociale { get; set; }
        public string nom { get; set; }
        public virtual ICollection<ticket> tickets { get; set; }
    }
}
