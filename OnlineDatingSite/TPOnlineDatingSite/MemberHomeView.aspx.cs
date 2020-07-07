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
    public partial class MemberHomeView : System.Web.UI.Page
    {
        userinfo HomeUserView = new userinfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("NoSession.aspx");
            }
            string username = "";
            if (!IsPostBack)
            {
                //string username = "0";
                 username = Request.QueryString["_id"];
                //if (!CheckForSession())
                //    Server.Transfer("login.aspx");
                //else
                //{
                //    string username = "0";
                //    if (Session["username"] == null)
                //    {
                //        username = Request.QueryString["_id"].ToString();

                //        Session["username"] = username;
                //    }
                //    else
                //    {
                //        username = Session["username"].ToString();
                //    }
                //    //if (username == "0")
                //    //{
                //    //    Server.Transfer("~/course.aspx");
                //    //}
                //    //if (!string.IsNullOrWhiteSpace(username) || !string.IsNullOrWhiteSpace(Session["username"].ToString()))
                //    //{
                //    //    ReadGrade();
                //    //}

                //    //else
                //    //    Server.Transfer("login.aspx");
                //}
            }
            //else
            //{
            //    gv_gradetable.Columns.Clear();
            //    ReadGrade();
            //}

            InfoShow(username);
        }

        public void InfoShow(string username)
        {
            //string username = Session["username"].ToString();
            //string username = Request.QueryString["_id"].ToString();
            DataSet ProfileDetaSet = HomeUserView.TPGetuserinfo_userprofile(username);
            string name = ProfileDetaSet.Tables[0].Rows[0][1].ToString();
            string height = ProfileDetaSet.Tables[0].Rows[0][10].ToString();
            string weight = ProfileDetaSet.Tables[0].Rows[0][11].ToString();
            string interests = ProfileDetaSet.Tables[0].Rows[0][12].ToString();
            string likes = ProfileDetaSet.Tables[0].Rows[0][17].ToString();
            string dislikes = ProfileDetaSet.Tables[0].Rows[0][22].ToString();
            string favoriterestaurants = ProfileDetaSet.Tables[0].Rows[0][13].ToString();
            string favoritebooks = ProfileDetaSet.Tables[0].Rows[0][15].ToString();
            string favoritemovies = ProfileDetaSet.Tables[0].Rows[0][14].ToString();
            string homeaddress = ProfileDetaSet.Tables[0].Rows[0][2].ToString();
            string city = ProfileDetaSet.Tables[0].Rows[0][4].ToString();
            string state = ProfileDetaSet.Tables[0].Rows[0][3].ToString();
            string zip = ProfileDetaSet.Tables[0].Rows[0][5].ToString();
            lblname1.Text = name;
            lblheight1.Text = height;
            lblweight1.Text = weight;
            lblinterests1.Text = interests;
            lbllike1.Text = likes;
            lbldis1.Text = dislikes;
            lblres1.Text = favoriterestaurants;
            lblbook1.Text = favoritebooks;
            lblmovies1.Text = favoritemovies;
            lbladdress1.Text = homeaddress;
            lblcity1.Text = city;
            lblstate1.Text = state;
            lblzip1.Text = zip;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.PostBackUrl = "~/HomeMember.aspx";
        }

       
    }
}