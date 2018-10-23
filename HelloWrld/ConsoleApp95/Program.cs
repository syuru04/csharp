using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;



namespace EmailSmtp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("pow852014@gmail.com", "비밀번호");

                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("pow852014@gmail.com"),
                    Subject = "ILUVU",
                    Body = "Will you merry me?"
                };

                mail.To.Add(new MailAddress("elinmk627@gmail.com"));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Email sccessfully sent");
            Console.ReadKey();
        }
    }
}