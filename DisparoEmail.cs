using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace PingIP
{
    public class DisparoEmail
    {

        public void EnviarEmail()
        {
            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("xxxxx", "xxxxx"));
            email.To.Add(new MailboxAddress("xxxxx", "xxxxxx"));

            email.Subject = "Teste envio de email";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = "houve uma falha na Comunicação com email"
            };

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("xxxx", 000, false);
                smtp.Authenticate("xxxxx", "xxxxxxx");

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}
