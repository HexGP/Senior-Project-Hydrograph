using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xSquaredTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuadraticGenerator_Click(object sender, EventArgs e)
        {
            Graph.Series["curve"].Points.Clear();
            double a = 1, b = 0, c = 0;

            try
            {
                a = Double.Parse(aVal.Text);
                b = Double.Parse(bVal.Text);
                c = Double.Parse(cVal.Text);
            }
            catch (FormatException)
            {
                Popup pop = new Popup();
                pop.ShowDialog();
                pop.Dispose();
                return;
            }

            for (double i = 0; i <= 10; i += 1)
            {
                Graph.Series["curve"].Points.AddXY(i, getQuadY(i, a, b, c));
            }
            Graph.Series["curve"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }

        static double getQuadY(double x, double a, double b, double c)
        {
            return (a * x * x) + (b * x) + c;
        }

        static double getLineY(double x, double m, double b)
        {
            return (m*x) + b;
        }

        private void LineGenerator_Click(object sender, EventArgs e)
        {
            Graph.Series["curve"].Points.Clear();
            double m = 1, b = 0;
            try
            {
                m = Double.Parse(slope.Text);
                b = Double.Parse(yIntercept.Text);
            }
            catch(FormatException)
            {
                Popup pop = new Popup();
                pop.ShowDialog();
                pop.Dispose();
                return;
            }
            for (double i = 0; i <= 10; i += 1)
            {
                Graph.Series["curve"].Points.AddXY(i, getLineY(i, m, b));
            }
            Graph.Series["curve"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }

        private void SaveGraph_Click(object sender, EventArgs e)
        {
            if (Graph.Series["curve"].Points.Count == 0)
            {
                SaveError s = new SaveError();
                s.ShowDialog();
                s.Dispose();
            }
            else
            {                 
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "JPeg Image|*.jpg|PNG Image|*.png";
                saveFile.Title = "Save The Graph";
                saveFile.ShowDialog();
                if (saveFile.FileName != "")
                {
                    System.IO.FileStream file = (System.IO.FileStream)saveFile.OpenFile();

                    switch (saveFile.FilterIndex)
                    {
                        case 1:
                            Graph.SaveImage(file,
                              new System.Windows.Forms.DataVisualization.Charting.ChartImageFormat());
                            break;

                        case 2:
                            Graph.SaveImage(file, new System.Windows.Forms.DataVisualization.Charting.ChartImageFormat());
                            break;
                    }

                    file.Close();
                }
            }
        }
    }
}
