using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
  
            return View();
        }

        public ActionResult  Member()
        {
         
            return View();
        }
        [HttpPost]
        public JsonResult checkadmin(string name,string pass)
        {
            object data = null;
            try
            {
                var url = "";
                var flag = false;
                var dto = new LMS.Entities.AdminDTO();
                dto.Name = name;
                dto.Password = pass;
                var obj = LMS.DAL.AdminDAO.checkadmin(dto);
                if (obj == 1)
                {
                    url = Url.Content("~/Admin/index");
                    flag = true;
                }
                else
                {
                    url = Url.Content("~/Home/Admin");
                }

                data = new
                {
                    valid = flag,
                    urltodirect = url
                };


            }
            catch(Exception)
            {
                data = new
                {
                    valid = false,
                    urltodirect = ""
                };
            }

            return Json(data, JsonRequestBehavior.AllowGet);
           
        }
        [HttpPost]
        public JsonResult checkMember(string name, string pass)
        {
            Session["name"] = name;
            object data = null;
            try
            {
                var url = "";
                var flag = false;
                var dto = new LMS.Entities.NewMemberDTO();
                dto.MemberName = name;
                dto.Password = pass;
                var obj = LMS.DAL.NewMemberDAO.checkmember(dto);
                if (obj == 1)
                {
                    url = Url.Content("~/Member/index");
                    flag = true;
                }
                else
                {
                    url = Url.Content("~/Home/Member");
                }

                data = new
                {
                    valid = flag,
                    urltodirect = url
                };


            }
            catch (Exception)
            {
                data = new
                {
                    valid = false,
                    urltodirect = ""
                };
            }

            return Json(data, JsonRequestBehavior.AllowGet);

        }
    }
}