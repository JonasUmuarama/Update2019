using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService salesRecordService;

        public SalesRecordsController(SalesRecordService salesRecordService)
        {
            this.salesRecordService = salesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SimpleSearch(DateTime? minDate,DateTime?maxDate)
        {   
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = minDate.Value.ToString("yyyy-MM-dd");
            var result =  salesRecordService.FindByDate(minDate, maxDate);

            return View(result);
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
