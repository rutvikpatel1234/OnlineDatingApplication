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
using System.Net.Mail;
using System.Net;

namespace TPOnlineDatingSite
{
    public partial class DatingPage : System.Web.UI.Page
    {
        DatingClass dateinsert = new DatingClass();
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string User_Receiver = "";
            
            //string flag = "";

            if (IsPostBack)
            {
                User_Receiver = Request.QueryString["_id"];
                //flag = Request.QueryString["flag"];
            }
           
            else
            {
                getdatng();
            }
        }

        public void getdatng()
        {
            string User_Sender = Session["username"].ToString();
            string User_Receiver = Request.QueryString["_id"];
            string date = "";
            string Location = "";
            string Place = "";
            DataSet DatingDetaSet = dateinsert.TPGetDatingReq(User_Sender, User_Receiver);
            if(DatingDetaSet != null && DatingDetaSet.Tables[0].Rows.Count > 0)
            {
                 date = DatingDetaSet.Tables[0].Rows[0][1].ToString();
                 Location = DatingDetaSet.Tables[0].Rows[0][2].ToString();
                 Place = DatingDetaSet.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                date = "";
                Location = "";
                Place = "";
                //Response.Write("<script>alert('Please Send Dating Request')</script>");
            }
            //string date = DatingDetaSet.Tables[0].Rows[0][1].ToString();
            //string Location = DatingDetaSet.Tables[0].Rows[0][2].ToString();
            //string Place = DatingDetaSet.Tables[0].Rows[0][3].ToString();

            txtdtp.Text = date;
            Locations.SelectedValue = Location;
            Places.SelectedValue = Place;
            //user.Value = User_Receiver;
        }






        protected void PostData(object sender, EventArgs e)
        {
            string from  = Request.QueryString["from"];
            string User_Sender = "";
            string User_Receiver = "";
            if (from != null && from.Equals("modifiy"))
            {
                User_Receiver = Session["username"].ToString();
                User_Sender = Request.QueryString["_id"];
                
            }
            else
            {
                
                User_Receiver = Request.QueryString["_id"];
                User_Sender = Session["username"].ToString();
            }

            //string User_Sender = Session["username"].ToString();
            //string User_Receiver = Request.QueryString["_id"];
            var dating = dateinsert.TPDatingReq(User_Sender, User_Receiver, txtdtp.Text, Locations.SelectedValue, Places.SelectedValue);
            if (dating != "-1")
            {
                Response.Write("<script>alert('Successfully')</script>");
                Email email = new Email();
                string strTO = "termproject2020@gmail.com";
                string strFROM = "termproject2020@gmail.com";
                string strSubject = "Dating Request";
                string strMessage = "Dear" +"<br />"+txtdtp.Text + " " +Locations.SelectedValue + " " + Places.SelectedValue + " " + User_Sender + " " + "See you soon";
                try
                {
                    email.SendEmail(strTO, strFROM, strSubject, strMessage);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                Response.Write("<script>alert('Something is not filled in')</script>");
            
            }
        }

        protected void Lnkpickdate_Click(object sender, EventArgs e)
        {
            datepicker.Visible = true;
        }

        protected void datepicker_SelectionChanged(object sender, EventArgs e)
        {
            txtdtp.Text = datepicker.SelectedDate.ToLongDateString();
            datepicker.Visible = false;
        }
      
        protected void Locations_Change(object sender, EventArgs e)
        {

        }

        protected void Places_Change(object sender, EventArgs e)
        {

        }

     
    }
}

//sb.Append("<a href=\"javascript:void(0);" + "\"class=\"btn btn-success btn-sm fas fa-heart fa-2x\" onclick=\"likedislike('" + dataTable.Rows[i]["username"]+"','1')\"> </a>"


