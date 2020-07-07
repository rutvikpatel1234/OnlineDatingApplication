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
    public partial class Likeview : System.Web.UI.Page
    {
        memberlikes likeReq = new memberlikes();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(Session["username"] as string))
            //{
            //    Response.Redirect("NoSession.aspx");
            //}
           
            string value = "1";
            string username = "";
            if (!IsPostBack)
            {

                username = Session["username"].ToString();
                
            }
            string InnerHtml = string.Empty;
             username = Session["username"].ToString();
            DataSet CourseDataSet = likeReq.TPGetLikeDislikeMember(username, value);
           

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
                            sb.Append("<h6 class=\"card-title\">Age:" + dataTable.Rows[i]["age"] + "</h6> <span class=\"card-title\"> Occupation:" + dataTable.Rows[i]["occupation"] + "</span> <br/> <br/><span class=\"card-title\"> Commit Type:" + dataTable.Rows[i]["commtype"] + "</span>");
                            sb.Append("</div>");
                            sb.Append("<div class=\"modal-footer\">");
                            sb.Append("<a href=\"MemberHomeView.aspx?_id=" + dataTable.Rows[i]["username"] + "\"class=\"btn btn-info btn-sm fas fa-eye fa-2x\"></a>" +
                                "<a href=\"LikeDisLike.aspx?_userTo=" + dataTable.Rows[i]["username"] + "&value=1&Form=Req" + "\"class=\"btn btn-primary btn-sm fas fa-paper-plane fa-2x\"></a>"
                                + "<a href=\"LikeDisLike.aspx?_userTo=" + dataTable.Rows[i]["username"] + "&value=0"+ "\"class=\"btn btn-danger btn-sm fas fa-times fa-2x\"></a>" ); 
                        sb.Append("</div></div>");
                        
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