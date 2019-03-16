using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;

namespace ReceiptMax
{
    public class TicketDocument
    {
        private float Width;
        private float y;
        private float x;

        private Font defaultFont;
        private Brush brush;

        protected PrintPageEventArgs ppea;

        /// <summary>
        ///  Defines the document printing pattern.
        ///  Should be inherited and the function Ticket overwritten
        /// </summary>
        /// <param name="PaperWidth">The paper width in pixels</param>
        public TicketDocument()
        {
            defaultFont = new Font("Consolas", 10);
            brush = new SolidBrush(Color.Black);
        }



        public PrintPageEventHandler PrintPage(float PaperWidth)
        {
            Width = PaperWidth;
            return new PrintPageEventHandler((object obj, PrintPageEventArgs e) => PreprocessTicket(obj, e));
        }

        private PrintPageEventArgs PreprocessTicket(object obj, PrintPageEventArgs e)
        {
            ppea = e;
            return Ticket(obj);
        }

        /// <summary>
        /// Override this function to create a definition of what is on the ticket.
        /// You can use the sender object to pass in extra detail.
        /// Call the base function at the end of the override and most printers will cut the paper.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        protected virtual PrintPageEventArgs Ticket(object sender)
        {
            ppea.HasMorePages = false;
            return ppea;
        }

        public void WriteWrappedLine(string text, Font font = null)
        {
            if (font == null) font = defaultFont;
            float wordheight = 0;

            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                SizeF size = ppea.Graphics.MeasureString(word + " ", font);
                bool newline = false;
                if (x + size.Width > Width && !newline)
                {
                    x = 0;
                    y += size.Height + 1;
                    newline = true; //Stopping ridiculously sized words
                }
                ppea.Graphics.DrawString(word + " ", font, brush, new PointF(x, y));
                x += size.Width;
                wordheight = size.Height;
            }
            y += wordheight;
            x = 0;
        }

        public void WriteCenteredLine(string text, Font font = null)
        {
            //
            if (font == null) font = defaultFont;

            x = 0;
            var szf = ppea.Graphics.MeasureString(text, font);
            x = (Width - szf.Width) / 2;
            ppea.Graphics.DrawString(text, font, brush, new PointF(x, y));
            x = 0;
            y += szf.Height;
        }

        public Font ShrinkFontToFitPage(string text, Font font = null)
        {
            Font retFont = new Font(font, font.Style); //Copy font.  Don't overwrite

            float textWidth;
            do
            {
                var szf = ppea.Graphics.MeasureString(text, retFont);
                textWidth = szf.Width;
                if (textWidth > Width)
                    retFont = new Font(retFont.FontFamily, retFont.Size - 1, retFont.Style);
            }
            while (retFont.Size > 1 && textWidth > Width);

            return retFont;
        }

        public void DrawImage(string Filepath)
        {
//            var path = System.IO.Path.Combine(Environment.CurrentDirectory, Filename);
            using (var src = new Bitmap(Filepath, true))
            {
                x = (Width - src.Width) / 2;
                x = 0; //tests
                ppea.Graphics.DrawImage(src, new PointF(x, y));
                x = 0;
                y += src.Height;
            }
        }
    }
}
