
using System.ComponentModel.DataAnnotations;

namespace MiQualityPMO.Models
  
{
    public class Mqaa
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
        [Display(Name = "% Rate")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double PorRate { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "MI Rate")]
        public int MiRate { get; set; }
       

        public Mqaa()
        {
        }

        public Mqaa(int id, string factory, string fiscalYear, string quarter, double porRate, int miRate)
        {
            Id = id;
            Factory = factory;
            FiscalYear = fiscalYear;
            Quarter = quarter;
            PorRate = porRate;
            MiRate = miRate;
        }
       
    }
}
