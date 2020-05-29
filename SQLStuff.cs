using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smtp_client
{
    class SQLStuff
    {
        public SQLDataClassesDataContext ctx;
        
        public SQLStuff()
        {
            ctx = new SQLDataClassesDataContext();

        }
    }
}


/******************
 * 
 * 
 * CREATE TABLE [dbo].[smtp_mail_batch](
	[ID] [int] NOT NULL,
	[smtp_server_host] [varchar](1024) NULL,
	[smtp_port] [int] NULL,
	[smtp_user] [varchar](1024) NULL,
	[smtp_password] [varchar](1024) NULL,
	[description] [varchar](1024) NULL,
 CONSTRAINT [PK_smtp_mail_batch] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
 */

/**********
* 
*
* CREATE TABLE [dbo].[smtp_mail_batch_details](
   [mail_id] [varchar](50) NULL,
   [smtp_batch_ID] [int] NOT NULL,
   [mime_sender] [varchar](1024) NULL,
   [mime_sender_name] [varchar](1024) NULL,
   [mime_from_list] [varchar](1024) NULL,
   [mime_from_name_list] [varchar](1024) NULL,
   [mime_to_list] [varchar](1024) NULL,
   [mime_to_name_list] [varchar](1024) NULL,
   [mime_cc_list] [varchar](1024) NULL,
   [mime_bcc_list] [varchar](1024) NULL,
   [mime_attachment_list] [varchar](1024) NULL,
   [mime_textpart] [varchar](2048) NULL,
   [mime_htmlpart] [varchar](2048) NULL,
   [mime_subject] [varchar](1024) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[smtp_mail_batch_details]  WITH CHECK ADD  CONSTRAINT [FK_smtp_mail_batch_details_smtp_mail_batch] FOREIGN KEY([smtp_batch_ID])
REFERENCES [dbo].[smtp_mail_batch] ([ID])
GO

ALTER TABLE [dbo].[smtp_mail_batch_details] CHECK CONSTRAINT [FK_smtp_mail_batch_details_smtp_mail_batch]
GO
*
* 
* 
**************/
