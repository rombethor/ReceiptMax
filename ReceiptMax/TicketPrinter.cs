using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Printing;
using System.Threading.Tasks;
using System.Drawing.Printing;

namespace ReceiptMax
{
    public class TicketPrinter
    {
        private PrintDocument pd;
        private TicketDocument td;
        private LocalPrintServer printServer;

        float PaperWidth;

        public TicketPrinter()
        {
            printServer = new LocalPrintServer();
        }

        public TicketPrinter(TicketDocument td, string PrinterName = null)
        {
            printServer = new LocalPrintServer();
            pd = new PrintDocument();
            if (PrinterName != null) SetPrinter(PrinterName);
            pd.PrintPage += td.PrintPage(PaperWidth);
        }

        public IEnumerable<string> GetAvailablePrinters()
        {
            var printerFilters = new EnumeratedPrintQueueTypes[] { EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Shared };
            return printServer.GetPrintQueues().Select(pq => pq.FullName);
        }

        public void SetPrinter(string printer)
        {
            pd.PrinterSettings.PrinterName = printer;
            pd.DefaultPageSettings.Landscape = false;
            PaperWidth = pd.DefaultPageSettings.PaperSize.Width; // * pd.DefaultPageSettings.PrinterResolution.X;
        }

        public void Print(TicketDocument td, string PrinterName = null)
        {
            pd = new PrintDocument();
            if (PrinterName != null)
                SetPrinter(PrinterName);
            else
                if (string.IsNullOrEmpty(pd.PrinterSettings.PrinterName)) throw new Exception("No printer has been set!");
            pd.PrintPage += td.PrintPage(PaperWidth);
            pd.Print();
        }

        public void Print()
        {
            pd.Print();
        }

    }
}
