using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using LMS.Entities;

namespace WebApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addNewmember()
        {
            return View();
        }
        public ActionResult addNewBook()
        {
            return View();
        }
        public ActionResult updatemember()
        {
            return View();
        }
        [HttpPost]
        public JsonResult showmember()
        {
            var members = LMS.DAL.NewMemberDAO.loaddataindatagrid();
            string JSONString = string.Empty;
           JSONString = JsonConvert.SerializeObject(members);
            var d = new
            {
                data = JSONString
            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }
        public JsonResult showmember1()
        {
            var table = LMS.DAL.NewMemberDAO.loaddataindatagrid();
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return Json(JSONString.ToString(),JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public ActionResult updatememberview(int id)
        {
            ViewBag.memid = id;
            return View();
        }
        public JsonResult showupdatemember(int id)
        {
            var dto =new LMS.Entities.NewMemberDTO();
            dto = LMS.DAL.NewMemberDAO.loaddatainupdateform(id);
            var d = new
            {
                memerid = dto.Memberid,
                name = dto.MemberName,
                fathername = dto.FatherName,
                email = dto.Email,
                phone=dto.Phone,
                cnic=dto.Cnic,
                picture=dto.Picture,


            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }
        public JsonResult addmember(string name,string fathername,string cnic,string phone,string email)
        {
            var dTO = new LMS.Entities.NewMemberDTO();
            var uniqueName = "";

            if (Request.Files["Image"] != null)
            {
                var file = Request.Files["Image"];
                if (file.FileName != "")
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);

                    //Generate a unique name using Guid
                    uniqueName = Guid.NewGuid().ToString() + ext;

                    //Get physical path of our folder where we want to save images
                    var rootPath = Server.MapPath("~/UploadedFiles");

                    var fileSavePath = System.IO.Path.Combine(rootPath, uniqueName);

                    // Save the uploaded file to "UploadedFiles" folder
                    file.SaveAs(fileSavePath);

                    dTO.Picture = uniqueName;
                }
            }
            dTO.Cnic = cnic;
            dTO.Email = email;
            dTO.Phone = phone;
            dTO.FatherName = fathername;
            dTO.MemberName = name;
            var pid = LMS.DAL.NewMemberDAO.Addnewmember(dTO);
            var data = new
            {
                success = true,
                p = pid,
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Canclemember()
        {
            return View();
        }
        public JsonResult cancel(int id)
        {
            var d = LMS.DAL.NewMemberDAO.cancelmembership(id);
            var da = new { 
                    success=true,            
            };
            return Json(da, JsonRequestBehavior.AllowGet);
        }
        public JsonResult addbook(string name,string author,string isbn,string publish,string category)
        {
            var dto = new LMS.Entities.BooksDTO();
            dto.BookName = name;
            dto.BookAuthor = author;
            dto.BookISBN = isbn;
            dto.BookPublishdate = publish;
            dto.BooKCategory = category;
            var d = LMS.DAL.BooksDAO.addnewbooks(dto);
            var da = new {
                success = true,
            
            };
            return Json(da, JsonRequestBehavior.AllowGet);
        }
        public JsonResult updatemember2(string name, string fathername, string cnic, string phone, string email, int id)
        {
            var dTO = new LMS.Entities.NewMemberDTO();
            var uniqueName = "";

            if (Request.Files["Image"] != null)
            {
                var file = Request.Files["Image"];
                if (file.FileName != "")
                {
                    var ext = System.IO.Path.GetExtension(file.FileName);

                    //Generate a unique name using Guid
                    uniqueName = Guid.NewGuid().ToString() + ext;

                    //Get physical path of our folder where we want to save images
                    var rootPath = Server.MapPath("~/UploadedFiles");

                    var fileSavePath = System.IO.Path.Combine(rootPath, uniqueName);

                    // Save the uploaded file to "UploadedFiles" folder
                    file.SaveAs(fileSavePath);

                    dTO.Picture = uniqueName;
                }
            }
            dTO.Cnic = cnic;
            dTO.Email = email;
            dTO.Phone = phone;
            dTO.FatherName = fathername;
            dTO.MemberName = name;
            var pid = LMS.DAL.NewMemberDAO.updatedataintable(dTO, id);
            var data = new
            {
                success = true,
                p = pid,
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}