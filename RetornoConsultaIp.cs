using System.Net.NetworkInformation;
using Microsoft.Extensions.Logging;
using Serilog;



namespace PingIP
{
    public class RetornoConsultaIp
    {
        public void ConultarPing()
        {
            RegistroLogs registroLogs = new RegistroLogs();

            string url = "xxxxxxxxxxxxxxxx";
            Ping consultarIP = new Ping();
            PingReply pingReply = consultarIP.Send(url);

            try
            {
                if (pingReply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Endereco {0}", pingReply.Address.ToString());
                    Console.WriteLine("Tempo resposta {0} segundos", pingReply.RoundtripTime);
                    Console.WriteLine("Tamanho buffer {0}", pingReply.Buffer.Length);

                    registroLogs.Registros(url);

                }


                else
                {
                    Console.WriteLine("Status{0}", pingReply.Status);

                    registroLogs.RegistrosErrosLogs(url);

                    DisparoEmail disparoEmail = new DisparoEmail();
                    disparoEmail.EnviarEmail();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Erro{0}", ex);
                registroLogs.RegistrosErrosLogs(url);
            }


        }
    }
}
