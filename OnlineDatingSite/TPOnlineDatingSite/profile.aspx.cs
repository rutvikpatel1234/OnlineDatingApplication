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
    public partial class profile : System.Web.UI.Page
    {
        userinfo CreateInfo = new userinfo();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("NoSession.aspx");
            }

        }
        //private bool CheckForSession()  using for login purpose
        //{
        //    bool isSession = true;
        //    if (Session["username"] == null)
        //        isSession = false;
        //    return isSession;
        //}

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
           

            string strFolder = Server.MapPath("~/");
            strFolder = strFolder + "img";
            string fileName = FileUpload1.FileName;
            CheckforFolderExists(strFolder);
            string strFilePath = strFolder + "\\" + fileName;

            FileUpload1.SaveAs(strFilePath);

            if (FileUpload1.HasFile)
            { }
            string username = Session["username"].ToString();
            var createprofile = CreateInfo.TP_Userprofile(username,txtocc.Text, "/img/" + FileUpload1.FileName,txtgender.Text, txtage.Text, txtheight.Text, txtweight.Text, txtinterests.Text, txtlike.Text, txtdis.Text, txtres.Text, txtbook.Text, txtmovies.Text, txtpoem.Text,
                    dropcommit.SelectedValue, txthave.Text, txtwants.Text, dropreli.SelectedValue, txtdesc.Text);
            if (createprofile != "-1")
            {

                Server.Transfer("ViewProfile.aspx");
            }
            else
            {
                Response.Write("<script>alert('Something Wrong') </script>");
            }

        }
        private static void CheckforFolderExists(string strFolder)
        {
            if (!Directory.Exists(strFolder))
            {
                Directory.CreateDirectory(strFolder);
            }
        }
    }
}
