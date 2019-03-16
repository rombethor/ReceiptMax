namespace TestApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReceiptText = new System.Windows.Forms.TextBox();
            this.ImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnImageFile = new System.Windows.Forms.Button();
            this.LblImageFIle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.PrinterCB = new System.Windows.Forms.ComboBox();
            this.PrinterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReceiptText
            // 
            this.ReceiptText.Location = new System.Drawing.Point(12, 123);
            this.ReceiptText.Multiline = true;
            this.ReceiptText.Name = "ReceiptText";
            this.ReceiptText.Size = new System.Drawing.Size(164, 127);
            this.ReceiptText.TabIndex = 0;
            // 
            // ImageFileDialog
            // 
            this.ImageFileDialog.FileName = "openFileDialog1";
            this.ImageFileDialog.Filter = "*.bmp|*.*";
            this.ImageFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImageFileDialog_FileOk);
            // 
            // BtnImageFile
            // 
            this.BtnImageFile.Location = new System.Drawing.Point(12, 68);
            this.BtnImageFile.Name = "BtnImageFile";
            this.BtnImageFile.Size = new System.Drawing.Size(164, 23);
            this.BtnImageFile.TabIndex = 1;
            this.BtnImageFile.Text = "Select Image";
            this.BtnImageFile.UseVisualStyleBackColor = true;
            this.BtnImageFile.Click += new System.EventHandler(this.BtnImageFile_Click);
            // 
            // LblImageFIle
            // 
            this.LblImageFIle.AutoSize = true;
            this.LblImageFIle.Location = new System.Drawing.Point(12, 94);
            this.LblImageFIle.Name = "LblImageFIle";
            this.LblImageFIle.Size = new System.Drawing.Size(52, 13);
            this.LblImageFIle.TabIndex = 2;
            this.LblImageFIle.Text = "No image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text to print:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Receipt Details";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(12, 256);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(164, 23);
            this.BtnPrint.TabIndex = 5;
            this.BtnPrint.Text = "Print!";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // PrinterCB
            // 
            this.PrinterCB.FormattingEnabled = true;
            this.PrinterCB.Location = new System.Drawing.Point(12, 28);
            this.PrinterCB.Name = "PrinterCB";
            this.PrinterCB.Size = new System.Drawing.Size(164, 21);
            this.PrinterCB.TabIndex = 6;
            // 
            // PrinterLbl
            // 
            this.PrinterLbl.AutoSize = true;
            this.PrinterLbl.Location = new System.Drawing.Point(9, 9);
            this.PrinterLbl.Name = "PrinterLbl";
            this.PrinterLbl.Size = new System.Drawing.Size(40, 13);
            this.PrinterLbl.TabIndex = 7;
            this.PrinterLbl.Text = "Printer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 288);
            this.Controls.Add(this.PrinterLbl);
            this.Controls.Add(this.PrinterCB);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblImageFIle);
            this.Controls.Add(this.BtnImageFile);
            this.Controls.Add(this.ReceiptText);
            this.Name = "Form1";
            this.Text = "ReceiptMax Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiptText;
        private System.Windows.Forms.OpenFileDialog ImageFileDialog;
        private System.Windows.Forms.Button BtnImageFile;
        private System.Windows.Forms.Label LblImageFIle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.ComboBox PrinterCB;
        private System.Windows.Forms.Label PrinterLbl;
    }
}

