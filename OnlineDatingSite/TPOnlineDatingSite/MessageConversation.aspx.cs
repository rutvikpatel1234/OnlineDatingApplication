using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilities;
using System.Data.SqlClient;
using System.Text;


namespace TPOnlineDatingSite
{
    public partial class MessageConversation : System.Web.UI.Page
    {
        Message msgusers = new Message();
        DBConnect dbconn = new DBConnect();
        SqlCommand comm = new SqlCommand();
        string userto = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("NoSession.aspx");
            }
            //string userfrom = "";
            //if (!IsPostBack)
            //{
            //userfrom = Session["username"].ToString();
            userto = Request.QueryString["_msgTo"];
                //userfrom=
                Session.Add("userto", userto);
                
            //}
            
            LoadMessages(userto);
        }

        public void LoadMessages(string userto)
        {
            List<MessageBox> boxes = new List<MessageBox>();
            foreach (Control msgbox in Form.Controls.OfType<MessageBox>())
            {
                boxes.Add((MessageBox)msgbox);
            }
            for(int i = 0; i < boxes.Count; i++)
            {
                Form.Controls.Remove(boxes[i]);
            }
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPGetMessages";
            comm.Parameters.Clear();
            comm.Parameters.AddWithValue("@senderemail", Session["username"].ToString());
            comm.Parameters.AddWithValue("@receiveemail", userto);
            
            DataSet mymsg = dbconn.GetDataSetUsingCmdObj(comm);
            if (mymsg.Tables[0].Rows.Count > 0)
            {
                for(int i = 0; i < mymsg.Tables[0].Rows.Count; i++)
                {
                    MessageBox messageBox = (MessageBox)LoadControl("MessageBox.ascx");
                    Message msg = new Message();
                    msg.senderuser = mymsg.Tables[0].Rows[i][1].ToString();
                    msg.MessageBody = mymsg.Tables[0].Rows[i][3].ToString();
                    msg.MessageDate = DateTime.Parse(mymsg.Tables[0].Rows[i][4].ToString());
                    msg.messageID = int.Parse(mymsg.Tables[0].Rows[i][0].ToString());
                    messageBox.DataBind(msg);
                    Form.Controls.Add(messageBox);
                }
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            bool sendit = true;
            if (txtMessage.Text == "")
            {
                sendit = false;
                lblMessage.Text = "Must write something in the message box";
            }
            if (sendit)
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "TPSendMessage";
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@senderusername", Session["username"].ToString());
                comm.Parameters.AddWithValue("@receiveusername", Session["userto"].ToString());
                comm.Parameters.AddWithValue("@body", txtMessage.Text);
                comm.Parameters.AddWithValue("@date", DateTime.Now);
        
                var val = dbconn.DoUpdateUsingCmdObj(comm);
                if(val == 1)
                {
                    lblSendMessage.Text = "Sent to " + Session["userto"].ToString();
                    LoadMessages("userto");
                    Email email = new Email();
                    string strTO = "termproject2020@gmail.com";
                    string strFROM = "termproject2020@gmail.com";
                    string strSubject = "New Message";
                    string strMessage = Session["userto"].ToString() + "Send you a Message";
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
                    lblSendMessage.Text = "Problem sending a message" + Session["userto"].ToString();
                }

            }
        }

        protected void btnGetMessages_Click(object sender, EventArgs e)
        {
            LoadMessages(userto);
        }
    }
}