using System.ComponentModel.DataAnnotations;

namespace ShipMobile.Data.Models
{
    public enum PackageType
    {
        [Display(Name ="Document")]
        Document,
        
        [Display(Name = "Value goods")]
        ValueGoods,
        
        [Display(Name = "Food")]
        Food,

        [Display(Name = "Fragile")]
        Fragile
    }
}
