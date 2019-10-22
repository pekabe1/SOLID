using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.D
{
    public class Messenger

    {

        //    public string SendMessages()

        //    {

        //        Sms sms = new Sms();

        //        Email email = new Email();

        //        Mms mms = new Mms();

        //        return $"Wysyłam widomość za pomocą: {sms.SendSMS()}; {email.SendEmal()}; {mms.SendMMS()}";

        //    }

     }

        public class Sms : IMessage

        {
            public string Send(string message)
            {
                return message + " sms ";
            }
        }

        public class Email : IMessage

        {
            public string Send(string message)
            {
                return message + " email ";
            }
        }

        public class Mms : IMessage

        {
            public string Send(string message)
            {
                return message + " mms ";
            }
        }


    public class gołomp : IMessage

    {
        public string Send(string message)
        {
            return message + " gołomp ";
        }
    }
}

