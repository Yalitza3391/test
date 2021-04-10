using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WEBTABLES.ViewModel;
using entity.Modelos;
using CoreTest.Table1;

namespace WEBTABLES.Controllers
{
    public class Table2ModelController : Controller
    {
        //private DBContextClass db = new DBContextClass();

        // GET: Table2Model
        
        private readonly ITable1 tableManager;
        public Table2ModelController(ITable1 tableManager)
        {
            this.tableManager = tableManager;
        }

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTable1()

        {
            var data = this.tableManager.GetCultivoProductivo();
            var model = data.Select(x => new Table1ViewModel
            {
                id = x.IdT1,
                Name = x.Name
            }).ToList();
            return View(model);
        }

        // GET: Table2Model/Details/5



    }
}
