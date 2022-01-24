namespace xSquaredTest
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
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.QuadraticGenerator = new System.Windows.Forms.Button();
            this.LineGenerator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.slope = new System.Windows.Forms.TextBox();
            this.yIntercept = new System.Windows.Forms.TextBox();
            this.aVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bVal = new System.Windows.Forms.TextBox();
            this.cVal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(12, 12);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "curve";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(556, 350);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "Graph";
            // 
            // QuadraticGenerator
            // 
            this.QuadraticGenerator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuadraticGenerator.Location = new System.Drawing.Point(629, 12);
            this.QuadraticGenerator.Name = "QuadraticGenerator";
            this.QuadraticGenerator.Size = new System.Drawing.Size(159, 48);
            this.QuadraticGenerator.TabIndex = 1;
            this.QuadraticGenerator.Text = "Generate Quadratic";
            this.QuadraticGenerator.UseVisualStyleBackColor = true;
            this.QuadraticGenerator.Click += new System.EventHandler(this.QuadraticGenerator_Click);
            // 
            // LineGenerator
            // 
            this.LineGenerator.Location = new System.Drawing.Point(629, 66);
            this.LineGenerator.Name = "LineGenerator";
            this.LineGenerator.Size = new System.Drawing.Size(159, 40);
            this.LineGenerator.TabIndex = 2;
            this.LineGenerator.Text = "Generate Line";
            this.LineGenerator.UseVisualStyleBackColor = true;
            this.LineGenerator.Click += new System.EventHandler(this.LineGenerator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "m";
            // 
            // slope
            // 
            this.slope.Location = new System.Drawing.Point(647, 117);
            this.slope.Name = "slope";
            this.slope.Size = new System.Drawing.Size(54, 20);
            this.slope.TabIndex = 4;
            this.slope.Text = "1";
            // 
            // yIntercept
            // 
            this.yIntercept.Location = new System.Drawing.Point(647, 143);
            this.yIntercept.Name = "yIntercept";
            this.yIntercept.Size = new System.Drawing.Size(54, 20);
            this.yIntercept.TabIndex = 5;
            this.yIntercept.Text = "0";
            // 
            // aVal
            // 
            this.aVal.Location = new System.Drawing.Point(734, 117);
            this.aVal.Name = "aVal";
            this.aVal.Size = new System.Drawing.Size(54, 20);
            this.aVal.TabIndex = 6;
            this.aVal.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "b";
            // 
            // bVal
            // 
            this.bVal.Location = new System.Drawing.Point(734, 146);
            this.bVal.Name = "bVal";
            this.bVal.Size = new System.Drawing.Size(54, 20);
            this.bVal.TabIndex = 8;
            this.bVal.Text = "0";
            // 
            // cVal
            // 
            this.cVal.Location = new System.Drawing.Point(734, 172);
            this.cVal.Name = "cVal";
            this.cVal.Size = new System.Drawing.Size(54, 20);
            this.cVal.TabIndex = 9;
            this.cVal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "c";
            // 
            // SaveGraph
            // 
            this.SaveGraph.Location = new System.Drawing.Point(629, 225);
            this.SaveGraph.Name = "SaveGraph";
            this.SaveGraph.Size = new System.Drawing.Size(159, 40);
            this.SaveGraph.TabIndex = 13;
            this.SaveGraph.Text = "Save Graph";
            this.SaveGraph.UseVisualStyleBackColor = true;
            this.SaveGraph.Click += new System.EventHandler(this.SaveGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveGraph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cVal);
            this.Controls.Add(this.bVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aVal);
            this.Controls.Add(this.yIntercept);
            this.Controls.Add(this.slope);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineGenerator);
            this.Controls.Add(this.QuadraticGenerator);
            this.Controls.Add(this.Graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.Button QuadraticGenerator;
        private System.Windows.Forms.Button LineGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox slope;
        private System.Windows.Forms.TextBox yIntercept;
        private System.Windows.Forms.TextBox aVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bVal;
        private System.Windows.Forms.TextBox cVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveGraph;
    }
}

