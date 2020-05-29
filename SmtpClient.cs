using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smtp_client
{
    public class SmtpClient
    {
        public EmailConfguration emailConfiguration;
        public EmailClientService emailClient;
        public SmtpClient(string host, int port, string user, string password)
        {
            emailConfiguration = new EmailConfguration();
            //emailConfiguration.AddSMTP("192.168.200.12", 25, "Anonymous", "haakon.langballe@abgsc.no");
            //emailConfiguration.AddSMTP("localhost", 25, "Anonymous", "haakon.langballe@abgsc.no");
            emailConfiguration.AddSMTP(host, port, user, password);
            emailClient = new EmailClientService(emailConfiguration);

        }
    }
}
