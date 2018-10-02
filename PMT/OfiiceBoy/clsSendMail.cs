using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;


namespace PMT.OfiiceBoy
{
    public class clsSendMail
    {
        public int isDone { get; set; }
        public string errorMessage { get; set; }

        public void SendMail(string to, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(to);

                mail.From = new MailAddress("propertyintermediator@gmail.com");
                mail.Subject = subject;
                string Body = body;
                mail.Body = Body;

                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                ("propertyintermediator", "@shilpa@123");
                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                isDone = 1;
            }
            catch (Exception ex)
            {
                isDone = 0;
                errorMessage = ex.Message.ToString();
            }
            
        }
    }
}