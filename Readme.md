📡 Monitor de Disponibilidade de Sites / Serviços de Email
 
📌 Descrição

      Este projeto consiste em uma automação para monitoramento de 
      disponibilidade que verifica periodicamente se um endereço
      eletrônico (site ou serviço de e-mail) está online.
      
      Caso o sistema detecte que o endereço monitorado está offline
      ou inacessível, a aplicação dispara automaticamente um e-mail
      de notificação, permitindo resposta rápida ao problema.

   Esse tipo de automação é útil para:
      Monitoramento de sites corporativos
      Monitoramento de servidores de e-mail
      Monitoramento de APIs e serviços web
      Alertas de indisponibilidade para equipes de suporte

⚙️ Funcionamento

     O sistema executa os seguintes passos:
     Realiza verificações periódicas em um endereço eletrônico (URL ou host).

   Detecta se o serviço está:
   
    ✅ Online 
    ❌ Offline

   Caso o serviço esteja offline, o sistema:
   
    registra o evento
    envia automaticamente um e-mail de alerta

   Fluxo simplificado:
   
     Monitoramento → Verificação de disponibilidade → Detecção de falha → Envio de e-mail

     
   🚀 Tecnologias utilizadas
   
      Exemplo de stack utilizada:
        .NET
        .SMTP para envio de e-mails(Mailkit)
        .Logs de execução(Serilog)
        .Monitoramento via Ping ou requisição HTTP


   Logs de execução
   
    Monitoramento via Ping ou requisição HTTP
