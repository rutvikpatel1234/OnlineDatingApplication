using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TPOnlineDatingAPI.Models;
using Utilities;
using System.Data.SqlClient;

namespace TPOnlineDatingAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Search")]
    public class FindProfileController : Controller
    {
        //Get Profile by Name
        //[Route("getName")]
        //[HttpGet]
        //public string FindbyName([FromBody]FindProfileClass myname)
        //{
        //    //if (myname.ToString() != "")
        //    //{
        //    //    FindProfileClass whateverobj = new FindProfileClass();
        //    //    FindProfileClass Retrieveobj = new FindProfileClass();
        //    //    Retrieveobj.Name = myname;
        //    //    return whateverobj.FindbyName(Retrieveobj);
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //    FindProfileClass retrievesearchbyname = new FindProfileClass();
        //    return retrievesearchbyname.FindbyName(myname.Name);
        //}


        [HttpGet("Findbyname/{name}")]
        public FindProfileClass FindprofilebyName(String name)
        {
            FindProfileClass prof = null;
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPFindProfilebyName";

            
            comm.Parameters.AddWithValue("@name", name);
            DataSet myds = dbconn.GetDataSetUsingCmdObj(comm);
            if (myds.Tables[0].Rows.Count > 0)
            {
                prof = new FindProfileClass();
                prof.Name = dbconn.GetField("name", 0).ToString();
                prof.Gender = dbconn.GetField("gender", 0).ToString();
                prof.Age = dbconn.GetField("age", 0).ToString();
                prof.occupation = dbconn.GetField("occupation", 0).ToString();
                prof.commit = dbconn.GetField("commtype", 0).ToString();
                prof.profilepic = dbconn.GetField("profilepic", 0).ToString();
                prof.WantKid = dbconn.GetField("wantskids", 0).ToString();
                prof.Username = dbconn.GetField("username", 0).ToString();
            }
            return prof;

        }

      
        [HttpGet("Findbyoccupation/{occupation}")]
        public List<FindProfileClass> Findprofilebyoccupation(String occupation)
        {
            List<FindProfileClass> occlist = new List<FindProfileClass>();
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPFindProfilebyOccupation";
            comm.Parameters.AddWithValue("@occupation", occupation);
            DataSet myds = dbconn.GetDataSetUsingCmdObj(comm);
            int count = myds.Tables[0].Rows.Count;
            for(int i = 0; i < count; i++)
            {
                FindProfileClass prof = new FindProfileClass();
                prof.Name = dbconn.GetField("name", i).ToString();
                prof.Gender = dbconn.GetField("gender", i).ToString();
                prof.Age = dbconn.GetField("age", i).ToString();
                prof.occupation = dbconn.GetField("occupation", i).ToString();
                prof.profilepic = dbconn.GetField("profilepic", i).ToString();
                prof.commit = dbconn.GetField("commtype", i).ToString();
                prof.WantKid = dbconn.GetField("wantskids", i).ToString();
                prof.Username = dbconn.GetField("username", i).ToString();
                occlist.Add(prof);
            }
            return occlist;
        }

        [HttpGet("Findbywantkid/{kid}")]
        public List<FindProfileClass>Findprofilebywantkid(String kid)
        {
            List<FindProfileClass> kidlist = new List<FindProfileClass>();
            DBConnect conn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPFindProfilebywantkid";
            comm.Parameters.AddWithValue("@kid", kid);
            DataSet myDS = conn.GetDataSetUsingCmdObj(comm);
            int count = myDS.Tables[0].Rows.Count;
            for(int i = 0; i < count; i++)
            {
                FindProfileClass prof = new FindProfileClass();
                prof.Name = conn.GetField("name", i).ToString();
                prof.Gender = conn.GetField("gender", i).ToString();
                prof.Age = conn.GetField("age", i).ToString();
                prof.occupation = conn.GetField("occupation", i).ToString();
                prof.profilepic = conn.GetField("profilepic", i).ToString();
                prof.commit = conn.GetField("commtype", i).ToString();
                prof.WantKid = conn.GetField("wantskids", i).ToString();
                prof.Username = conn.GetField("username", i).ToString();
                kidlist.Add(prof);
            }

            return kidlist;
        }

        [HttpGet("Findbycommtype/{committype}")]
        public List<FindProfileClass> Findprofilebycommittype(string committype)
        {
            List<FindProfileClass> commitlist = new List<FindProfileClass>();
            DBConnect dbconn = new DBConnect();
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.CommandType = CommandType.StoredProcedure;
            sqlcomm.CommandText = "TPFindProfilebycommtype";
            sqlcomm.Parameters.AddWithValue("@type", committype);
            DataSet ds = dbconn.GetDataSetUsingCmdObj(sqlcomm);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                FindProfileClass prof = new FindProfileClass();
                prof.Name = dbconn.GetField("name", i).ToString();
                prof.Gender = dbconn.GetField("gender", i).ToString();
                prof.Age = dbconn.GetField("age", i).ToString();
                prof.occupation = dbconn.GetField("occupation", i).ToString();
                prof.profilepic = dbconn.GetField("profilepic", i).ToString();
                prof.commit = dbconn.GetField("commtype", i).ToString();
                prof.WantKid = dbconn.GetField("wantskids", i).ToString();
                prof.Username = dbconn.GetField("username", i).ToString();
                commitlist.Add(prof);
            }
            return commitlist;
        }

        [HttpGet("Findbyage/{age1}/{age2}")]
        public List<FindProfileClass>Findprofilebyage(string age1, string age2)
        {
            List<FindProfileClass> agelist = new List<FindProfileClass>();
            DBConnect dbconn = new DBConnect();
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "TPFindProfilebyage";
            comm.Parameters.AddWithValue("@age1", age1);
            comm.Parameters.AddWithValue("@age2", age2);
            DataSet ds = dbconn.GetDataSetUsingCmdObj(comm);
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                FindProfileClass prof = new FindProfileClass();
                prof.Name = dbconn.GetField("name", i).ToString();
                prof.Gender = dbconn.GetField("gender", i).ToString();
                prof.Age = dbconn.GetField("age", i).ToString();
                prof.occupation = dbconn.GetField("occupation", i).ToString();
                prof.profilepic = dbconn.GetField("profilepic", i).ToString();
                prof.commit = dbconn.GetField("commtype", i).ToString();
                prof.WantKid = dbconn.GetField("wantskids", i).ToString();
                prof.Username = dbconn.GetField("username", i).ToString();
                agelist.Add(prof);
            }
            return agelist;
        }

        //[HttpGet("Findbyage/{age1}/{age2}")]
        //public DataSet Findprofliebyage(string age1, string age2)
        //{

        //    DBConnect dbconn = new DBConnect();
        //    SqlCommand comm = new SqlCommand();
        //    comm.CommandType = CommandType.StoredProcedure;
        //    comm.CommandText = "TPFindProfilebyage";
        //    comm.Parameters.AddWithValue("@age1", age1);
        //    comm.Parameters.AddWithValue("@age2", age2);
        //    DataSet ageds = dbconn.GetDataSetUsingCmdObj(comm);
        //    int count = ageds.Tables[0].Rows.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        FindProfileClass prof = new FindProfileClass();
        //        prof.Name = dbconn.GetField("name", i).ToString();
        //        prof.Gender = dbconn.GetField("gender", i).ToString();
        //        prof.Age = dbconn.GetField("age", i).ToString();
        //        prof.occupation = dbconn.GetField("occupation", i).ToString();
        //        prof.commit = dbconn.GetField("profilepic", i).ToString();
        //        prof.profilepic = dbconn.GetField("commtype", i).ToString();
        //        prof.WantKid = dbconn.GetField("wantskids", i).ToString();

        //        ageds.Add(prof);
        //    }
        //    return ageds;

        //}


    }
}
