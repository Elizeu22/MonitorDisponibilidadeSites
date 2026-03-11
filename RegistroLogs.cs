using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingIP
{
    public class RegistroLogs
    {

        public void Registros(string url)
        {
            Log.Logger = new LoggerConfiguration()
              .MinimumLevel.Debug()
              .WriteTo.File(
                "logs/logs.txt",
                 rollingInterval: RollingInterval.Day,
                 outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
              .CreateLogger();

            Log.Information($"processado com sucesso: {url} " + DateTime.Now);

            Log.CloseAndFlush();
        }

        public void RegistrosErrosLogs(string url)
        {
            Log.Logger = new LoggerConfiguration()
              .MinimumLevel.Debug()
              .WriteTo.File(
                "logs/logsErros.txt",
                 rollingInterval: RollingInterval.Day,
                 outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
              .CreateLogger();

            Log.Information($"processado com sucesso: {url} " + DateTime.Now);

            Log.CloseAndFlush();
        }
    }
}

