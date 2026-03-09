using System.Diagnostics;
using charts.Models;
using Microsoft.AspNetCore.Mvc;
using charts.Models;

namespace charts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ChartView()
        {
            return View();
        }
        public IActionResult charts()
        {
            var charts = new List<ChartItem>()
            {
                new ChartItem { Title = "Area Chart", ActionName = "AreaChart", ImageUrl = "~/assets/img/AreaChart.png" },
            new ChartItem { Title = "Bar Chart", ActionName = "BarChart", ImageUrl = "~/assets/img/BarChart.jpg" },
            new ChartItem { Title = "Bubble Chart", ActionName = "BubbleChart", ImageUrl = "~/assets/img/BubbleChart.png" },
            new ChartItem { Title = "Candlestick Chart", ActionName = "CandlestickChart", ImageUrl = "~/assets/img/CandlestickChart.png" },
            new ChartItem { Title = "Column Chart", ActionName = "ColumnChart", ImageUrl = "~/assets/img/ColumnChart.png" },
            new ChartItem { Title = "Combo Chart", ActionName = "ComboChart", ImageUrl = "~/assets/img/ComboChart.png" },
            new ChartItem { Title = "Donut Chart", ActionName = "DonutChart", ImageUrl = "~/assets/img/DonutChart.png" },
            new ChartItem { Title = "Gauge", ActionName = "Gauge", ImageUrl = "~/assets/img/Gauge.svg" },
            new ChartItem { Title = "Geo Chart", ActionName = "GeoChart", ImageUrl = "~/assets/img/GeoCharts.png" },
            new ChartItem { Title = "Histogram", ActionName = "Histogram", ImageUrl = "~/assets/img/Histogram.png" },
            new ChartItem { Title = "Line Chart", ActionName = "LineChart", ImageUrl = "~/assets/img/LineChart.png" },
            new ChartItem { Title = "Org Chart", ActionName = "OrgChart", ImageUrl = "~/assets/img/OrgChart.png" },
            new ChartItem { Title = "Pie Chart", ActionName = "PieChart", ImageUrl = "~/assets/img/PieChart.png" },
            new ChartItem { Title = "Scatter Chart", ActionName = "ScatterChart", ImageUrl = "~/assets/img/ScatterChart.jpg" },
            new ChartItem { Title = "SteppedArea Chart", ActionName = "SteppedAreaChart", ImageUrl = "~/assets/img/SteppedAreaChart.png" },
            new ChartItem { Title = "Table", ActionName = "Table", ImageUrl = "~/assets/img/Table.png" },
            new ChartItem { Title = "Timeline", ActionName = "Timeline", ImageUrl = "~/assets/img/Timeline.webp" },
            new ChartItem { Title = "Treemap", ActionName = "Treemap", ImageUrl = "~/assets/img/Treemap.png" }
            };
            return View(charts);
        }       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
