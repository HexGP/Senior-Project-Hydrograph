
namespace Hydrograph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.CVal = new System.Windows.Forms.TextBox();
            this.iVal = new System.Windows.Forms.TextBox();
            this.aVal = new System.Windows.Forms.TextBox();
            this.VVal = new System.Windows.Forms.TextBox();
            this.GenerateGraph = new System.Windows.Forms.Button();
            this.SaveImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TpLabel = new System.Windows.Forms.Label();
            this.QpLabel = new System.Windows.Forms.Label();
            this.TpVal = new System.Windows.Forms.Label();
            this.QpVal = new System.Windows.Forms.Label();
            this.PreDev = new System.Windows.Forms.Button();
            this.PostDev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.BackColor = System.Drawing.Color.Navy;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Time (ti)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Flow (qi)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Navy;
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(12, 12);
            this.Graph.Margin = new System.Windows.Forms.Padding(0);
            this.Graph.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Graph.MinimumSize = new System.Drawing.Size(904, 458);
            this.Graph.Name = "Graph";
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.White;
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.Name = "Curve";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.Name = "Pre";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Cyan;
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "Post";
            this.Graph.Series.Add(series1);
            this.Graph.Series.Add(series2);
            this.Graph.Series.Add(series3);
            this.Graph.Size = new System.Drawing.Size(904, 458);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(919, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "C =";
            // 
            // CVal
            // 
            this.CVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVal.Location = new System.Drawing.Point(985, 49);
            this.CVal.Name = "CVal";
            this.CVal.Size = new System.Drawing.Size(202, 43);
            this.CVal.TabIndex = 5;
            // 
            // iVal
            // 
            this.iVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iVal.Location = new System.Drawing.Point(985, 122);
            this.iVal.Name = "iVal";
            this.iVal.Size = new System.Drawing.Size(202, 43);
            this.iVal.TabIndex = 6;
            // 
            // aVal
            // 
            this.aVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aVal.Location = new System.Drawing.Point(985, 200);
            this.aVal.Name = "aVal";
            this.aVal.Size = new System.Drawing.Size(202, 43);
            this.aVal.TabIndex = 7;
            // 
            // VVal
            // 
            this.VVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VVal.Location = new System.Drawing.Point(985, 273);
            this.VVal.Name = "VVal";
            this.VVal.Size = new System.Drawing.Size(202, 43);
            this.VVal.TabIndex = 8;
            // 
            // GenerateGraph
            // 
            this.GenerateGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateGraph.AutoSize = true;
            this.GenerateGraph.BackColor = System.Drawing.Color.White;
            this.GenerateGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateGraph.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.GenerateGraph.Location = new System.Drawing.Point(935, 349);
            this.GenerateGraph.Name = "GenerateGraph";
            this.GenerateGraph.Size = new System.Drawing.Size(252, 121);
            this.GenerateGraph.TabIndex = 9;
            this.GenerateGraph.Text = "Generate\r\nGraph";
            this.GenerateGraph.UseVisualStyleBackColor = false;
            this.GenerateGraph.Click += new System.EventHandler(this.GenerateGraph_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveImage.Location = new System.Drawing.Point(12, 496);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(140, 79);
            this.SaveImage.TabIndex = 10;
            this.SaveImage.Text = "Save as Image";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(928, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "i =";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(917, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "A =";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(922, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "V =";
            // 
            // TpLabel
            // 
            this.TpLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TpLabel.AutoSize = true;
            this.TpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.TpLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpLabel.ForeColor = System.Drawing.Color.White;
            this.TpLabel.Location = new System.Drawing.Point(301, 496);
            this.TpLabel.Name = "TpLabel";
            this.TpLabel.Size = new System.Drawing.Size(70, 37);
            this.TpLabel.TabIndex = 14;
            this.TpLabel.Text = "Tp =";
            // 
            // QpLabel
            // 
            this.QpLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QpLabel.AutoSize = true;
            this.QpLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QpLabel.ForeColor = System.Drawing.Color.White;
            this.QpLabel.Location = new System.Drawing.Point(293, 539);
            this.QpLabel.Name = "QpLabel";
            this.QpLabel.Size = new System.Drawing.Size(78, 37);
            this.QpLabel.TabIndex = 15;
            this.QpLabel.Text = "Qp =";
            // 
            // TpVal
            // 
            this.TpVal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TpVal.AutoSize = true;
            this.TpVal.BackColor = System.Drawing.Color.White;
            this.TpVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.TpVal.Location = new System.Drawing.Point(377, 496);
            this.TpVal.Name = "TpVal";
            this.TpVal.Size = new System.Drawing.Size(113, 37);
            this.TpVal.TabIndex = 16;
            this.TpVal.Text = "0.00000";
            // 
            // QpVal
            // 
            this.QpVal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QpVal.AutoSize = true;
            this.QpVal.BackColor = System.Drawing.Color.White;
            this.QpVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QpVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.QpVal.Location = new System.Drawing.Point(377, 539);
            this.QpVal.Name = "QpVal";
            this.QpVal.Size = new System.Drawing.Size(113, 37);
            this.QpVal.TabIndex = 17;
            this.QpVal.Text = "0.00000";
            // 
            // PreDev
            // 
            this.PreDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreDev.BackColor = System.Drawing.Color.White;
            this.PreDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreDev.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.PreDev.Location = new System.Drawing.Point(929, 12);
            this.PreDev.Name = "PreDev";
            this.PreDev.Size = new System.Drawing.Size(102, 23);
            this.PreDev.TabIndex = 18;
            this.PreDev.Text = "Pre-Developed";
            this.PreDev.UseVisualStyleBackColor = false;
            this.PreDev.Visible = false;
            this.PreDev.Click += new System.EventHandler(this.PreDev_Click);
            // 
            // PostDev
            // 
            this.PostDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostDev.BackColor = System.Drawing.Color.White;
            this.PostDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostDev.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.PostDev.Location = new System.Drawing.Point(1085, 12);
            this.PostDev.Name = "PostDev";
            this.PostDev.Size = new System.Drawing.Size(102, 23);
            this.PostDev.TabIndex = 19;
            this.PostDev.Text = "Post-Developed";
            this.PostDev.UseVisualStyleBackColor = false;
            this.PostDev.Visible = false;
            this.PostDev.Click += new System.EventHandler(this.PostDev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1199, 599);
            this.Controls.Add(this.PostDev);
            this.Controls.Add(this.PreDev);
            this.Controls.Add(this.QpVal);
            this.Controls.Add(this.TpVal);
            this.Controls.Add(this.QpLabel);
            this.Controls.Add(this.TpLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.GenerateGraph);
            this.Controls.Add(this.VVal);
            this.Controls.Add(this.aVal);
            this.Controls.Add(this.iVal);
            this.Controls.Add(this.CVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1215, 638);
            this.Name = "Form1";
            this.Text = "Hydrograph";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CVal;
        private System.Windows.Forms.TextBox iVal;
        private System.Windows.Forms.TextBox aVal;
        private System.Windows.Forms.TextBox VVal;
        private System.Windows.Forms.Button GenerateGraph;
        private System.Windows.Forms.Button SaveImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TpLabel;
        private System.Windows.Forms.Label QpLabel;
        private System.Windows.Forms.Label TpVal;
        private System.Windows.Forms.Label QpVal;
        private System.Windows.Forms.Button PreDev;
        private System.Windows.Forms.Button PostDev;
    }
}

