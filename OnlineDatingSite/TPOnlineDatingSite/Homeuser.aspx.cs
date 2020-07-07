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
    public partial class Homeuser : System.Web.UI.Page
    {
        userinfo user = new userinfo();
        DBConnect db = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
         

            string InnerHtml = string.Empty;
           
            DataSet CourseDataSet = user.TP_GetUserList();
            if (CourseDataSet != null)
            {
                DataTable dataTable = new DataTable();
                dataTable = CourseDataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder("");
                    for (int i = 0; i < dataTable.Rows.Count; i++)

                    {
                       


                        sb.Append("<div class=\"card text-white bg-dark mb-3 details\" style=\"width: 20rem;\">");
                        sb.Append("<img class=\"card-img-top imgheight\" src=\"" + dataTable.Rows[i]["profilepic"] + "\" alt=\"Card image cap\">");
                        sb.Append("<div class=\"card-body\">");
                        sb.Append("<h6 class=\"card-title\">Name:" + dataTable.Rows[i]["name"] + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Gender:" + dataTable.Rows[i]["gender"] + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Age:" + dataTable.Rows[i]["age"] + "</h6> <span class=\"card-title\"> Occupation:" + dataTable.Rows[i]["occupation"] +  "</span>");
                        sb.Append("</div>");
                        //sb.Append("<div class=\"modal-footer\">");
                        //sb.Append("<a href=\"ProfileInfo.aspx?_id=" + dataTable.Rows[0]["username"] + "\"class=\"btn btn-outline-success\">Profile View</a>" + "<a href=\"UpdateProfile.aspx?_id=" + dataTable.Rows[0]["username"] + "\"class=\"btn btn-outline-success\">Update Profile</a>");
                        sb.Append("</div>");


                    }
                    InnerHtml = sb.ToString();
                }
                else
                {
                    
                }
            }
            details.InnerHtml = InnerHtml;
        }
    }
}