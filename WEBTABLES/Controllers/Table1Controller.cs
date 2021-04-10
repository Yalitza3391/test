
namespace WEBTABLES.Controllers
{
    using CoreTest.Table1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;


    public class Table1Controller : Controller
    {
        private readonly ITable1 tableManager;
        public Table1Controller(ITable1 tableManager)
        {
            this.tableManager = tableManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        /*
        public ActionResult GetTable1()
        {
            var cultivosdata = this.tableManager.GetCultivoProductivo();


            var result = cultivosdata.Select(x => new Table1ViewModel
            {
                id = x.id,
                Name= x.Name
            }).ToList();
            
            return this.View(result);
        }
        */

        
    }
}