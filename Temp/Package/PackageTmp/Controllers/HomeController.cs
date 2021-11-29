using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApexServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var g = new Models.ServiceCall.CashDeposit();

            var data = new Models.Data.CashDepositRequest();
            data.CreditAccountNo = "1100422266001";
            data.PostToCashAccount = "Y";
            data.TransactionAmount = "10.00";
            data.TransactionReference = "Cash Deposit";
            data.ValueDate = DateTime.Today.ToShortDateString();
            data.EBSMessageID = "1234567890";
            data.EBSMessageType = "Cashdeposit";
            g.Process(data);
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
