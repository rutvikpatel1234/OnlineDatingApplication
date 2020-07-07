using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Net;
using System.IO;
using System.Collections;
using Utilities;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TPOnlineDatingSite
{
    public partial class UpdatePayment : System.Web.UI.Page
    {
        ArrayList AddCreditCardArray = new ArrayList();
        ArrayList UpdateCreditCardArray = new ArrayList();
        PaymentClass pay = new PaymentClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["username"] as string))
            {
                Response.Redirect("NoSession.aspx");
            }
            string username = Session["username"].ToString();
            divupdatecard.Visible = false;
            divcardinfo.Visible = true;
            Getcardeinfo();
        }

        public void Getcardeinfo()
        {
            WebRequest request = WebRequest.Create("http://localhost:50377/api/Payment/GetPaymentInfo/" + Session["username"].ToString());
            WebResponse response = request.GetResponse();

            //Read the date from the web response
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            string data = reader.ReadToEnd();
            reader.Close();
            response.Close();

            JavaScriptSerializer js = new JavaScriptSerializer();

            PaymentClass[] creditinfo = js.Deserialize<PaymentClass[]>(data);
            gvcardinfo.DataSource = creditinfo;
            gvcardinfo.DataBind();


        }
        public void ValidateAddCreditCard()
        {
            if (txtcardnumber.Text.Length < 10)
            {
                AddCreditCardArray.Add("<script>alert('Credit Card Length is 10 digits')</script>");

            }
            long j;
            if (txtcardnumber.Text.Length < 10)
            {
                AddCreditCardArray.Add("<script>alert('DIGITS ONLY in Credit Card Field')</script>");
            }


            if (txtcvv.Text.Length < 3)
            {
                AddCreditCardArray.Add("<script>alert('Secure Code Length is 3 digits')</script>");
            }
            //int b;
            //if (!Int32.TryParse(txtcvv.Text, out b))
            //{
            //    AddCreditCardArray.Add("<script>alert('DIGITS ONLY in Secure Code Field')</script>");
            //}

            if (txtname.Text == "")
            {
                AddCreditCardArray.Add("<script>alert('Text Required in Card Holder Name Field')</script>");
            }



        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {
            divupdatecard.Visible = true;
            divcardinfo.Visible = false;
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            ValidateAddCreditCard();
            if(!(AddCreditCardArray.Count > 0))
            {
                PaymentClass Creditcard = new PaymentClass();
                Creditcard.apikey = "1254";
                Creditcard.Cardname = txtname.Text.ToString();
                Creditcard.Cardnumber = txtcardnumber.Text.ToString();
                Creditcard.Cardtype = ddlCardType.SelectedValue.ToString();
                Creditcard.Ccv = txtcvv.Text.ToString();
                Creditcard.Month = monthl.SelectedValue.ToString();
                Creditcard.Username = Session["username"].ToString();
                Creditcard.Year = yearl.SelectedValue.ToString();
                JavaScriptSerializer js = new JavaScriptSerializer();
                String jsoncreditcard = js.Serialize(Creditcard);
                try
                {
                    WebRequest request = WebRequest.Create("http://localhost:50377/api/Payment/UpdateCreditCard/");
                    request.Method = "PUT";
                    request.ContentLength = jsoncreditcard.Length;
                    request.ContentType = "application/json";

                    StreamWriter writer = new StreamWriter(request.GetRequestStream());
                    writer.Write(jsoncreditcard);
                    writer.Flush();
                    writer.Close();

                    WebResponse response = request.GetResponse();
                    Stream theDataStrem = response.GetResponseStream();
                    StreamReader reader = new StreamReader(theDataStrem);
                    String data = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                    if(data == "true")
                    {
                        Response.Write("<script>alert('Credit Card as Updated')</script>");
                        Getcardeinfo();
                    }
                    else
                    {
                        Response.Write("<script>alert('Something Went Wrong')</script>");
                    }
                }
                catch(Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}