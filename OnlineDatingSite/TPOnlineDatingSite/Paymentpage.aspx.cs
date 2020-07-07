using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Utilities;
using System.Text;
using System.Collections;
using System.Net;
using System.Web.Script.Serialization;

namespace TPOnlineDatingSite
{
    public partial class Paymentpage : System.Web.UI.Page
    {
        ArrayList AddCreditCardArray = new ArrayList();
        PaymentClass pay = new PaymentClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //string exp = month.SelectedValue + "/" + year.SelectedValue;
            //string username = Session["username"].ToString();
            //var createpayment = pay.paymentmethod(txtname.Text, txtcardnumber.Text,ddlCardType.SelectedValue,txtcvv.Text, ddlsub.SelectedValue, username,monthl.SelectedValue, yearl.SelectedValue);
            //if (createpayment != "-1")
            //{
            //    Server.Transfer("ViewProfile.aspx");
            //}
            //else
            //{
            //    Response.Write("<script>alert('Something Wrong') </script>");
            //}

            ValidateAddCreditCard();
            if (!(AddCreditCardArray.Count > 0))
            {
                PaymentClass CredtiCardObject = new PaymentClass();
                CredtiCardObject.apikey = "1254";
                CredtiCardObject.Username = Session["username"].ToString();
                CredtiCardObject.Cardname = txtname.Text.ToString();
                CredtiCardObject.Cardnumber = txtcardnumber.Text.ToString();
                CredtiCardObject.Cardtype = ddlCardType.SelectedValue.ToString();
                CredtiCardObject.Ccv = txtcvv.Text.ToString();
                CredtiCardObject.Monthlysubscription = ddlsub.SelectedValue.ToString();
                CredtiCardObject.Month = monthl.SelectedValue.ToString();
                CredtiCardObject.Year = yearl.SelectedValue.ToString();
               
                JavaScriptSerializer js = new JavaScriptSerializer();  //Coverts Object into JSON String
                String jsonCreditCard = js.Serialize(CredtiCardObject);

                try
                {
                    // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.
                    WebRequest request = WebRequest.Create("http://localhost:50377/api/Payment/InsertPaymentInfo/");
                    request.Method = "POST";
                    request.ContentLength = jsonCreditCard.Length;
                    request.ContentType = "application/json";

                    // Write the JSON data to the Web Request
                    StreamWriter writer = new StreamWriter(request.GetRequestStream());
                    writer.Write(jsonCreditCard);
                    writer.Flush();
                    writer.Close();

                    // Read the data from the Web Response, which requires working with streams.

                    WebResponse response = request.GetResponse();
                    Stream theDataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(theDataStream);
                    string data = reader.ReadToEnd();
                    reader.Close();
                    response.Close();
                    if (data == "true")
                    {
                        Server.Transfer("profile.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Credit Card Already Exist Or Error Occured on the database.')</script>");
                    }
                }
                catch (Exception errorException)
                {
                    Response.Write(errorException.Message);
                }
            }
            else
            {
                for (int i = 0; i < AddCreditCardArray.Count; i++)
                {
                    Response.Write(AddCreditCardArray[i] + " <br/>");
                }
            }
        }
        public void ValidateAddCreditCard()
        {
            if (txtcardnumber.Text.Length < 10)
            {
                AddCreditCardArray.Add("<script>alert('Credit Card Length is 10 digits')</script>");
                
            }
            long j;
            if (!Int64.TryParse(txtcardnumber.Text, out j))
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
    }
}