using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Resume.Models
{
    public class Jobs
    {

        public int ID { get; set; }
       
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(30)]

        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Job Date From"), DataType(DataType.Date)]
       

        public DateTime JobDateFrom { get; set; }

        [Display(Name = "Job Date To"), DataType(DataType.Date)]
        

        public DateTime JobDateTo { get; set; }







    }

   
}
