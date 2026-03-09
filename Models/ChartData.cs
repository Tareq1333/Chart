using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace charts.Models
{
    public class ChartData
    {
        public int Id { get; set; }

        public int ChartId { get; set; }

        [Required]
        public string Label { get; set; }

        public double Value { get; set; }

        // Navigation Property
        [ForeignKey("ChartId")]
        public Chart Chart { get; set; }
    }
}