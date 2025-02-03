namespace AlertBox
{
    partial class AlertForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            this.alertTitle = new System.Windows.Forms.Label();
            this.alertText = new System.Windows.Forms.Label();
            this.alertPicture = new System.Windows.Forms.PictureBox();
            this.alertClose = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alertPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertClose)).BeginInit();
            this.SuspendLayout();
            // 
            // alertTitle
            // 
            this.alertTitle.AutoSize = true;
            this.alertTitle.BackColor = System.Drawing.Color.Transparent;
            this.alertTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertTitle.ForeColor = System.Drawing.Color.White;
            this.alertTitle.Location = new System.Drawing.Point(55, 9);
            this.alertTitle.Name = "alertTitle";
            this.alertTitle.Size = new System.Drawing.Size(105, 25);
            this.alertTitle.TabIndex = 0;
            this.alertTitle.Text = "alertTitle";
            // 
            // alertText
            // 
            this.alertText.AutoSize = true;
            this.alertText.BackColor = System.Drawing.Color.Transparent;
            this.alertText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertText.ForeColor = System.Drawing.Color.White;
            this.alertText.Location = new System.Drawing.Point(56, 34);
            this.alertText.Name = "alertText";
            this.alertText.Size = new System.Drawing.Size(70, 20);
            this.alertText.TabIndex = 1;
            this.alertText.Text = "alertText";
            // 
            // alertPicture
            // 
            this.alertPicture.BackColor = System.Drawing.Color.Transparent;
            this.alertPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alertPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.alertPicture.Location = new System.Drawing.Point(0, 0);
            this.alertPicture.Name = "alertPicture";
            this.alertPicture.Size = new System.Drawing.Size(50, 66);
            this.alertPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.alertPicture.TabIndex = 2;
            this.alertPicture.TabStop = false;
            // 
            // alertClose
            // 
            this.alertClose.BackColor = System.Drawing.Color.Transparent;
            this.alertClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alertClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.alertClose.Image = ((System.Drawing.Image)(resources.GetObject("alertClose.Image")));
            this.alertClose.Location = new System.Drawing.Point(339, 0);
            this.alertClose.Name = "alertClose";
            this.alertClose.Size = new System.Drawing.Size(17, 66);
            this.alertClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertClose.TabIndex = 3;
            this.alertClose.TabStop = false;
            this.alertClose.Click += new System.EventHandler(this.alertClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AlertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(356, 66);
            this.ControlBox = false;
            this.Controls.Add(this.alertClose);
            this.Controls.Add(this.alertPicture);
            this.Controls.Add(this.alertText);
            this.Controls.Add(this.alertTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AlertForm";
            ((System.ComponentModel.ISupportInitialize)(this.alertPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alertTitle;
        private System.Windows.Forms.Label alertText;
        private System.Windows.Forms.PictureBox alertPicture;
        private System.Windows.Forms.PictureBox alertClose;
        internal System.Windows.Forms.Timer timer1;
    }
}