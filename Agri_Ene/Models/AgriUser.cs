using Microsoft.AspNetCore.Identity;

namespace Agri_Ene.Models
{
    public class AgriUser : IdentityUser
    {
        //instantiate variables that are not in identity 
        //no id need - automatic in the Identity
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public ICollection<Product>? Products { get; set; }



    }
}
