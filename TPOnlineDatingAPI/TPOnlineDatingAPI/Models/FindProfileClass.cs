using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using System.Text;

namespace TPOnlineDatingAPI.Models
{
    public class FindProfileClass
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string occupation { get; set; }
        public string WantKid { get; set; }
        public string commit { get; set; }
        public string profilepic { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }

        //public FindProfileClass()
        //{

        //}

        public string FindbyName(string name)
        {
            this.Name = name;
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();

            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPFindProfilebyName";
            //comm.Parameters.AddWithValue("@name", name);
            SqlParameter inputparameter = new SqlParameter("@name", name);
            inputparameter.Direction = ParameterDirection.Input;
            inputparameter.SqlDbType = SqlDbType.VarChar;
            inputparameter.Size = 50;
            comm.Parameters.Add(inputparameter);

            DataSet myDS = dbconn.GetDataSetUsingCmdObj(comm);
            if (myDS.Tables[0].Rows.Count > 0)
            {
                return "true";
            }
            else
            {
                return "false";

            }


        }
        public string Findprofilebyoccupation(string Occupation)
        {
            this.occupation =Occupation;
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPFindProfilebyOccupation";
            comm.Parameters.AddWithValue("@occupation", occupation);
            DataSet myds = dbconn.GetDataSetUsingCmdObj(comm);

            if (myds.Tables[0].Rows.Count > 0)
            {
                return "true";
            }
            else
            {
                return "false";
            }

        }
    }
}
