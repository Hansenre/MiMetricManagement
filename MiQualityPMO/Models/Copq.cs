using System.ComponentModel.DataAnnotations;

namespace MiQualityPMO.Models
{
    public class Copq
    {
        [Required(ErrorMessage = "{0} required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Factory")]
        public string Factory { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Fiscal Year")]
        public string FiscalYear { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Quarter")]
        public string Quarter { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "$WholeSalePrice$")]
        public double WholeSalePrice { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "$ Cost")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double WeightedCost { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "MI Rate")]
        public int MiRate { get; set; }

        public Copq()
        {
        }

        public Copq(int id, string factory, string fiscalYear, string quarter, double wholeSalePrice, double weightedCost, int miRate)
        {
            Id = id;
            Factory = factory;
            FiscalYear = fiscalYear;
            Quarter = quarter;
            WholeSalePrice = wholeSalePrice;
            WeightedCost = weightedCost;
            MiRate = miRate;
        }
    }
}
