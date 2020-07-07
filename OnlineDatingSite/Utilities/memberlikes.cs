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
    public class memberlikes
    {
        DBConnect dbconn = new DBConnect();


        public DataSet TP_MemberGetUserList(string username)
        {
            
            SqlCommand dbCommand = new SqlCommand();
            dbCommand.CommandType = CommandType.StoredProcedure;
            dbCommand.CommandText = "TPMemberGetUserList";

            SqlParameter inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            dbCommand.Parameters.Add(inputParameter);

            DataSet myDS = dbconn.GetDataSetUsingCmdObj(dbCommand);

            return myDS;
        }

        public string TPLikeMember(string username, string userto, string value)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPLike_Member";
            SqlParameter inputParameter = new SqlParameter("@UsernameReqFrom", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@UsernameReqTo", userto);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);


            inputParameter = new SqlParameter("@LikeDislike", value);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            //inputParameter = new SqlParameter("@Request", rvalue);
            //inputParameter.Direction = ParameterDirection.Input;
            //inputParameter.SqlDbType = SqlDbType.VarChar;
            //inputParameter.Size = 50;
            //comm.Parameters.Add(inputParameter);

            var error = dbconn.DoUpdateUsingCmdObj(comm);
            return error.ToString();
        }

        public DataSet TPGetLikeDislikeMember(string username, string value)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPGet_LikeDislike_Member";

            SqlParameter inputParameter = new SqlParameter("@UsernameReqFrom", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@LikeDislike", value);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            comm.Parameters.Add(inputParameter);

            DataSet myDS = dbconn.GetDataSetUsingCmdObj(comm);

            return myDS;
        }

        public DataSet TPGetRequestMember(string username, string value)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPGet_Request_Member";

            SqlParameter inputParameter = new SqlParameter("@UsernameReqFrom", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@Request", value);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.Int;
            comm.Parameters.Add(inputParameter);

            DataSet myDS = dbconn.GetDataSetUsingCmdObj(comm);

            return myDS;
        }

        public string TPRequestMember(string username, string userto, string value)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPRequest_Member";
            SqlParameter inputParameter = new SqlParameter("@UsernameReqFrom", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@UsernameReqTo", userto);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);


            inputParameter = new SqlParameter("@Request", value);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);

            var error = dbconn.DoUpdateUsingCmdObj(comm);
            return error.ToString();
        }

        //Request Get SP 
        public DataSet TPRequestAcceptOp(string username)
        {
            
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPRequest_Accept_Op";

            SqlParameter inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);


            DataSet myDS = dbconn.GetDataSetUsingCmdObj(comm);

            return myDS;
        }

        public DataSet TPRequestAcceptMember(string username)
        {

            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPRequest_Accept_Member";

            SqlParameter inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            inputParameter.Size = 50;
            comm.Parameters.Add(inputParameter);


            DataSet myDS = dbconn.GetDataSetUsingCmdObj(comm);

            return myDS;
        }
    }
}
