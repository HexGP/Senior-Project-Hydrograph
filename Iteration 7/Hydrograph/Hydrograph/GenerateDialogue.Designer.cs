
namespace Hydrograph
{
    partial class GenerateDialogue
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
            this.label2 = new System.Windows.Forms.Label();
            this.PreDev = new System.Windows.Forms.Button();
            this.PostDev = new System.Windows.Forms.Button();
            this.Indiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "What type of hydrograph is the data for?";
            // 
            // PreDev
            // 
            this.PreDev.BackColor = System.Drawing.Color.White;
            this.PreDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreDev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.PreDev.Location = new System.Drawing.Point(32, 90);
            this.PreDev.Name = "PreDev";
            this.PreDev.Size = new System.Drawing.Size(173, 46);
            this.PreDev.TabIndex = 1;
            this.PreDev.Text = "Pre-Developed";
            this.PreDev.UseVisualStyleBackColor = false;
            this.PreDev.Click += new System.EventHandler(this.PreDev_Click);
            // 
            // PostDev
            // 
            this.PostDev.BackColor = System.Drawing.Color.White;
            this.PostDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostDev.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.PostDev.Location = new System.Drawing.Point(211, 90);
            this.PostDev.Name = "PostDev";
            this.PostDev.Size = new System.Drawing.Size(173, 46);
            this.PostDev.TabIndex = 2;
            this.PostDev.Text = "Post-Developed";
            this.PostDev.UseVisualStyleBackColor = false;
            this.PostDev.Click += new System.EventHandler(this.PostDev_Click);
            // 
            // Indiv
            // 
            this.Indiv.BackColor = System.Drawing.Color.White;
            this.Indiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indiv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.Indiv.Location = new System.Drawing.Point(390, 90);
            this.Indiv.Name = "Indiv";
            this.Indiv.Size = new System.Drawing.Size(173, 46);
            this.Indiv.TabIndex = 3;
            this.Indiv.Text = "Individual";
            this.Indiv.UseVisualStyleBackColor = false;
            this.Indiv.Click += new System.EventHandler(this.Indiv_Click);
            // 
            // GenerateDialogue
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(591, 169);
            this.Controls.Add(this.Indiv);
            this.Controls.Add(this.PostDev);
            this.Controls.Add(this.PreDev);
            this.Controls.Add(this.label2);
            this.Name = "GenerateDialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreGraph;
        private System.Windows.Forms.Button PostDeveloped;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PreDev;
        private System.Windows.Forms.Button PostDev;
        private System.Windows.Forms.Button Indiv;
    }
}