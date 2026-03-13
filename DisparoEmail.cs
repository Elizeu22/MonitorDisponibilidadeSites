using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using DotNetEnv;


namespace PingIP
{
    public class DisparoEmail
    {

        public void EnviarEmail()
        {
            Env.Load(Path.Combine("../../.env.development"));

            var user = DotNetEnv.Env.GetString("EMAIL_USER");
            var password = DotNetEnv.Env.GetString("EMAIL_PASSWORD");
            var receive = DotNetEnv.Env.GetString("EMAIL_SEND");
            var smtpPorta = DotNetEnv.Env.GetString("SMTP_PORT");

            var email = new MimeMessage();

            email.From.Add(new MailboxAddress("Sistema",user));
            email.To.Add(new MailboxAddress("Destino", receive));

            email.Subject = "Teste envio de email";
            email.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = "Houve uma falha na Comunicação com email"
            };

         

            using (var smtp = new SmtpClient())
            {
                smtp.Connect(smtpPorta, 587, false);
                smtp.Authenticate(user, password);

                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}
