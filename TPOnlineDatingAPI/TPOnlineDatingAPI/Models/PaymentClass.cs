using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Utilities;

namespace TPOnlineDatingAPI.Models
{
    public class PaymentClass
    {
        public string apikey { get; set; }
        public string Cardname { get; set; }
        public string Cardnumber { get; set; }
        public string Cardtype { get; set; }
        public string Ccv { get; set; }
        public string Monthlysubscription { get; set; }
        public string Username { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

        public PaymentClass(string cardholder, string cardnumber, string cardtype, string ccv, string monthlysubscription, string username, string month, string year)
        {

            this.Cardname = cardholder;
            this.Cardnumber = cardnumber;
            this.Cardtype = cardtype;
            this.Ccv = ccv;
            this.Monthlysubscription = monthlysubscription;
            this.Username = username;
            this.Month = month;
            this.Year = year;

        }

        public PaymentClass()
        {
        }

        public PaymentClass(string userName)
        {
            this.Username = userName;
        }
        public int createpayment(PaymentClass info)
        {
            DBConnect dbConnection = new DBConnect();

            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TP_Card_Info";

            SqlParameter inputparameter = new SqlParameter("@Card_Holder_Name", info.Cardname);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            comm.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Card_Number", info.Cardnumber);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Card_Type", info.Cardtype);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            comm.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Card_Ccv", info.Ccv);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            comm.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Monthly_Subscription", info.Monthlysubscription);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            comm.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@username", info.Username);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            comm.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Month", info.Month);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            comm.Parameters.Add(inputparameter);

            inputparameter = new SqlParameter("@Year", info.Year);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;

            comm.Parameters.Add(inputparameter);

            int ResponseReceived = dbConnection.DoUpdateUsingCmdObj(comm);
            return ResponseReceived;
        }


        public int PostCreditCard(PaymentClass info)
        {
            int ResponseReceived = -2;
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPUpdateCardInfo";

            SqlParameter inputParameter = new SqlParameter("@username", info.Username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@cardholdername", info.Cardname);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@cardnumber", info.Cardnumber);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@cardtype", info.Cardtype);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ccv", info.Ccv);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@month", info.Month);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@year", int.Parse(info.Year.ToString()));
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            comm.Parameters.Add(inputParameter);

            //SqlCommand secondcomm = new SqlCommand();
            //secondcomm.CommandType = CommandType.StoredProcedure;
            //secondcomm.CommandText = "TPCheckuserinfo";

            //SqlParameter secondparameter = new SqlParameter("@username", info.Username);
            //secondparameter.Direction = ParameterDirection.Input;
            //secondparameter.SqlDbType = SqlDbType.VarChar;
            //secondcomm.Parameters.Add(secondparameter);

            //DataSet GetCreditCardinfo = dbconn.GetDataSetUsingCmdObj(secondcomm);
            //if (GetCreditCardinfo.Tables[0].Rows.Count != 0 && GetCreditCardinfo != null && GetCreditCardinfo.Tables.Count != 0)
            //{
            ResponseReceived = dbconn.DoUpdateUsingCmdObj(comm);
            return ResponseReceived;
            //}
            //return ResponseReceived;

        }


        public List<PaymentClass> GetCardInfo(PaymentClass usernameonject)
        {
            List<PaymentClass> GetCard = new List<PaymentClass>();
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPGetCardInfo";

            SqlParameter inputparameter = new SqlParameter("@usernam", usernameonject.Username.ToString());
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputparameter);

            DataSet GetCreditCardinfo = dbconn.GetDataSetUsingCmdObj(comm);
            if (GetCreditCardinfo.Tables[0].Rows.Count != 0 && GetCreditCardinfo != null && GetCreditCardinfo.Tables.Count != 0)
            {
                PaymentClass PC;

                PC = new PaymentClass();

                //Username = GetCreditCardinfo.Tables[0].Rows[i]["username"].ToString(),
                PC.Cardname = GetCreditCardinfo.Tables[0].Rows[0]["Card_Holder_Name"].ToString();
                PC.Cardnumber = GetCreditCardinfo.Tables[0].Rows[0]["Card_Number"].ToString();
                PC.Cardtype = GetCreditCardinfo.Tables[0].Rows[0]["Card_Type"].ToString();
                PC.Ccv = GetCreditCardinfo.Tables[0].Rows[0]["Card_Ccv"].ToString();
                //PC.Monthlysubscription = GetCreditCardinfo.Tables[0].Rows[0]["Monthly_Subscription"].ToString();
                PC.Month = GetCreditCardinfo.Tables[0].Rows[0]["Month"].ToString();
                PC.Year = GetCreditCardinfo.Tables[0].Rows[0]["Year"].ToString();

                GetCard.Add(PC);


                return GetCard;
            }
            else
            {
                return GetCard;
            }


        }







    }
}
