using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace SanaProject1.Models
{
    public class UserModel
    {
        [Display(Name = "Enter yor name")]
        [Required(ErrorMessage = "You didn't enter a name")]
        public string Name { get; set; }
    }
}
