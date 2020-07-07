using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.IO;

namespace TPOnlineDatingSite
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        DBConnect dbconn = new DBConnect();
        //SqlCommand comm = new SqlCommand();
        userinfo updateinfo = new userinfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                string username = "0";
                if (Session["username"] == null)
                {
                    username = Request.QueryString["_id"];
                    Session["username"] = username;
                }
                else
                {
                    username = Session["username"].ToString();
                }
            }
            else
            {
                ReadUpdate();
            }
           
        }
        public void ReadUpdate()
        {
            string username = Session["username"].ToString();

            DataSet ProfileDetaSet = updateinfo.TPGetuserinfo_userprofile(username);
            string name = ProfileDetaSet.Tables[0].Rows[0][1].ToString();
            string gender = ProfileDetaSet.Tables[0].Rows[0][26].ToString();
            string age = ProfileDetaSet.Tables[0].Rows[0][9].ToString();
            string occupation = ProfileDetaSet.Tables[0].Rows[0][8].ToString();
            string commitmenttype = ProfileDetaSet.Tables[0].Rows[0][18].ToString();
           
            txtname.Text = name;
            txtgender.Text = gender;
            txtage.Text = age;
            txtocc.Text = occupation;
            dropcommit.SelectedValue = commitmenttype;
            
        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            bool correct = true;
            if (txtname.Text.ToString() == "")
            {
                correct = false;
            }
            if (txtage.Text.ToString() == "")
            {
                correct = false;
            }
            if (txtocc.Text.ToString() == "")
            {
                correct = false;
            }
            if (correct)
            {
                string strFolder = Server.MapPath("~/");
                strFolder = strFolder + "img";
                string fileName = FileUpload10.FileName;
                CheckforFolderExists(strFolder);
                string strFilePath = strFolder + "\\" + fileName;
                FileUpload10.SaveAs(strFilePath);
                if (FileUpload10.HasFile)
                {

                }
                string username = Session["username"].ToString();
                var updateprofile = updateinfo.TPuserupdate(username, txtname.Text, txtage.Text,txtgender.Text, txtocc.Text, dropcommit.SelectedValue,"/img/" + FileUpload10.FileName);
                if (updateprofile != "-1")
                {
                    Server.Transfer("ViewProfile.aspx");
                    //lblerror.Text = "Successfully";
                }
                else
                {
                    Response.Write("<script>alert('Something is not filled in')</script>");
                }
                
            }
        }
        private static void CheckforFolderExists(string strFolder)
        {
            if (!Directory.Exists(strFolder))
            {
                Directory.CreateDirectory(strFolder);
            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Server.Transfer("ViewProfile.aspx");
        }
    }
}
