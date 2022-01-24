using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydrograph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateGraph_Click(object sender, EventArgs e)
        {
            double tp, qp, c, i, a, v = c = i = a = 1;

            try 
            {
                c = Double.Parse(CVal.Text);
                i = Double.Parse(iVal.Text);
                a = Double.Parse(aVal.Text);
                v = Double.Parse(VVal.Text);
            }
            catch(FormatException)
            {
                InputErrorPoppup pop = new InputErrorPoppup();
                pop.ShowDialog();
                pop.Dispose();
                return;
            }

            Graph.Series["Curve"].Points.Clear();

            qp = c * i * a;
            tp = v / (1.39 * qp);

            for (double t = 0; t <= (1.25 * tp); t += .01)
                Graph.Series["Curve"].Points.AddXY(t, getqi1(qp, tp, t));

            for (double t = (1.25 * tp) + .01; t < (5 * tp); t += .01)
                Graph.Series["Curve"].Points.AddXY(t, getqi2(qp, tp, t));

            Graph.Series["Curve"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

        }

        private static double getqi1(double qp, double tp, double t)
        {
            double result = 1 - Math.Cos((Math.PI * t) / tp);
        

            return result * (qp / 2); ;
        }

        private static double getqi2(double qp, double tp, double t)
        {
            double result = Math.Pow(Math.E, (-1.3 * (t / tp)));
            return result * 4.34 * qp;
        }


        private void SaveImage_Click(object sender, EventArgs e)
        {

            if (Graph.Series["Curve"].Points.Count == 0)
            {
                SaveErrorPoppup s = new SaveErrorPoppup();
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
