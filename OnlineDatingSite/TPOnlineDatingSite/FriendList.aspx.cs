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

    public partial class FriendList : System.Web.UI.Page
    {
        memberlikes viewm = new memberlikes();
        protected void Page_Load(object sender, EventArgs e)
        {
            string InnerHtml = string.Empty;
            string username = Session["username"].ToString();
            DataSet CourseDataSet = viewm.TPRequestAcceptMember(username);


            if (CourseDataSet != null)
            {
                DataTable dataTable = new DataTable();
                dataTable = CourseDataSet.Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder("");
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        //if (!username.Equals(dataTable.Rows[i]["username"]))<i class="fas fa-user-check"></i><i class="fas fa-times"></i>
                        //{
                        sb.Append("<div class=\"card text-white bg-dark mb-3 details\" style=\"width: 20rem;\">");
                        sb.Append("<img class=\"card-img-top imgheight\" src=\"" + dataTable.Rows[i]["profilepic"] + "\" alt=\"Card image cap\">");
                        sb.Append("<div class=\"card-body\">");
                        sb.Append("<h6 class=\"card-title\">Name:" + dataTable.Rows[i]["name"] + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Gender:" + dataTable.Rows[i]["gender"] + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Age:" + dataTable.Rows[i]["age"] + "</h6> <span class=\"card-title\"> Email:" + dataTable.Rows[i]["email"] + "</span> <br/> <br/><span class=\"card-title\"> Phone:" + dataTable.Rows[i]["phone"] + "</span>");
                        sb.Append("</div>");
                        sb.Append("<div class=\"modal-footer\">");
                        sb.Append("<a href=\"DatingPage.aspx?_id=" + dataTable.Rows[i]["username"] + "\"class=\"btn btn-warning px-3 btn-sm fas fa-utensils fa-2x\"></a>"
                            + "<a href=\"LikeDisLike.aspx?userFrom=" + dataTable.Rows[i]["username"] + "&_userTo=" + username + "&value=0&Form=Req" + "\"class=\"btn btn-danger btn-sm fas fa-times fa-2x\"></a>" + "<a href=\"LikeDisLike.aspx?userFrom=" + dataTable.Rows[i]["username"] + "&_userTo=" + username + "&value=3&Form=Req" + "\"class=\"btn btn-primary btn-sm fas fa-user-lock fa-2x\"></a>");
                        sb.Append("</div></div>");
                        //}
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

/*"<a href=\"LikeDisLike.aspx?userFrom=" + dataTable.Rows[i]["username"] + "&_userTo=" + username + "&value=2&Form=Req" + "\"class=\"btn btn-primary btn-sm fas fa-user-check fa-2x\"></a>"*/
