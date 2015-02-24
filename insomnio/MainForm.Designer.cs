namespace insomnio

{
    partial class frmInsomnio

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsomnio));
            this.chkEnableDisable = new System.Windows.Forms.CheckBox();
            this.timMove = new System.Windows.Forms.Timer(this.components);
            this.trkTime = new System.Windows.Forms.TrackBar();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.chkMore = new System.Windows.Forms.CheckBox();
            this.trkOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEnableDisable
            // 
            this.chkEnableDisable.AutoSize = true;
            this.chkEnableDisable.Location = new System.Drawing.Point(12, 8);
            this.chkEnableDisable.Name = "chkEnableDisable";
            this.chkEnableDisable.Size = new System.Drawing.Size(59, 17);
            this.chkEnableDisable.TabIndex = 0;
            this.chkEnableDisable.Text = "Enable";
            this.chkEnableDisable.UseVisualStyleBackColor = true;
            this.chkEnableDisable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timMove
            // 
            this.timMove.Interval = 1000;
            this.timMove.Tick += new System.EventHandler(this.timMove_Tick);
            // 
            // trkTime
            // 
            this.trkTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkTime.Location = new System.Drawing.Point(77, 16);
            this.trkTime.Maximum = 500;
            this.trkTime.Minimum = 1;
            this.trkTime.Name = "trkTime";
            this.trkTime.Size = new System.Drawing.Size(195, 45);
            this.trkTime.TabIndex = 3;
            this.trkTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkTime.Value = 1;
            this.trkTime.Scroll += new System.EventHandler(this.trkTime_Scroll);
            this.trkTime.ValueChanged += new System.EventHandler(this.trkTime_ValueChanged);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(278, 16);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(63, 13);
            this.lblSeconds.TabIndex = 4;
            this.lblSeconds.Text = "labSeconds";
            // 
            // chkMore
            // 
            this.chkMore.AutoSize = true;
            this.chkMore.Location = new System.Drawing.Point(12, 23);
            this.chkMore.Name = "chkMore";
            this.chkMore.Size = new System.Drawing.Size(50, 17);
            this.chkMore.TabIndex = 5;
            this.chkMore.Text = "More";
            this.chkMore.UseVisualStyleBackColor = true;
            this.chkMore.CheckedChanged += new System.EventHandler(this.chkMore_CheckedChanged);
            // 
            // trkOpacity
            // 
            this.trkOpacity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trkOpacity.Location = new System.Drawing.Point(77, 67);
            this.trkOpacity.Maximum = 100;
            this.trkOpacity.Minimum = 10;
            this.trkOpacity.Name = "trkOpacity";
            this.trkOpacity.Size = new System.Drawing.Size(195, 45);
            this.trkOpacity.TabIndex = 6;
            this.trkOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkOpacity.Value = 40;
            this.trkOpacity.ValueChanged += new System.EventHandler(this.trkOpacity_ValueChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(278, 67);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(53, 13);
            this.lblOpacity.TabIndex = 7;
            this.lblOpacity.Text = "lblOpacity";
            // 
            // frmInsomnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 108);
            this.Controls.Add(this.lblOpacity);
            this.Controls.Add(this.trkOpacity);
            this.Controls.Add(this.chkMore);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.trkTime);
            this.Controls.Add(this.chkEnableDisable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimumSize = new System.Drawing.Size(374, 79);
            this.Name = "frmInsomnio";
            this.Text = "Insomnio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnableDisable;
        private System.Windows.Forms.Timer timMove;
        private System.Windows.Forms.TrackBar trkTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.CheckBox chkMore;
        private System.Windows.Forms.TrackBar trkOpacity;
        private System.Windows.Forms.Label lblOpacity;
    }
}

