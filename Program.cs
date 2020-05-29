﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 

Server
	Server/host
	Port

Mime Headers
	Sender
	To
	From
	Subject


Mailparts
	Textpart
	Htmlpart
	Attachments
*/

namespace smtp_client
{
    class Program
    {

        static void Main(string[] args)
        {

            //EmailMessage msg = new EmailMessage();
            //msg.ToAddresses.Add(new EmailAddress() { Name = "haakon", Address = "haakonstilbud@gmail.com" });
            //msg.FromAddresses.Add(new EmailAddress() { Name = "haakon", Address = "haakon.langballe@abgsc.no" });
            //msg.Subject = "Demo message";

            SQLStuff sql = new SQLStuff();

            var batch = sql.ctx.smtp_mail_batches.First(b => b.ID == 1);


            var clientService = new SmtpClient(batch.smtp_server_host, batch.smtp_port.GetValueOrDefault(25), batch.smtp_user, batch.smtp_password);

            clientService.emailClient.Connect();
            if (clientService.emailClient.IsConnected() == false)
            {
                Console.WriteLine("Client is not connected");
                return;
            }

            clientService.emailClient.Authenticate();
            if (clientService.emailClient.IsAuthenticated() == false)
            {
                Console.WriteLine("Client is not authenticated");
                clientService.emailClient.Disconnect();
                return;
            }

            var emails = sql.ctx.smtp_mail_batch_details.Where(b => b.smtp_batch_ID == batch.ID);

            foreach(var email in emails)
            {
                var message = new SmtpMessage();
                message.CreateMessage(email.mime_textpart, email.mime_htmlpart, email.mime_attachment_list); //create MimeMessage
                message.mimeMessage.Sender = new MimeKit.MailboxAddress(email.mime_sender_name, email.mime_sender);
                message.mimeMessage.To.Add(new MimeKit.MailboxAddress(email.mime_to_name_list, email.mime_to_list));
                message.mimeMessage.From.Add(new MimeKit.MailboxAddress(email.mime_from_name_list, email.mime_from_list));
                message.mimeMessage.Subject = email.mime_subject;

                //message.mimeMessage.Sender = new MimeKit.MailboxAddress("haakon", "haakonstilbud@gmail.com");
                //message.mimeMessage.To.Add(new MimeKit.MailboxAddress("haakon", "haakonstilbud@gmail.com"));
                //message.mimeMessage.From.Add(new MimeKit.MailboxAddress("haakon", "haakon.langballe@abgsc.no"));
                //message.mimeMessage.Subject = "Demo mail nr: " + ix;

                clientService.emailClient.Send(message);
            }
            clientService.emailClient.Disconnect();
        }
    }
}
