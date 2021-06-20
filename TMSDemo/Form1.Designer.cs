namespace TMSDemo
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
            this.lblProcessing = new System.Windows.Forms.Label();
            this.btnShowPrasadam = new System.Windows.Forms.Button();
            this.btnDeletePrasadamType = new System.Windows.Forms.Button();
            this.btnCreatePriest = new System.Windows.Forms.Button();
            this.btnShowDsitribution = new System.Windows.Forms.Button();
            this.btnCreateDistribution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProcessing
            // 
            this.lblProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Location = new System.Drawing.Point(12, 197);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(48, 17);
            this.lblProcessing.TabIndex = 0;
            this.lblProcessing.Text = "Status";
            // 
            // btnShowPrasadam
            // 
            this.btnShowPrasadam.Location = new System.Drawing.Point(75, 47);
            this.btnShowPrasadam.Name = "btnShowPrasadam";
            this.btnShowPrasadam.Size = new System.Drawing.Size(165, 42);
            this.btnShowPrasadam.TabIndex = 1;
            this.btnShowPrasadam.Text = "Show Prasadam Type";
            this.btnShowPrasadam.UseVisualStyleBackColor = true;
            this.btnShowPrasadam.Click += new System.EventHandler(this.btnShowPrasadam_Click);
            // 
            // btnDeletePrasadamType
            // 
            this.btnDeletePrasadamType.Location = new System.Drawing.Point(278, 47);
            this.btnDeletePrasadamType.Name = "btnDeletePrasadamType";
            this.btnDeletePrasadamType.Size = new System.Drawing.Size(165, 42);
            this.btnDeletePrasadamType.TabIndex = 2;
            this.btnDeletePrasadamType.Text = "Delete Prasadam Type";
            this.btnDeletePrasadamType.UseVisualStyleBackColor = true;
            this.btnDeletePrasadamType.Click += new System.EventHandler(this.btnDeletePrasadamType_Click);
            // 
            // btnCreatePriest
            // 
            this.btnCreatePriest.Location = new System.Drawing.Point(473, 47);
            this.btnCreatePriest.Name = "btnCreatePriest";
            this.btnCreatePriest.Size = new System.Drawing.Size(165, 42);
            this.btnCreatePriest.TabIndex = 3;
            this.btnCreatePriest.Text = "Create Priest";
            this.btnCreatePriest.UseVisualStyleBackColor = true;
            this.btnCreatePriest.Click += new System.EventHandler(this.btnCreatePriest_Click);
            // 
            // btnShowDsitribution
            // 
            this.btnShowDsitribution.Location = new System.Drawing.Point(399, 131);
            this.btnShowDsitribution.Name = "btnShowDsitribution";
            this.btnShowDsitribution.Size = new System.Drawing.Size(165, 42);
            this.btnShowDsitribution.TabIndex = 4;
            this.btnShowDsitribution.Text = "Show Distribution";
            this.btnShowDsitribution.UseVisualStyleBackColor = true;
            this.btnShowDsitribution.Click += new System.EventHandler(this.btnShowDistribution_Click);
            // 
            // btnCreateDistribution
            // 
            this.btnCreateDistribution.Location = new System.Drawing.Point(180, 131);
            this.btnCreateDistribution.Name = "btnCreateDistribution";
            this.btnCreateDistribution.Size = new System.Drawing.Size(165, 42);
            this.btnCreateDistribution.TabIndex = 5;
            this.btnCreateDistribution.Text = "Create Distribution";
            this.btnCreateDistribution.UseVisualStyleBackColor = true;
            this.btnCreateDistribution.Click += new System.EventHandler(this.btnCreateDistribution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 233);
            this.Controls.Add(this.btnCreateDistribution);
            this.Controls.Add(this.btnShowDsitribution);
            this.Controls.Add(this.btnCreatePriest);
            this.Controls.Add(this.btnDeletePrasadamType);
            this.Controls.Add(this.btnShowPrasadam);
            this.Controls.Add(this.lblProcessing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Button btnShowPrasadam;
        private System.Windows.Forms.Button btnDeletePrasadamType;
        private System.Windows.Forms.Button btnCreatePriest;
        private System.Windows.Forms.Button btnShowDsitribution;
        private System.Windows.Forms.Button btnCreateDistribution;
    }
}

