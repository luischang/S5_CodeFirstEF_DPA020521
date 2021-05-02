using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace S5_CodeFirstEF.Web.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name ="Nom.Futbolista")]
        public string FullName { get; set; }
        [Column(TypeName = "int")]
        [Display(Name = "N° Camiseta")]
        public int Dorsal { get; set; }
        [Display(Name = "Fecha de Nac.")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public int SoccerPositionId { get; set; }

        public virtual SoccerPosition SoccerPosition { get; set; }

        public virtual List<Team> Team { get; set; }



    }
}
