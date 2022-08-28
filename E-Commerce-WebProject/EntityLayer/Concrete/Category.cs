using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        

        public int CategoryId { get; set; }
        [Required(ErrorMessage="Category Name Not Empty")]
        [StringLength(20,ErrorMessage ="Please maximum 4-20 character",MinimumLength =4)]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
        public List<Food>Foods { get; set; }
       
    }
}
