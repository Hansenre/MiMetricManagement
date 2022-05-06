using MiQualityPMO.Data;
using MiQualityPMO.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiQualityPMO.Services
{
    public class ViewModelResult
    {
        public ICollection<Mqaa> Mqaas { get; set; } 
        public ICollection<Copq> Copqs { get; set; } 
        public ICollection<Btp> Btps { get; set; }

    }

}
