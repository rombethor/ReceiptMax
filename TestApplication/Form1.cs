using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceiptMax;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        TicketPrinter ticketPrinter;
        string ImageFile;

        public Form1()
        {
            InitializeComponent();

            ImageFile = "";
            ticketPrinter = new TicketPrinter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrinterCB.Items.Clear();
            foreach(var tp in ticketPrinter.GetAvailablePrinters())
            {
                PrinterCB.Items.Add(tp);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var ticket = new TestTicket(ImageFileDialog.FileName, ReceiptText.Text);
            ticketPrinter.Print(ticket, PrinterCB.SelectedItem.ToString());
        }

        private void ImageFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            LblImageFIle.Text = ImageFileDialog.FileName;
        }

        private void BtnImageFile_Click(object sender, EventArgs e)
        {
            ImageFileDialog.ShowDialog();
        }
    }
}
