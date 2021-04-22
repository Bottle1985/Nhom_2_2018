using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace job_sp.Controllers
{
    public class ung_vienController : Controller
    {
        private Models.job_suppbortEntities UV = new Models.job_suppbortEntities();
        // GET: ung_vien
        public ActionResult dang_kyUV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult dang_kyUV(string ten_uv, string gioi_tinh, DateTime ngay_sinh, string sdt, string tinh, string huyen, string thanh_pho, string email, string ten_dn, string mat_khau, string nhap_lai)
        {
            var getdata = new Models.tt_ungVien();
            int vv = Convert.ToInt32(getdata.ID);
            vv = vv + 1;
            /*UV.tt_ungVien.Add(ten_uv, gioi_tinh, ngay_sinh, email, sdt, "",);*/
            
            return View();
        }
        public ActionResult page_UV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult page_UV(string ten_uv, string gioi_tinh, DateTime ngay_sinh, string sdt, string tinh, string huyen, string thanh_pho, string email, string ten_dn, string mat_khau, string nhap_lai)
        {
            return View();
        }
    }
}