using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class EnergyIndicator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Any")]
        public int Year { get; set; }
        [DisplayName("Producció neta")]
        public float CleanProduction { get; set; }
        [DisplayName("Consum de gasolina")]
        public float GasolineConsum { get; set; }
        [DisplayName("Demanda electricita")]
        public float ElectricDemand { get; set; }
        [DisplayName("Producció disponible")]
        public float DisposableProduction { get; set; }
    }
}
