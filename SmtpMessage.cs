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
        private string mailpartsFolder = Settings.Default.MailpartsFolderPath;
        //@"\source_files\smtp_client\mailparts";

        public TextPart CreateHtmlPart(string filePath)
        {
            string part = File.ReadAllText(filePath.ToString());
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

        public TextPart CreateTextPart(string filePath)
        {
            string part = File.ReadAllText(filePath.ToString());
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

        public void CreateMessage(string textpart, string htmlpart, string attachments)
        {
            var _textpart = CreateTextPart(textpart);
            var _htmlpart = CreateHtmlPart(htmlpart);
            //var attachment = CreateAttachment(mailpartsFolder + "\\annotate.pdf");
            var attachment = CreateAttachment(attachments);

            var alternative = new MultipartAlternative();
            alternative.Add(_textpart);
            alternative.Add(_htmlpart);

            var multipart = new Multipart("mixed");
            multipart.Add(alternative);
            multipart.Add(attachment);

            mimeMessage.Body = multipart;
        }
    }
}
