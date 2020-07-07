using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace TPOnlineDatingSite
{
    public partial class Messages : System.Web.UI.Page
    {
        Message messageusers = new Message();
        DBConnect dbconn = new DBConnect();
        SqlCommand comm = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            

            getProfiles();
        }
       protected void getProfiles()
        {
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPGet_Messages";

            comm.Parameters.AddWithValue("@username", Session["username"].ToString());
            DataSet dsgetprofile = dbconn.GetDataSetUsingCmdObj(comm);
            gvFriendsOnline.DataSource = dsgetprofile;
            gvFriendsOnline.DataBind();
            gvFriendsOnline.Visible = true;
            if(gvFriendsOnline.Rows.Count == 0)
            {
                lblNoMessages.Text = "No Messages";
            }
        }

    
        protected void gvFriendsOnline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSendMessage_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GridViewRow row = (GridViewRow)button.NamingContainer;
            string ReceiveEmail = row.Cells[1].Text;
            Session.Add("ReceiveEmail", ReceiveEmail);
            Response.Redirect("MessageConversation");
        }
    }
}