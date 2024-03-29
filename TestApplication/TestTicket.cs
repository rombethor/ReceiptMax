﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptMax;

namespace TestApplication
{
    public class TestTicket : TicketDocument
    {
        private string ImageFile;
        private string Message;

        public TestTicket(string img, string text) : base()
        {
            ImageFile = img;
            Message = text;
        }

        protected override PrintPageEventArgs Ticket(object sender)
        {
            WriteCenteredLine("## ReceiptMax Print ##");
            WriteCenteredLine("--- Daniel Thorne ---");
            WriteWrappedLine("This a a test implementation of TicketDocument and should print wrapped on any thermal printer.");
            if(!string.IsNullOrEmpty(ImageFile))
                DrawImage(ImageFile);
            if (!string.IsNullOrEmpty(Message))
                WriteWrappedLine(Message);
            WriteCenteredLine("--== END ==--");
            return base.Ticket(sender);
        }
    }
}
