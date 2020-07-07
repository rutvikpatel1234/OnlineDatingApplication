using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Utilities;
using System.Text;

namespace TPOnlineDatingSite
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        userinfo ShowProfile = new userinfo();
        DBConnect db = new DBConnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("NoSession.aspx");
            }

            //Session["username"] = null;
            string InnerHtml = string.Empty;
            string username = Session["username"].ToString();
            DataSet CourseDataSet = ShowProfile.TPGetuserinfo_userprofile(username);
            if (CourseDataSet != null)
            {
                DataTable dataTable = new DataTable();
                dataTable = CourseDataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder("");

                    {


                        sb.Append("<div class=\"card text-white bg-dark mb-3 details\" style=\"width: 18rem;\">");
                        sb.Append("<img class=\"card-img-top imgheight\" src=\"" + dataTable.Rows[0]["profilepic"] + "\" alt=\"Card image cap\">");
                        sb.Append("<div class=\"card-body\">");
                        sb.Append("<h6 class=\"card-title\">Name:" + dataTable.Rows[0]["name"] + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Gender:" + dataTable.Rows[0]["gender"] + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Age:" + dataTable.Rows[0]["age"] + "</h6> <span class=\"card-title\"> Occupation:" + dataTable.Rows[0]["occupation"] + "</span> <br/> <br/><span class=\"card-title\"> Commit Type:" + dataTable.Rows[0]["commtype"] + "</span>");
                        sb.Append("</div>");
                        sb.Append("<div class=\"modal-footer\">");
                        sb.Append("<a href=\"ProfileInfo.aspx?_id=" + dataTable.Rows[0]["username"] + "\"class=\"btn btn-outline-success\">Profile View</a>" + "<a href=\"UpdateProfile.aspx?_id=" + dataTable.Rows[0]["username"] + "\"class=\"btn btn-outline-success\">Update Profile</a>");
                        sb.Append("</div></div>");


                    }
                    InnerHtml = sb.ToString();
                }
                else
                {
                    //Response.Write("<script>alert('Add course first from AddCourse')</script>");
                }
            }
            details.InnerHtml = InnerHtml;
        }

    }

}

    