using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            string name = string.Empty;
            name = Session["name"].ToString();
            ViewBag.Name = name;
            return View();
        }
        public ActionResult issuebook()
        {
            return View();
        }
        public JsonResult showBooks()
        {
            var table = LMS.DAL.BooksDAO.loaddatainbooksgrid();
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
            return Json(JSONString.ToString(), JsonRequestBehavior.AllowGet);

        }
        public JsonResult issbooks(int id)
        {
            string name = string.Empty;
            name = Session["name"].ToString();
            var d = LMS.DAL.BooksDAO.issuebooks(id, name);
            var da = new {
                success = true, 
            
            };
            return Json(da, JsonRequestBehavior.AllowGet);
        }
        public ActionResult bookreturn()
        {
            return View();
        }
        public JsonResult showbooks1()
        {
            string name = string.Empty;
            name = Session["name"].ToString();
            var table = LMS.DAL.issuebooksDAO.loaddatainbooksgrid(name);
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
            return Json(JSONString.ToString(), JsonRequestBehavior.AllowGet);

        }
        public JsonResult returnbooks(int id)
        {

            var d = LMS.DAL.issuebooksDAO.returnbook(id);
            var da = new
            {
                success = true,

            };
            return Json(da, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ViewAcc()
        {
            return View();
        }
        public JsonResult viewbook()
        {
            string name = string.Empty;
            name = Session["name"].ToString();
            var table = LMS.DAL.issuebooksDAO.loaddatainveiwaccgrid(name);
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
            return Json(JSONString.ToString(), JsonRequestBehavior.AllowGet);

        }
        public ActionResult updatemem()
        {
            return View();
        }
        public JsonResult showupdatemember()
        {
            string name = string.Empty;
            name = Session["name"].ToString();
            var dto = new LMS.Entities.NewMemberDTO();
            dto = LMS.DAL.NewMemberDAO.loaddatainupdatememberform(name);
            var d = new
            {
                memerid = dto.Memberid,
                name = dto.MemberName,
                fathername = dto.FatherName,
                email = dto.Email,
                phone = dto.Phone,
                cnic = dto.Cnic,
                picture = dto.Picture,


            };
            return Json(d, JsonRequestBehavior.AllowGet);
        }
        public JsonResult updatemember(string name, string fathername, string cnic, string phone, string email,int id)
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
            var pid = LMS.DAL.NewMemberDAO.updatedataintable(dTO,id);
            var data = new
            {
                success = true,
                p = pid,
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

    }
}