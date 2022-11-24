namespace normalDistributions
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonXSq = new System.Windows.Forms.Button();
            this.buttonXDivYSq = new System.Windows.Forms.Button();
            this.buttonXSqDivYSq = new System.Windows.Forms.Button();
            this.XDivY = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(31, 12);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(93, 23);
            this.buttonX.TabIndex = 0;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonXSq
            // 
            this.buttonXSq.Location = new System.Drawing.Point(210, 12);
            this.buttonXSq.Name = "buttonXSq";
            this.buttonXSq.Size = new System.Drawing.Size(93, 23);
            this.buttonXSq.TabIndex = 1;
            this.buttonXSq.Text = "XSq";
            this.buttonXSq.UseVisualStyleBackColor = true;
            this.buttonXSq.Click += new System.EventHandler(this.buttonXSq_Click);
            // 
            // buttonXDivYSq
            // 
            this.buttonXDivYSq.Location = new System.Drawing.Point(393, 12);
            this.buttonXDivYSq.Name = "buttonXDivYSq";
            this.buttonXDivYSq.Size = new System.Drawing.Size(101, 23);
            this.buttonXDivYSq.TabIndex = 2;
            this.buttonXDivYSq.Text = "X/YSq";
            this.buttonXDivYSq.UseVisualStyleBackColor = true;
            this.buttonXDivYSq.Click += new System.EventHandler(this.buttonXDivYSq_Click);
            // 
            // buttonXSqDivYSq
            // 
            this.buttonXSqDivYSq.Location = new System.Drawing.Point(560, 12);
            this.buttonXSqDivYSq.Name = "buttonXSqDivYSq";
            this.buttonXSqDivYSq.Size = new System.Drawing.Size(93, 23);
            this.buttonXSqDivYSq.TabIndex = 3;
            this.buttonXSqDivYSq.Text = "XSq/YSq";
            this.buttonXSqDivYSq.UseVisualStyleBackColor = true;
            this.buttonXSqDivYSq.Click += new System.EventHandler(this.buttonXSqDivYSq_Click);
            // 
            // XDivY
            // 
            this.XDivY.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.XDivY.Location = new System.Drawing.Point(698, 12);
            this.XDivY.Name = "XDivY";
            this.XDivY.Size = new System.Drawing.Size(93, 23);
            this.XDivY.TabIndex = 4;
            this.XDivY.Text = "X/Y";
            this.XDivY.UseVisualStyleBackColor = true;
            this.XDivY.Click += new System.EventHandler(this.XDivY_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart.Location = new System.Drawing.Point(0, 41);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1265, 641);
            this.chart.TabIndex = 5;
            this.chart.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.XDivY);
            this.Controls.Add(this.buttonXSqDivYSq);
            this.Controls.Add(this.buttonXDivYSq);
            this.Controls.Add(this.buttonXSq);
            this.Controls.Add(this.buttonX);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonX;
        private Button buttonXSq;
        private Button buttonXDivYSq;
        private Button buttonXSqDivYSq;
        private Button XDivY;
        private PictureBox chart;
    }
}