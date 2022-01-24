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
        private double[] preGraph = new double[6];
        private double[] postGraph = new double[6];
        private Options currentGraphType;
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateDialogue_ButtonClicked(object sender, OptionSelectEvent e)
        {
            currentGraphType = e.getChoice();
        }

        private void GenerateGraph_Click(object sender, EventArgs e)
        {
            double tp, qp, c, i, a, v = c = i = a = 1;

            GenerateDialogue diag = new GenerateDialogue();
            diag.optionSelected += new GenerateDialogue.OptionSelectHandler(GenerateDialogue_ButtonClicked);
            diag.ShowDialog();
            
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

            qp = c * i * a;
            tp = v / (1.39 * qp);
            TpVal.Text = string.Format("{0:0.00000}", tp);
            QpVal.Text = string.Format("{0:0.00000}", qp);

            if (currentGraphType == Options.PRE_DEVELOPED)
            {
                Graph.Series["Curve"].Enabled = false;
                Graph.Series["Pre"].Enabled = true;
                Graph.Legends["Legend1"].Enabled = true;
                Graph.Series["Pre"].Points.Clear();

                preGraph[0] = c;
                preGraph[1] = i;
                preGraph[2] = a;
                preGraph[3] = v;
                preGraph[4] = tp;
                preGraph[5] = qp;

                PreDev.Visible = true;

                for (double t = 0; t <= (3 * tp); t += .01)
                    Graph.Series["Pre"].Points.AddXY(t, getqi(qp, tp, t));

            }
            else if (currentGraphType == Options.POST_DEVELOPED)
            {
                Graph.Series["Curve"].Enabled = false;
                Graph.Series["Post"].Enabled = true;
                Graph.Legends["Legend1"].Enabled = true;
                Graph.Series["Post"].Points.Clear();

                postGraph[0] = c;
                postGraph[1] = i;
                postGraph[2] = a;
                postGraph[3] = v;
                postGraph[4] = tp;
                postGraph[5] = qp;

                PostDev.Visible = true;

                for (double t = 0; t <= (3 * tp); t += .01)
                    Graph.Series["Post"].Points.AddXY(t, getqi(qp, tp, t));
            }
            else if (currentGraphType == Options.INDIVIDUAL)
            {
                Graph.Series["Curve"].Enabled = true;
                Graph.Series["Pre"].Enabled = false;
                Graph.Series["Post"].Enabled = false;
                Graph.Legends["Legend1"].Enabled = false;
                Graph.Series["Curve"].Points.Clear();

                PostDev.Visible = false;
                PreDev.Visible = false;

                for (double t = 0; t <= (3 * tp); t += .01)
                    Graph.Series["Curve"].Points.AddXY(t, getqi(qp, tp, t));
            }
            /*
            if(Graph.Series["Pre"].Enabled && Graph.Series["Post"].Enabled)
            {
                if((3 * preGraph[4]) > (3*postGraph[4]))
                {

                }
            }*/

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
            if (!Graph.Series["Curve"].Enabled && (!Graph.Series["Pre"].Enabled || !Graph.Series["Post"].Enabled))
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

        private void PreDev_Click(object sender, EventArgs e)
        {

            CVal.Text = string.Format("{0:0.00000}", preGraph[0]);
            iVal.Text = string.Format("{0:0.00000}", preGraph[1]);
            aVal.Text = string.Format("{0:0.00000}", preGraph[2]);
            VVal.Text = string.Format("{0:0.00000}", preGraph[3]);
            TpVal.Text = string.Format("{0:0.00000}", preGraph[4]);
            QpVal.Text = string.Format("{0:0.00000}", preGraph[5]);

        }

        private void PostDev_Click(object sender, EventArgs e)
        {
            CVal.Text = string.Format("{0:0.00000}", postGraph[0]);
            iVal.Text = string.Format("{0:0.00000}", postGraph[1]);
            aVal.Text = string.Format("{0:0.00000}", postGraph[2]);
            VVal.Text = string.Format("{0:0.00000}", postGraph[3]);
            TpVal.Text = string.Format("{0:0.00000}", postGraph[4]);
            QpVal.Text = string.Format("{0:0.00000}", postGraph[5]);
        }
    }
}
