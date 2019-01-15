using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using iceland_test.Models;
using System.Collections.Generic;

namespace iceland_test.Controllers
{
    public class HomeController : Controller
    {
        #region Main View
        public IActionResult Index()
        {
            //load day with inventory
            var model = InventoryPageModel.New();

            return View(model);
        }
        #endregion

        #region Inventory Processor Action
        public PartialViewResult InventoryProcessor([FromBody] IEnumerable<InventoryPagePostModel> model)
        {
            var inventory = new List<InventoryItem>();
            var settings = new InventoryPageSettings();

            //extract models
            foreach (var item in model)
            {
                //extract settings
                foreach (var set in item.Settings)
                {
                    settings = set;
                }

                //extract settings
                foreach (var inv in item.Inventory)
                {
                    inventory.Add(inv);
                }
            }

            //process the day
            inventory = InventoryModel.ProcessInventory(settings.DayIncrement, settings.Concert, inventory);

            var pageModel = new InventoryPageModel()
            {
                Settings = settings,
                Inventory = inventory
            };

            return PartialView("~/Views/Home/_IndexContent.cshtml", pageModel);
        }
        #endregion

        #region Error View
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
