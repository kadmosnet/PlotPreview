namespace PlotPreview
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
            DXFReaderNET.DxfDocument dxfDocument2 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor2 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables2 = new DXFReaderNET.Objects.RasterVariables();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            dxfDocument2.ActiveLayout = "Model";
            dxfDocument2.Comments = null;
            aciColor2.Index = ((short)(256));
            aciColor2.IsByBlock = false;
            aciColor2.IsByLayer = true;
            aciColor2.UseTrueColor = false;
            dxfDocument2.CurrentColor = aciColor2;
            dxfDocument2.CurrentElevation = 0D;
            dxfDocument2.CurrentLayer = "0";
            dxfDocument2.CurrentLineTypeName = "ByLayer";
            dxfDocument2.CurrentLineTypeScale = 1D;
            dxfDocument2.CurrentTextSize = 2.5D;
            dxfDocument2.CurrentTextStyle = "STANDARD";
            dxfDocument2.CurrentThickness = 0D;
            dxfDocument2.DateCreated = new System.DateTime(2020, 1, 31, 13, 17, 29, 352);
            dxfDocument2.DateLastEdited = new System.DateTime(2020, 1, 31, 13, 17, 29, 352);
            dxfDocument2.Handle = "0";
            dxfDocument2.IsBinary = false;
            dxfDocument2.Modified = false;
            dxfDocument2.Name = null;
            dxfDocument2.Owner = null;
            rasterVariables2.DisplayFrame = true;
            rasterVariables2.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables2.Handle = "2D";
            rasterVariables2.Owner = null;
            rasterVariables2.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument2.RasterVariables = rasterVariables2;
            dxfDocument2.ThumbnailImage = null;
            dxfDocument2.TotalEditTime = new System.DateTime(2020, 1, 31, 0, 0, 0, 0);
            dxfDocument2.TotalEditTimeDays = 0;
            dxfDocument2.UserTimer = new System.DateTime(2020, 1, 31, 0, 0, 0, 0);
            dxfDocument2.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument2;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(12, 31);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.PlotMode = DXFReaderNET.PlotModeType.Display;
            this.dxfReaderNETControl1.ShowGrid = true;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(816, 488);
            this.dxfReaderNETControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load DXF file...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Plot preview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(386, 189);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(274, 216);
            this.printPreviewControl1.TabIndex = 3;
            this.printPreviewControl1.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(246, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = "Plot preview close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 21);
            this.button4.TabIndex = 5;
            this.button4.Text = "Plot";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(507, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 21);
            this.button5.TabIndex = 6;
            this.button5.Text = "Plot preview dialog";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 534);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DXFReader.NET - Plot Preview Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

