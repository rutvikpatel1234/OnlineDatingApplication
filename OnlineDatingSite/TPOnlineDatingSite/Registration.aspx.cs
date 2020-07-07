using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace TPOnlineDatingSite
{
    public partial class Registration : System.Web.UI.Page
    {
        ArrayList UserRegistrationError = new ArrayList();
        ArrayList UserSecurityAnswers = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            divquestion.Visible = false;
        }
        void validuser()
        {
            if (txtuser.Text == "")
            {
                UserRegistrationError.Add("Enter User Name");
            }
            if (txtemail.Text == "")
            {
                UserRegistrationError.Add("Enter Email");
            }
            if (txtpassword.Text == "")
            {
                UserRegistrationError.Add("Enter Password");
            }
            if (txtprofilename.Text == "")
            {
                UserRegistrationError.Add("Enter Profile Name");
            }
            if (txtaddress.Text == "")
            {
                UserRegistrationError.Add("Enter Address");
            }
            if (txtcity.Text == "")
            {
                UserRegistrationError.Add("Enter City");
            }
            if (txtstate.Text == "")
            {
                UserRegistrationError.Add("Enter state");
            }
            if (txtzip.Text == "")
            {
                UserRegistrationError.Add("Enter Valid Zip");
            }
        }

        void validuserquestions()
        {
            if (dropq1.SelectedValue == "Select Questions")
            {
                UserSecurityAnswers.Add("Enter Question 1");
            }
            if (txtans1.Text == "")
            {
                UserSecurityAnswers.Add("Enter Answer 1");
            }
            if (dropq2.SelectedValue == "Select Questions")
            {
                UserSecurityAnswers.Add("Enter Question 2");
            }
            if (txtans2.Text == "")
            {
                UserSecurityAnswers.Add("Enter Answer 2");
            }
            if (dropq3.SelectedValue == "Select Questions")
            {
                UserSecurityAnswers.Add("Enter Question 3");
            }
            if (txtans3.Text == "")
            {
                UserSecurityAnswers.Add("Enter Answer 3");
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            validuser();
            divquestion.Visible = true;
            divuserinfo.Visible = false;
            // var sub = Insertuserinfo.info(txtuser.Text, txtemail.Text, txtprofile.Text, txtaddress.Text, txtcity.Text, txtzip.Text, txtpassword.Text, txtstate.Text);
            if (UserRegistrationError.Count == 0)
            {
                String username = txtuser.Text;
                Boolean flag = checkusername(username);
                if (flag == true)
                {
                    Response.Write("User Already Exist");
                }
                else
                {
                    //var sub = Insertuserinfo.info(txtuser.Text, txtemail.Text, txtprofilename.Text, txtaddress.Text, txtcity.Text, txtzip.Text, txtpassword.Text, txtstate.Text);
                    SqlCommand comm = new SqlCommand();
                    DBConnect dbconn = new DBConnect();
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = "TPRegisterUser";
                    SqlParameter inputParameter = new SqlParameter("@username", txtuser.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@email", txtemail.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@name", txtprofilename.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@address", txtaddress.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@city", txtcity.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@password", txtpassword.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@state", txtstate.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@zip", int.Parse(txtzip.Text.ToString()));
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.Int;
                    comm.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@phone", txtphone.Text.ToString());
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    inputParameter.Size = 50;
                    comm.Parameters.Add(inputParameter);

                    int Received = dbconn.DoUpdateUsingCmdObj(comm);
                    if (Received == 1)
                    {
                        Session["username"] = txtuser.Text.ToString();
                        //Response.Redirect("profile.aspx");
                    }
                    else
                    {

                    }
                    //var error = dbconn.DoUpdateUsingCmdObj(comm);
                    //return error.ToString()
                }
            }
        }

        public Boolean checkusername(string username)
        {
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPCheckIfUserExist";
            SqlParameter inputparameter = new SqlParameter("@username", username);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputparameter);

            DataSet usernamedataset = dbconn.GetDataSetUsingCmdObj(comm);
            if (usernamedataset.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void btncomplete_Click1(object sender, EventArgs e)
        {
            validuserquestions();
            if (UserSecurityAnswers.Count == 0)
            {


                DBConnect dbconn = new DBConnect();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "TPInsertSecurityQuestion";
                SqlParameter inputParameter = new SqlParameter("@username", Session["username"].ToString());
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                comm.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Q1", dropq1.SelectedValue.ToString());
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                comm.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@A1", txtans1.Text.ToString());
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                comm.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Q2", dropq2.SelectedValue.ToString());
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                comm.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@A2", txtans2.Text.ToString());
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                comm.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@Q3", dropq3.SelectedValue.ToString());
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                comm.Parameters.Add(inputParameter);

                inputParameter = new SqlParameter("@A3", txtans3.Text.ToString());
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                inputParameter.Size = 50;
                comm.Parameters.Add(inputParameter);

                int Recevied = dbconn.DoUpdateUsingCmdObj(comm);
                if (Recevied == 1)
                {
                    Response.Write("Application Submited");
                    HttpCookie userinfo = new HttpCookie("userinfo");
                    DateTime now = DateTime.Now;
                    userinfo.Values["username"] = txtuser.Text;
                    userinfo.Values["pass"] = txtpassword.Text;
                    userinfo.Values["time"] = now.ToString();
                    userinfo.Expires = now.AddYears(30);
                    Response.Cookies.Add(userinfo);
                    Response.Redirect("Paymentpage.aspx");
                }
            }
            else
            {
                for (int i = 0; i < UserSecurityAnswers.Count; i++)
                {
                    Response.Write(UserSecurityAnswers[i] + "<br/>");
                }
            }
        }
    }
}