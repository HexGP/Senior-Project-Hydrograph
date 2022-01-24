using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

using System.Windows.Forms;

namespace Hydrograph
{
    public partial class Form1 : Form
    {
        private double[] preGraph = new double[6];
        private double[] postGraph = new double[6];
        private double[] indivGraph = new double[6];
        private const string FORMAT = "{0:000.00000}";
        private Options currentGraphType;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeft,
               int nTop,
               int nRight,
               int nBottom,
               int nWidthEllipse,
               int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();

            GenerateGraph.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, GenerateGraph.Width, GenerateGraph.Height, 30, 30));
            CVal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CVal.Width, CVal.Height, 20, 20));
            iVal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, iVal.Width, iVal.Height, 20, 20));
            aVal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, aVal.Width, aVal.Height, 20, 20));
            VVal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, VVal.Width, VVal.Height, 20, 20));
            TpVal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TpVal.Width, TpVal.Height, 20, 20));
            QpVal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, QpVal.Width, QpVal.Height, 20, 20));
            SaveImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SaveImage.Width, SaveImage.Height, 20, 20));
            PreDev.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PreDev.Width, PreDev.Height, 20, 20));
            PostDev.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PostDev.Width, PostDev.Height, 20, 20));
            LoadButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoadButton.Width, LoadButton.Height, 20, 20));
            abcVal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, abcVal.Width, abcVal.Height, 20, 20));
            // Create a reference to the OS version of Windows 10 Creators Update.
            Version OsMinVersion = new Version(10, 0, 15063, 0);

            // Access the platform/version of the current OS.
            Console.WriteLine(Environment.OSVersion.Platform.ToString());
            Console.WriteLine(Environment.OSVersion.VersionString);

            // Compare the current version to the minimum required version.
            Console.WriteLine(Environment.OSVersion.Version.CompareTo(OsMinVersion));
        }

        private void GenerateDialogue_ButtonClicked(object sender, OptionSelectEvent e)
        {
            currentGraphType = e.getChoice();
        }

        private void GenerateGraph_Click(object sender, EventArgs e)
        {
            double tp, qp, c, i, a, qi, t = 0, v = c = i = a = 1;

            try
            {
                c = Double.Parse(CVal.Text);
                i = Double.Parse(iVal.Text);
                a = Double.Parse(aVal.Text);
                v = Double.Parse(VVal.Text);

                if ((c < 0) || (c > 1) || (i < 0) || (a < 0) || (v < 0))
                    throw new FormatException();

            }
            catch (FormatException)
            {
                InputErrorPoppup pop = new InputErrorPoppup();
                pop.ShowDialog();
                pop.Dispose();
                return;
            }
            SaveImage.Visible = false;
            currentGraphType = Options.NULL;
            GenerateDialogue diag = new GenerateDialogue();
            diag.optionSelected += new GenerateDialogue.OptionSelectHandler(GenerateDialogue_ButtonClicked);
            diag.ShowDialog();

            qp = c * i * a;
            tp = v / (1.39 * qp);
            TpVal.Text = string.Format(FORMAT, tp);
            QpVal.Text = string.Format(FORMAT, qp);

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

                generateGraph("Pre", tp, qp);

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

                generateGraph("Post", tp, qp);
            }
            else if (currentGraphType == Options.INDIVIDUAL)
            {
                Graph.Series["Curve"].Enabled = true;
                Graph.Series["Pre"].Enabled = false;
                Graph.Series["Post"].Enabled = false;
                Graph.Legends["Legend1"].Enabled = false;
                abcVal.Visible = false;
                abcLabel.Visible = false;
                Graph.Series["Curve"].Points.Clear();

                indivGraph[0] = c;
                indivGraph[1] = i;
                indivGraph[2] = a;
                indivGraph[3] = v;
                indivGraph[4] = tp;
                indivGraph[5] = qp;

                PostDev.Visible = false;
                PreDev.Visible = false;

                generateGraph("Curve", tp, qp);
                SaveImage.Visible = true;
            }

            if (Graph.Series["Pre"].Enabled && Graph.Series["Post"].Enabled)
            {
                SaveImage.Visible = true;
                abcVal.Visible = true;
                abcLabel.Visible = true;
                fillVol();



            }

        }

        private void generateGraph(string curve, double tp, double qp)
        {
            double t = 0;
            double qi;
            do
            {
                t += 1;
                qi = getqi(qp, tp, t);
                Graph.Series[curve].Points.AddXY(t, qi);
            } while ((qi > .1) || (t < tp));
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

        private static double getArea(double qp, double tp, double to, double ti)
        {
            double changePt = 1.25 * tp;
            if ((to < changePt) && (ti <= changePt))
                return getAreaLeft(qp, tp, to, ti);
            else if ((to < changePt) && (ti > changePt) && (ti != double.MaxValue))
                return getAreaLeft(qp, tp, to, changePt) + getAreaRight(qp, tp, ti);
            else if((to < changePt) && (ti > changePt) && (ti == double.MaxValue))
                return getAreaLeft(qp, tp, to, changePt) + getAreaExtremeRight(qp, tp, changePt);
            else if (to == changePt)
                return getAreaRight(qp, tp, ti);
            else if (ti != Double.MaxValue)
                return getAreaFarRight(qp, tp, to, ti);
            else
                return getAreaExtremeRight(qp, tp, to);

        }

        private static double getAreaLeft(double qp, double tp, double to, double ti)
        {
            double result1 = to - ((tp / Math.PI) * Math.Sin((Math.PI * to) / tp));
            double result2 = ti - ((tp / Math.PI) * Math.Sin((Math.PI * ti) / tp));
            return (qp / 2) * (result2 - result1);

        }

        private static double getAreaRight(double qp, double tp, double t)
        {
            double result = Math.Pow(Math.E, ((-1.3 * t) / tp)) - Math.Pow(Math.E, -1.625);
            return result * ((4.34 * qp * tp) / -1.3);
        }

        private static double getAreaFarRight(double qp, double tp, double to, double ti)
        {
            double result = Math.Pow(Math.E, ((-1.3 * ti) / tp)) - Math.Pow(Math.E, ((-1.3 * to) / tp));
            return result * ((4.34 * qp * tp) / -1.3);
        }

        private static double getAreaExtremeRight(double qp, double tp, double t)
        {
            double result = Math.Pow(Math.E, ((-1.3 * t) / tp));
            return result * ((4.34 * qp * tp) / 1.3);
        }

        private static double getIntersection(double set1_x1, double set1_y1, double set1_x2, double set1_y2, double set2_x1, double set2_y1, double set2_x2, double set2_y2) //Single Call For Retrieving Intersection X Value
        {
            double set1_slope = getSlope(set1_x1, set1_y1, set1_x2, set1_y2);
            double set2_slope = getSlope(set2_x1, set2_y1, set2_x2, set2_y2);
            return getPoint(set1_slope, getY_Intercept(set1_slope, set1_x1, set1_y1), set2_slope, getY_Intercept(set2_slope, set2_x1, set2_y1));
        }

        private static double getSlope(double x1, double y1, double x2, double y2) //Slope Calculation Dy/Dx
        {
            return (y2 - y1) / (x2 - x1);
        }

        public static double getY_Intercept(double slope, double x, double y) //Y-Intercept Calculation
        {
            return y - (slope * x);
        }

        public static double getPoint(double set1_slope, double set1_y_intercept, double set2_slope, double set2_y_intercept) //Point of Intersection Calculation Using Elimination
        {
            return (set2_y_intercept + (-1 * set1_y_intercept)) / (set1_slope + (-1 * set2_slope));
        }

        private void fillVol() //Fills Area Between Curves Section
        {
            double x = -1;
            double vol = 0;
            for (int index = 1; index < Math.Min(Graph.Series["Pre"].Points.Count, Graph.Series["Post"].Points.Count); index++)
            {
                if (Graph.Series["Pre"].Points[index].YValues[0] == Graph.Series["Post"].Points[index].YValues[0])
                {
                    x = Graph.Series["Pre"].Points[index].XValue;

                    if (Graph.Series["Pre"].Points[index - 1].YValues[0] < Graph.Series["Post"].Points[index - 1].YValues[0])
                        vol = getArea(preGraph[5], preGraph[4], 0, x) + getArea(postGraph[5], postGraph[4], x, double.MaxValue);
                    else
                        vol = getArea(postGraph[5], postGraph[4], 0, x) + getArea(preGraph[5], preGraph[4], x, double.MaxValue);

                }
                else if ((Graph.Series["Pre"].Points[index - 1].YValues[0] > Graph.Series["Post"].Points[index - 1].YValues[0]) && (Graph.Series["Pre"].Points[index].YValues[0] < Graph.Series["Post"].Points[index].YValues[0]))
                {
                    x = getIntersection(Graph.Series["Pre"].Points[index-1].XValue, Graph.Series["Pre"].Points[index - 1].YValues[0], Graph.Series["Pre"].Points[index].XValue, Graph.Series["Pre"].Points[index].YValues[0], Graph.Series["Post"].Points[index - 1].XValue, Graph.Series["Post"].Points[index - 1].YValues[0], Graph.Series["Post"].Points[index].XValue, Graph.Series["Post"].Points[index].YValues[0]);
                    vol = getArea(postGraph[5], postGraph[4], 0, x) + getArea(preGraph[5], preGraph[4], x, double.MaxValue);

                }
                else if ((Graph.Series["Pre"].Points[index - 1].YValues[0] < Graph.Series["Post"].Points[index - 1].YValues[0]) && (Graph.Series["Pre"].Points[index].YValues[0] < Graph.Series["Post"].Points[index].YValues[0]))
                {
                    x = getIntersection(Graph.Series["Pre"].Points[index - 1].XValue, Graph.Series["Pre"].Points[index - 1].YValues[0], Graph.Series["Pre"].Points[index].XValue, Graph.Series["Pre"].Points[index].YValues[0], Graph.Series["Post"].Points[index - 1].XValue, Graph.Series["Post"].Points[index - 1].YValues[0], Graph.Series["Post"].Points[index].XValue, Graph.Series["Post"].Points[index].YValues[0]);
                    vol = getArea(preGraph[5], preGraph[4], 0, x) + getArea(postGraph[5], postGraph[4], x, double.MaxValue);
                }
            }

            abcVal.Text = string.Format(FORMAT, vol);
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
                saveFile.Filter = "JPeg Image (*.jpg)|*.jpg|PNG Image (*.png)|*.png|XML File (*.xml)|*.xml";
                saveFile.Title = "Save The Graph";
                saveFile.ShowDialog();
                if (saveFile.FileName != "")
                {
                    System.IO.FileStream file = (System.IO.FileStream)saveFile.OpenFile();

                    switch (saveFile.FilterIndex)
                    {
                        case 1:
                        case 2:
                            Graph.SaveImage(file, new System.Windows.Forms.DataVisualization.Charting.ChartImageFormat());
                            break;
                        case 3:
                            Graph.SetBounds(Graph.Left, Graph.Top, w, h);
                            Graph.Visible = true;
                            GraphSaver sv = new GraphSaver();
                            if (Graph.Series["Curve"].Enabled)
                                sv = new GraphSaver(indivGraph);
                            else
                                sv = new GraphSaver(preGraph, postGraph);

                            try
                            {
                                XmlSerializer format = new XmlSerializer(sv.GetType());
                                format.Serialize(file, sv);
                               
                            }
                            catch(Exception)
                            {

                            }
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

            CVal.Text = string.Format(FORMAT, preGraph[0]);
            iVal.Text = string.Format(FORMAT, preGraph[1]);
            aVal.Text = string.Format(FORMAT, preGraph[2]);
            VVal.Text = string.Format(FORMAT, preGraph[3]);
            TpVal.Text = string.Format(FORMAT, preGraph[4]);
            QpVal.Text = string.Format(FORMAT, preGraph[5]);

        }

        private void PostDev_Click(object sender, EventArgs e)
        {
            CVal.Text = string.Format(FORMAT, postGraph[0]);
            iVal.Text = string.Format(FORMAT, postGraph[1]);
            aVal.Text = string.Format(FORMAT, postGraph[2]);
            VVal.Text = string.Format(FORMAT, postGraph[3]);
            TpVal.Text = string.Format(FORMAT, postGraph[4]);
            QpVal.Text = string.Format(FORMAT, postGraph[5]);
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog loadFile = new OpenFileDialog())
            {
                loadFile.Filter = "XML File (*.xml)|*.xml";
                loadFile.Title = "Load The Graph";
                loadFile.FilterIndex = 1;
                loadFile.RestoreDirectory = true;
                GraphSaver lv = new GraphSaver();
                if (loadFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileStream readStream = (FileStream)loadFile.OpenFile();
                        XmlSerializer formatter = new XmlSerializer(lv.GetType());
                        byte[] buffer = new byte[readStream.Length];
                        readStream.Read(buffer, 0, (int)readStream.Length);
                        MemoryStream stream = new MemoryStream(buffer);
                        lv = (GraphSaver)formatter.Deserialize(stream);
                        
                        readStream.Close();

                        Graph.Visible = true;
                        if (lv.indiv != null)
                        {
                            PostDev.Visible = false;
                            PreDev.Visible = false;
                            abcVal.Visible = false;
                            abcLabel.Visible = false;
                            CVal.Text = string.Format(FORMAT, lv.indiv[0]);
                            iVal.Text = string.Format(FORMAT, lv.indiv[1]);
                            aVal.Text = string.Format(FORMAT, lv.indiv[2]);
                            VVal.Text = string.Format(FORMAT, lv.indiv[3]);
                            TpVal.Text = string.Format(FORMAT, lv.indiv[4]);
                            QpVal.Text = string.Format(FORMAT, lv.indiv[5]);
                            indivGraph = lv.indiv;
                            Graph.Series["Curve"].Enabled = true;
                            Graph.Series["Pre"].Enabled = false;
                            Graph.Series["Post"].Enabled = false;
                            Graph.Legends["Legend1"].Enabled = false;
                            Graph.Series["Curve"].Points.Clear();
                            generateGraph("Curve", indivGraph[4], indivGraph[5]);
                        }
                        else
                        {
                            PostDev.Visible = true;
                            PreDev.Visible = true;
                            CVal.Text = string.Format(FORMAT, lv.preDev[0]);
                            iVal.Text = string.Format(FORMAT, lv.preDev[1]);
                            aVal.Text = string.Format(FORMAT, lv.preDev[2]);
                            VVal.Text = string.Format(FORMAT, lv.preDev[3]);
                            TpVal.Text = string.Format(FORMAT, lv.preDev[4]);
                            QpVal.Text = string.Format(FORMAT, lv.preDev[5]);
                            Graph.Series["Curve"].Enabled = false;
                            Graph.Series["Pre"].Enabled = true;
                            Graph.Series["Post"].Enabled = true;
                            Graph.Legends["Legend1"].Enabled = true;
                            preGraph = lv.preDev;
                            postGraph = lv.postDev;
                            Graph.Series["Pre"].Points.Clear();
                            Graph.Series["Post"].Points.Clear();
                            generateGraph("Pre", preGraph[4], preGraph[5]);
                            generateGraph("Post", postGraph[4], postGraph[5]);
                            abcVal.Visible = true;
                            abcLabel.Visible = true;

                            fillVol();
                        }

                        SaveImage.Visible = true;

                    }
                    catch (Exception)
                    { }
                }
            }


        }

        [Serializable()]
        public class GraphSaver
        {
            public double[] indiv;
            public double[] preDev;
            public double[] postDev;

            public GraphSaver()
            {
                indiv = null;
                preDev = null;
                postDev = null;
            }

            public GraphSaver(double[] indiv)
            {
                this.indiv = indiv;
                preDev = null;
                postDev = null;
            }

            public GraphSaver(double[] preDev, double[] postDev)
            {
                this.preDev = preDev;
                this.postDev = postDev;
                indiv = null;

            }


        }
    }
}
