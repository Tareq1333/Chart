using charts.Models;
using Microsoft.AspNetCore.Mvc;


namespace charts.Controllers
{
    public class chartsController : Controller
    {
        private readonly AppDbContext _context;

        public chartsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetChartData(int id)
        {
            var chart = _context.Charts
                        .Where(c => c.Id == id)
                        .Select(c => new
                        {
                            title = c.Title,
                            points = c.ChartData.Select(d => new { label = d.Label, value = d.Value }).ToList()
                        })
                        .FirstOrDefault();

            if (chart == null)
                return NotFound();

            return Json(chart);
        }
        public IActionResult AreaChart()
        {
            ViewBag.ChartTitle = "Area Chart";
            ViewBag.ChartType = "AreaChart"; 
            return View("ChartView");
        }
        public IActionResult BarChart()
        {
            ViewBag.ChartTitle = "Bar Chart";
            ViewBag.ChartType = "BarChart";
            return View("ChartView");
        }
        public IActionResult BubbleChart()
        {
            ViewBag.ChartTitle = "Bubble Chart";
            ViewBag.ChartType = "BubbleChart";
            return View("ChartView");
        }
        public IActionResult CandlestickChart()
        {
            ViewBag.ChartTitle = "Candlestick Chart";
            ViewBag.ChartType = "CandlestickChart";
            return View("ChartView");
        }
        public IActionResult ColumnChart()
        {
            ViewBag.ChartTitle = "Column Chart";
            ViewBag.ChartType = "ColumnChart";
            return View("ChartView");
        }
        public IActionResult ComboChart()
        {
            ViewBag.ChartTitle = "Combo Chart";
            ViewBag.ChartType = "ComboChart";
            return View("ChartView");
        }
        public IActionResult DonutChart()
        {
            ViewBag.ChartTitle = "Donut Chart";
            ViewBag.ChartType = "DonutChart";
            return View("ChartView");
        }
        public IActionResult Gauge()
        {
            ViewBag.ChartTitle = "Gauge";
            ViewBag.ChartType = "Gauge";
            return View("ChartView");
        }
        public IActionResult GeoChart()
        {
            ViewBag.ChartTitle = "Geo Chart";
            ViewBag.ChartType = "GeoChart";
            return View("ChartView");
        }
        public IActionResult Histogram()
        {
            ViewBag.ChartTitle = "Histogram";
            ViewBag.ChartType = "Histogram";
            return View("ChartView");
        }
        public IActionResult LineChart()
        {
            ViewBag.ChartTitle = "Line Chart";
            ViewBag.ChartType = "LineChart";
            return View("ChartView");
        }
        public IActionResult OrgChart()
        {
            ViewBag.ChartTitle = "Org Chart";
            ViewBag.ChartType = "OrgChart";
            return View("ChartView");
        }
        public IActionResult PieChart()
        {
            ViewBag.ChartTitle = "Pie Chart";
            ViewBag.ChartType = "PieChart";
            return View("ChartView");
        }
        public IActionResult ScatterChart()
        {
            ViewBag.ChartTitle = "Scatter Chart";
            ViewBag.ChartType = "ScatterChart";
            return View("ChartView");
        }
        public IActionResult SteppedAreaChart()
        {
            ViewBag.ChartTitle = "SteppedArea Chart";
            ViewBag.ChartType = "SteppedAreaChart";
            return View("ChartView");
        }
        public IActionResult Table()
        {
            ViewBag.ChartTitle = "Table";
            ViewBag.ChartType = "Table";
            return View("ChartView");
        }
        public IActionResult Timeline()
        {
            ViewBag.ChartTitle = "Timeline";
            ViewBag.ChartType = "Timeline";
            return View("ChartView");
        }
        public IActionResult Treemap()
        {
            ViewBag.ChartTitle = "Treemap";
            ViewBag.ChartType = "Treemap";
            return View("ChartView");
        }


    }
}
