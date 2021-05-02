using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace S5_CodeFirstEF.Web.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }

        public virtual List<Player> Player { get; set; }


    }
}
