using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Utilities
{
    public class DatingClass
    {
        DBConnect dbconn = new DBConnect();

        public string TPDatingReq(string User_Sender, string User_Receiver, string Date, string Location, string Place)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPDating_Req";
            SqlParameter inputParameter = new SqlParameter("@User_Sender", User_Sender);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@User_Receiver", User_Receiver);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);


            inputParameter = new SqlParameter("@Date", Date);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Date;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Location", Location);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Place", Place);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            var error = dbconn.DoUpdateUsingCmdObj(comm);
            return error.ToString();
        }

        public DataSet TPGetDatingReq(string User_Sender, string User_Receiver)
        {

            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPGet_Dating_Req";

            SqlParameter inputParameter = new SqlParameter("@username", User_Sender);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@username1", User_Receiver);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);
           


            DataSet myDS = dbconn.GetDataSetUsingCmdObj(comm);

            return myDS;
        }
    }
}
