using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDIMVC.Model
{
    [Table("tblCategory")]
    public class CategoryVM
    {
        [Key]
        [Display(Name = "Sr No")]
        public int CategoryID { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Active")]
        public bool CategoryIsActive { get; set; }
        [Display(Name = "Delete")]
        public bool CategoryIsDelete { get; set; }
    }
}
