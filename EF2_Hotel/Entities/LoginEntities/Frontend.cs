using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_Hotel.Entities.LoginEntities
{
    public class Frontend
    {
        [Key]
        [MaxLength(50)]
        public string User_name {  get; set; }

        [Required]
        public string Pass_word {  get; set; }
    }
}
