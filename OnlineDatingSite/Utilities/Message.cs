using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Message
    {
        private int MessageID;
        private String SenderUser;
        private String ReceiveUser;
        private String messageBody;
        private DateTime messageDate;

        public int messageID { get; set; }
        public String senderuser { get; set; }
        public String receiveuser { get; set; }
        public String MessageBody { get; set; }
        public DateTime MessageDate { get; set; }

    }
}
