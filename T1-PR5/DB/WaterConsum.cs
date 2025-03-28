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
    public class WaterConsum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Regió")]
        public string? Region { get; set; }
        [DisplayName("Municipi")]
        public string? City { get; set; }
        [DisplayName("Any")]
        public int Year { get; set; }
        [DisplayName("Consum")]
        public float Consum { get; set; }
    }
}
