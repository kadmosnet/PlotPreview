using System;
using System.Windows.Forms;
using DXFReaderNET;

namespace PlotPreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dxfReaderNETControl1.NewDrawing();
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "dxf";
            openFileDialog1.Filter = "DXF|*.dxf|All files (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.ReadDXF(openFileDialog1.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            printPreviewControl1.Visible = true;
            dxfReaderNETControl1.Visible = false;
            printPreviewControl1.Location = dxfReaderNETControl1.Location;
            printPreviewControl1.Size = dxfReaderNETControl1.Size;

            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = true;

            dxfReaderNETControl1.PlotMode = PlotModeType.Display;
            dxfReaderNETControl1.PlotRendering = PlotRenderingType.GrayScale;
            dxfReaderNETControl1.PlotRendering = PlotRenderingType.GrayScale;
            dxfReaderNETControl1.PlotRendering = PlotRenderingType.GrayScale;
            dxfReaderNETControl1.PlotOffset = new Vector2(10, 10);
            dxfReaderNETControl1.PlotPreview(printPreviewControl1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Visible = false;
            dxfReaderNETControl1.Visible = true;

            button2.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.Plot(printDialog.PrinterSettings.PrinterName, printDialog.PrinterSettings.Copies);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotOrientation = PlotOrientationType.Landscape;
            dxfReaderNETControl1.PlotRendering = PlotRenderingType.Monochrome;
            dxfReaderNETControl1.PlotMode = PlotModeType.Extents;
            dxfReaderNETControl1.PlotUnits = PlotUnitsType.Millimeters;



            dxfReaderNETControl1.PlotPreview(printPreviewDialog1.PrintPreviewControl);
            printPreviewDialog1.Width = this.Width;
            printPreviewDialog1.Height = this.Height;
            printPreviewDialog1.Text = "Plot preview dialog";
            printPreviewDialog1.StartPosition = FormStartPosition.CenterParent;
            printPreviewDialog1.ShowDialog();



        }
    }
}
