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
    public class userinfo
    {
        DBConnect dbconn = new DBConnect();
        public string info(string username, string email, string name,string address,string city, string zip, string password, string state)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPRegisterUser";
            SqlParameter inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@email", email);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@name", name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@address", address);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@city", city);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@password", password);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@state", state);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@zip", zip);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            comm.Parameters.Add(inputParameter);

            var error = dbconn.DoUpdateUsingCmdObj(comm);
            return error.ToString();
        }


        public string securityquestions(string q1, string a1, string q2, string a2, string q3, string a3)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPInsertSecurityQuestion";
            SqlParameter inputParameter = new SqlParameter("@Q1", q1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@A1", a1);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Q2", q2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@A2", a2);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Q3", q3);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@A3", a3);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            var error = dbconn.DoUpdateUsingCmdObj(comm);
            return error.ToString();
        }

        public string TP_Userprofile(string username,string occupation, string fileName ,string gender ,string age,string height,string weight,
            string interests, string likes, string dislikes, string favrestaurants, string favbooks,string favmovies,  string favpoems,
            string commtype, string haskids, string wantskids,  string religion,  string description )
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPCreaterUserProfile";
            SqlParameter inputParameter = new SqlParameter("@occupation", occupation);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@gender", gender);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@age", age);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@height", height);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@weight", weight);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@interests", interests);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@likes", likes);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@dislikes", dislikes);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@favrestaurants", favrestaurants);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@favbooks", favbooks);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@favmovies", favmovies);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            

            inputParameter = new SqlParameter("@favpoems", favpoems);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            

            inputParameter = new SqlParameter("@commtype", commtype);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@haskids", haskids);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@wantskids", wantskids);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@religion", religion);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            

            inputParameter = new SqlParameter("@description", description);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@profilepic", fileName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 200;
            comm.Parameters.Add(inputParameter);

            var error = dbconn.DoUpdateUsingCmdObj(comm);
            return error.ToString();
        }
        public DataSet TPGetuserinfo_userprofile(string @username)
        {
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.CommandType = CommandType.StoredProcedure;
            dbCommand.CommandText = "TPGetUserInfo_UserProfile";
            SqlParameter inputParameter = new SqlParameter();

            inputParameter = new SqlParameter("@username", @username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            dbCommand.Parameters.Add(inputParameter);
            inputParameter.Size = 50;

            DataSet myDS = dbconn.GetDataSetUsingCmdObj(dbCommand);

            return myDS;
        }

        public string TPuserupdate(string username, string name, string age,string gender  , string occupation, string commtype, string fileName)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPGetUserInfo_UserProfile_Update";
            SqlParameter inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@name", name);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);


            inputParameter = new SqlParameter("@age", age);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@gender", gender);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@occupation", occupation);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@commtype", commtype);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@profilepic", fileName);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            var error = dbconn.DoUpdateUsingCmdObj(comm);
            return error.ToString();
        }

        public DataSet TP_GetUserList()
        {
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.CommandType = CommandType.StoredProcedure;
            dbCommand.CommandText = "TPGetUserList";
           
            

            DataSet myDS = dbconn.GetDataSetUsingCmdObj(dbCommand);

            return myDS;
        }

        

        

    }
}
