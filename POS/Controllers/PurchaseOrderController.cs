using Services.Interface;
using System.Web.Mvc;

namespace POS.Controllers
{
    public class PurchaseOrderController : Controller
    {
        private ITaxMasterService _taxMasterService;
        public PurchaseOrderController(ITaxMasterService taxMasterService)
        {
            _taxMasterService = taxMasterService;
        }

        public JsonResult GetTaxName()
        {
            return Json(_taxMasterService.GetAllTax(), JsonRequestBehavior.AllowGet);
        }
    }
}