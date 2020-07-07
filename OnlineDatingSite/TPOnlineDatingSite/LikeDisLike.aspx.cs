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
    public partial class Like : System.Web.UI.Page
    {
        memberlikes lmember = new memberlikes();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("NoSession.aspx");
            }
            string userto = "";
            string value = "";
            string username = "";
            string Form = "";
            string userFrom = "";

            if (!IsPostBack)
            {

                username = Session["username"].ToString();
                userto = Request.QueryString["_userTo"];
                value = Request.QueryString["value"];
                Form = Request.QueryString["Form"];
                userFrom = Request.QueryString["userFrom"];

            if (userFrom != null && !userFrom.Equals("dec")) 
            {
                 username = userFrom;
            }
            }
            if (Form != null && Form.Equals("Req"))
            {
                RMember(username, userto, value);
            }
            else
            {
                LikeMember(username, userto, value);
            }


        }
        public void LikeMember(string username, string userto, string value)
        {
            username = Session["username"].ToString();
            var like = lmember.TPLikeMember(username, userto, value);
            if (like != "1")
            {
                Response.Write("<script>alert('Something is Wrong')</script>");
            }

            else
            {
                Response.Write("<script>alert('Successfully add')</script>");
            }
            
        }
        
        public void RMember(string username, string userto, string value)
        {
            //username = Session["username"].ToString();
            var RequestUser = lmember.TPRequestMember(username, userto, value);
            if (RequestUser != "1")
            {
                Response.Write("<script>alert('Something is Wrong')</script>");
            }

            else
            {
                Response.Write("<script>alert('Successfully add')</script>");
            }
        }

        
    }
}