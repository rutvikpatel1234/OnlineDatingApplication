using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace TPOnlineDatingSite
{
    public partial class MessageBox : System.Web.UI.UserControl
    {
        int messageID;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int MessageID
        {
            get { return messageID; }
        }
        public int GetmessageID()
        {
            return MessageID;
        }

        public void DataBind(Message msg)
        {
            lblSender.Text += msg.senderuser;
            lblMessageBody.Text = msg.MessageBody;
            lblMessageDate.Text = msg.MessageDate.ToString();
            lblMessageID.Text = msg.messageID.ToString();
            messageID = msg.messageID;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int messageID = int.Parse(lblMessageID.Text);
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPDeletemsg";
            comm.Parameters.AddWithValue("@msgID", messageID);
            dbconn.DoUpdateUsingCmdObj(comm);
        }
    }
}