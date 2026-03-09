using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace charts.Models
{
    public class Chart
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Type { get; set; }

        public string XAxisName { get; set; }

        public string YAxisName { get; set; }

        // Navigation Property
        public List<ChartData> ChartData { get; set; }
    }
}