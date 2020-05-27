using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using System.IO;

namespace smtp_client
{
    public class SmtpMessage
    {
        public MimeKit.MimeMessage mimeMessage = new MimeKit.MimeMessage();
        private string mailpartsFolder = @"C:\source_files\smtp_client\mailparts";

        public TextPart CreateHtmlPart()
        {
            string part = File.ReadAllText(mailpartsFolder + "\\html_part.txt");
            if (!string.IsNullOrEmpty(part))
            {
                var hp = new TextPart("HTML")
                {
                    Text = part
                };
                return hp;
            }
            return new TextPart();
        }

        public TextPart CreateTextPart()
        {
            string part = File.ReadAllText(mailpartsFolder + "\\text_part.txt");
            if (!string.IsNullOrEmpty(part))
            {
                var tp = new TextPart("Plain") {
                    Text = part
                };
                    
                return tp;
            }
            return new TextPart();
        }

        public MimePart CreateAttachment(string attachmentPath)
        {
            var attachment = new MimePart("application", "pdf")
            {
                Content = new MimeContent(File.OpenRead(attachmentPath), ContentEncoding.Default),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(attachmentPath)
            };
            return attachment;
        }

        public void CreateMessage()
        {
            var textpart = CreateTextPart();
            var htmlpart = CreateHtmlPart();
            var attachment = CreateAttachment(@"C:\source_files\smtp_client\mailparts\annotate.pdf");
                //@"F:\source_files\smtp_client\Invoice#IN19103288.pdf");

            var alternative = new MultipartAlternative();
            alternative.Add(textpart);
            alternative.Add(htmlpart);

            var multipart = new Multipart("mixed");
            multipart.Add(alternative);
            multipart.Add(attachment);

            mimeMessage.Body = multipart;
        }
    }
}
