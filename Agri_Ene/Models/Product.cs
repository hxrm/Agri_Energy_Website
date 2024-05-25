using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Agri_Ene.Data;

namespace Agri_Ene.Models
{
    public class Product
    {
        [Key]
        public int? prodId { get; set; }
        public string? prodName { get; set; }
        //  public string? prodCategory { get; set; }
        /*Might have to swap out the string for thus enum( in db too*/
        public ProductCategories prodCategory { get; set; }
        public DateTime? productionDate { get; set; }
        // Specify the foreign key property
        public string? FarmerId { get; set; }

        [ForeignKey("FarmerId")]
        public AgriUser? Farmer { get; set; }


    }
}
