using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2_Hotel.Entities.FrontendEntitites
{
    public class Reservation
    {
		[Required]
		[MaxLength(50)]
		public string First_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Last_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Birth_day { get; set; }

        [Required]
        [MaxLength(50)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone_number { get; set; }

        [Required]
        public string Email_address { get; set; }

		public int Number_guest {  get; set; }

		public int Id { get; set;}

        [Required]
        public string Street_address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apt_suite { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }

        [Required]
        [MaxLength(10)]
        public string Zip_code { get; set; }

        [Required]
        [MaxLength(10)]
        public string Room_type { get; set; }

        [Required]
        [MaxLength(10)]
        public string Room_floor { get; set; }

        [Required]
        [MaxLength(10)]
        public string Room_number { get; set; }

        [Required]
        public double Total_bill { get; set; }

        [Required]
        [MaxLength(10)]
        public string Payment_type { get; set; }

        [Required]
        [MaxLength(10)]
        public string Card_type { get; set; }

        [Required]
        [MaxLength(50)]
        public string Card_number { get; set; }

        [Required]
        [MaxLength(50)]
        public string Card_exp { get; set; }

        [Required]
        [MaxLength(10)]
        public string Card_cvc { get; set; }

        [Required]
        public DateTime Arrival_time { get; set; }

        [Required]
        public DateTime Leaving_time { get; set; }

        public bool Check_in { get; set; }

        public int Break_fast { get; set; }
        public int Launch { get; set; }
        public int Dinner { get; set; }
        public bool Cleaning { get; set; }
        public bool Towel { get; set; }
        public bool S_surprise { get; set; }
        public bool Supply_status { get; set; }
        public int Food_bill { get; set; }
    }
}
