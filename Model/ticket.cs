using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectV2.Model
{
    class ticket
    {
        [Key]
        public int tick_Id{ get; set; }
        public string mail { get; set; }
        public string delai { get; set; }
        public string date_deb { get; set; }
        public string date_fin { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string fax { get; set; }
        public string raison_Sociale { get; set; }
        public string reclamation { get; set; }
        public string tel { get; set; }
        public string type_Intervention { get; set; }
        public int empl_Id { get; set; }
        public virtual employe emp { get; set; }      
        public string reponse { get; set; }
        public string responsable { get; set; }
        public int contrat_Id { get; set; }
     
    }
}
