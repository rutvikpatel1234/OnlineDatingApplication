using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TPOnlineDatingAPI.Models;
using Utilities;

namespace TPOnlineDatingAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Payment")]
    public class PaymentController : Controller
    {
        //InsertCreditCardDetail Post Method
        [Route("InsertPaymentInfo")]
        [HttpPost]

        public Boolean Post([FromBody] PaymentClass info)
        {
            if (info != null && info.apikey == "1254")
            {
                PaymentClass CredtiCardObject = new PaymentClass();
                int ResponseReceived = CredtiCardObject.createpayment(info);
                if (ResponseReceived == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        [Route("GetPaymentInfo/{username}")]
        [HttpGet("{username}")]
        public List<PaymentClass> GetCard(string username)
        {
            List<PaymentClass> cardinfo = new List<PaymentClass>();


            if (username.ToString() != "")
            {
                PaymentClass whateverobject = new PaymentClass();
                PaymentClass RetrieveObject = new PaymentClass();
                RetrieveObject.Username = username;
                return whateverobject.GetCardInfo(RetrieveObject);
            }
            else
            {
                return cardinfo;
            }






        }
        [Route("UpdateCreditCard")]
        [HttpPut]
        public Boolean updatecard([FromBody] PaymentClass info)
        {
            if (info != null && info.apikey == "1254")
            {
                PaymentClass creditcard = new PaymentClass();
                int ResponseReceived = creditcard.PostCreditCard(info);
                if (ResponseReceived == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}