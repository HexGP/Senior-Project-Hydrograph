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

                if ((c < 0) || (c > 1) || (i < 0) || (a < 0) || (v < 0))
                    throw new FormatException();

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
            TpVal.Text = string.Format("{0:0.00000}", tp);
            QpVal.Text = string.Format("{0:0.00000}", qp);

            for (double t = 0; t <= (3 * tp); t += .01)
                Graph.Series["Curve"].Points.AddXY(t, getqi(qp, tp, t));

        }

        private static double getqi(double qp, double tp, double t)
        {
            if (t <= (1.25 * tp))
                return getqiLeft(qp, tp, t);
            else
                return getqiRight(qp, tp, t);
        }

        private static double getqiLeft(double qp, double tp, double t)
        {
            double result = 1 - Math.Cos((Math.PI * t) / tp);
        

            return result * (qp / 2); ;
        }

        private static double getqiRight(double qp, double tp, double t)
        {
            double result = Math.Pow(Math.E, (-1.3 * (t / tp)));
            return result * 4.34 * qp;
        }


        private void SaveImage_Click(object sender, EventArgs e)
        {
            int h = Graph.Size.Height,
                w = Graph.Size.Width;
            if (Graph.Series["Curve"].Points.Count == 0)
            {
                SaveErrorPoppup s = new SaveErrorPoppup();
                s.ShowDialog();
                s.Dispose();
            }
            else
            {
            
                Graph.Visible = false;
                Graph.SetBounds(Graph.Left, Graph.Top, 1920, 1080);
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
            Graph.SetBounds(Graph.Left, Graph.Top, w, h);
            Graph.Visible = true;
        }
    }
}
