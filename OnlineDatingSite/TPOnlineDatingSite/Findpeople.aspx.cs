using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Collections;
using System.Text;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;

namespace TPOnlineDatingSite
{
    public partial class Findpeople : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            divadvance.Visible = false;
            divprofilecard.Visible = false;
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:50377/api/Search/Findbyname/" + txtname.Text);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            string data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();
          
            Findprofile findprofile = js.Deserialize<Findprofile>(data);

            ReadInfo(findprofile);
            divprofilecard.Visible = true;
           // Findprofile[] findprofile = js.Deserialize<Findprofile[]>(data);

        }
        public void ReadInfo(Findprofile findprofile)
        {
            string InnerHtml = string.Empty;
            //string username = Session["username"].ToString();
            StringBuilder sb = new StringBuilder("");
          
            {


                sb.Append("<div class=\"card text-white bg-dark mb-3 details\" style=\"width: 20rem;\">");
                sb.Append("<img class=\"card-img-top imgheight\" src=\"" + findprofile.profilepic + "\" alt=\"Card image cap\">");
                sb.Append("<div class=\"card-body\">");
                sb.Append("<h6 class=\"card-title\">Name:" + findprofile.Name + "</h6> <span class=\"card-title\">");
                sb.Append("<h6 class=\"card-title\">Gender:" + findprofile.Gender + "</h6> <span class=\"card-title\">");
                sb.Append("<h6 class=\"card-title\">Age:" + findprofile.Age + "</h6> <span class=\"card-title\"> Occupation:" + findprofile.occupation + "</span> <br/> <br/><span class=\"card-title\"> Commit Type:" + findprofile.commit + "</span>");
                sb.Append("</div>");
                sb.Append("<div class=\"modal-footer\">");
                sb.Append("<a href=\"LikeDisLike.aspx?_userTo=" + findprofile.Username + "&value=1" + "\"class=\"btn btn-success btn-sm fas fa-heart fa-2x\"></a>"
                                       + "<a href=\"LikeDisLike.aspx?_userTo=" + findprofile.Username + "&value=0" + "\"class=\"btn btn-danger btn-sm fas fa-times fa-2x\"></a>" +
                                                                      "<a href=\"MemberHomeView.aspx?_id=" + findprofile.Username + "\"class=\"btn btn-info btn-sm fas fa-eye fa-2x\"></a>" +
                                                                      "<a href=\"MessageConversation.aspx?_msgTo=" + findprofile.Username + "\"class=\"btn btn-light btn-sm fas fa-comments fa-2x\"></a>");
                sb.Append("</div></div>");
                divprofilecard.InnerHtml = sb.ToString();

            }
        }

        protected void btnadvance_Click(object sender, EventArgs e)
        {
            divadvance.Visible = true;
        }

        protected void btnsubmitgender_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:50377/api/Search/Findbywantkid/" + txtgender.Text);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            string data = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Findprofile> findprofile = js.Deserialize<List<Findprofile>>(data);

            ReadInfo(findprofile);
            divprofilecard.Visible = true;
        }

        protected void btnsubmitcommiy_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:50377/api/Search/Findbycommtype/" + dropcommit.SelectedValue);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            string data = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
           List<Findprofile>  findprofile = js.Deserialize<List<Findprofile>>(data);


            ReadInfo(findprofile);
            divprofilecard.Visible = true;
        }
        public void ReadInfo(List<Findprofile> findprofile)
        {
            string InnerHtml = string.Empty;
            string username = Session["username"].ToString();
            
       

                StringBuilder sb = new StringBuilder("");

                foreach (var info in findprofile)
                {
                    if (!username.Equals(info.Username))
                    {


                        sb.Append("<div class=\"card text-white bg-dark mb-3 details\" style=\"width: 20rem;\">");
                        sb.Append("<img class=\"card-img-top imgheight\" src=\"" + info.profilepic + "\" alt=\"Card image cap\">");
                        sb.Append("<div class=\"card-body\">");
                        sb.Append("<h6 class=\"card-title\">Name:" + info.Name + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Gender:" + info.Gender + "</h6> <span class=\"card-title\">");
                        sb.Append("<h6 class=\"card-title\">Age:" + info.Age + "</h6> <span class=\"card-title\"> Occupation:" + info.occupation + "</span> <br/> <br/><span class=\"card-title\"> Commit Type:" + info.commit + "</span>");
                        sb.Append("</div>");
                        sb.Append("<div class=\"modal-footer\">");
                    sb.Append("<a href=\"LikeDisLike.aspx?_userTo=" + info.Username + "&value=1" + "\"class=\"btn btn-success btn-sm fas fa-heart fa-2x\"></a>"
                   + "<a href=\"LikeDisLike.aspx?_userTo=" + info.Username + "&value=0" + "\"class=\"btn btn-danger btn-sm fas fa-times fa-2x\"></a>" +
                                                  "<a href=\"MemberHomeView.aspx?_id=" + info.Username + "\"class=\"btn btn-info btn-sm fas fa-eye fa-2x\"></a>" +
                                                  "<a href=\"MessageConversation.aspx?_msgTo=" + info.Username + "\"class=\"btn btn-light btn-sm fas fa-comments fa-2x\"></a>");
                        sb.Append("</div></div>");

                    }
                   

                }
               divprofilecard.InnerHtml = sb.ToString();
        }

        protected void btnsubmitname_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:50377/api/Search/Findbyage/" + txtage1.Text+ "/" + txtage2.Text);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            string data = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Findprofile> findprofile = js.Deserialize<List<Findprofile>>(data);

            ReadInfo(findprofile);
            divprofilecard.Visible = true;
        }

        protected void btnsubmitoccupation_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create("http://localhost:50377/api/Search/Findbyoccupation/" + txtoccupation.Text);
            WebResponse response = request.GetResponse();

            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            string data = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Findprofile> findprofile = js.Deserialize<List<Findprofile>>(data);

            ReadInfo(findprofile);
            divprofilecard.Visible = true;
        }
    }
}