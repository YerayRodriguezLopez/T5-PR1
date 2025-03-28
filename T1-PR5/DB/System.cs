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
    public class System
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Type { get; set; }
        public double SunHours { get; set; }
        public double WindSpeed { get; set; }
        public double WaterFlow { get; set; }
        public double Ratio { get; set; }
        public double GeneratedEnergy { get; set; }
        public double CostPerKWh { get; set; }
        public double PricePerKWh { get; set; }
        public DateTime DateTime { get; set; }
    }
}
