
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CVal = new System.Windows.Forms.TextBox();
            this.iVal = new System.Windows.Forms.TextBox();
            this.aVal = new System.Windows.Forms.TextBox();
            this.VVal = new System.Windows.Forms.TextBox();
            this.GenerateGraph = new System.Windows.Forms.Button();
            this.SaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea2.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.Graph.Legends.Add(legend2);
            this.Graph.Location = new System.Drawing.Point(12, 12);
            this.Graph.Margin = new System.Windows.Forms.Padding(0);
            this.Graph.Name = "Graph";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Curve";
            this.Graph.Series.Add(series2);
            this.Graph.Size = new System.Drawing.Size(600, 354);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "C =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "i =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "V =";
            // 
            // CVal
            // 
            this.CVal.Location = new System.Drawing.Point(655, 30);
            this.CVal.Name = "CVal";
            this.CVal.Size = new System.Drawing.Size(100, 20);
            this.CVal.TabIndex = 5;
            // 
            // iVal
            // 
            this.iVal.Location = new System.Drawing.Point(655, 75);
            this.iVal.Name = "iVal";
            this.iVal.Size = new System.Drawing.Size(100, 20);
            this.iVal.TabIndex = 6;
            // 
            // aVal
            // 
            this.aVal.Location = new System.Drawing.Point(655, 148);
            this.aVal.Name = "aVal";
            this.aVal.Size = new System.Drawing.Size(100, 20);
            this.aVal.TabIndex = 7;
            // 
            // VVal
            // 
            this.VVal.Location = new System.Drawing.Point(655, 201);
            this.VVal.Name = "VVal";
            this.VVal.Size = new System.Drawing.Size(100, 20);
            this.VVal.TabIndex = 8;
            // 
            // GenerateGraph
            // 
            this.GenerateGraph.Location = new System.Drawing.Point(629, 297);
            this.GenerateGraph.Name = "GenerateGraph";
            this.GenerateGraph.Size = new System.Drawing.Size(159, 69);
            this.GenerateGraph.TabIndex = 9;
            this.GenerateGraph.Text = "Generate Graph";
            this.GenerateGraph.UseVisualStyleBackColor = true;
            this.GenerateGraph.Click += new System.EventHandler(this.GenerateGraph_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.Location = new System.Drawing.Point(13, 370);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(140, 79);
            this.SaveImage.TabIndex = 10;
            this.SaveImage.Text = "Save as Image";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.GenerateGraph);
            this.Controls.Add(this.VVal);
            this.Controls.Add(this.aVal);
            this.Controls.Add(this.iVal);
            this.Controls.Add(this.CVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CVal;
        private System.Windows.Forms.TextBox iVal;
        private System.Windows.Forms.TextBox aVal;
        private System.Windows.Forms.TextBox VVal;
        private System.Windows.Forms.Button GenerateGraph;
        private System.Windows.Forms.Button SaveImage;
    }
}

