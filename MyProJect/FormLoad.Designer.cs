namespace MyProJect
{
    partial class FormLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoad));
            this.ProgressBarload = new CircularProgressBar.CircularProgressBar();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lbl_Wait = new System.Windows.Forms.Label();
            this.timer_Load = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgressBarload
            // 
            this.ProgressBarload.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("ProgressBarload.AnimationFunction")));
            this.ProgressBarload.AnimationSpeed = 500;
            this.ProgressBarload.BackColor = System.Drawing.Color.White;
            this.ProgressBarload.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBarload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProgressBarload.InnerColor = System.Drawing.Color.White;
            this.ProgressBarload.InnerMargin = 2;
            this.ProgressBarload.InnerWidth = -1;
            this.ProgressBarload.Location = new System.Drawing.Point(0, 33);
            this.ProgressBarload.MarqueeAnimationSpeed = 500;
            this.ProgressBarload.Name = "ProgressBarload";
            this.ProgressBarload.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.ProgressBarload.OuterMargin = -25;
            this.ProgressBarload.OuterWidth = 25;
            this.ProgressBarload.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ProgressBarload.ProgressWidth = 7;
            this.ProgressBarload.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgressBarload.Size = new System.Drawing.Size(175, 175);
            this.ProgressBarload.StartAngle = 270;
            this.ProgressBarload.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarload.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBarload.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBarload.SubscriptText = "";
            this.ProgressBarload.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBarload.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBarload.SuperscriptText = "";
            this.ProgressBarload.TabIndex = 0;
            this.ProgressBarload.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgressBarload.Value = 68;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.Color.Black;
            this.lblLoad.Location = new System.Drawing.Point(22, -1);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(142, 33);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "Loading...";
            // 
            // lbl_Wait
            // 
            this.lbl_Wait.AutoSize = true;
            this.lbl_Wait.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wait.ForeColor = System.Drawing.Color.Black;
            this.lbl_Wait.Location = new System.Drawing.Point(8, 206);
            this.lbl_Wait.Name = "lbl_Wait";
            this.lbl_Wait.Size = new System.Drawing.Size(164, 33);
            this.lbl_Wait.TabIndex = 2;
            this.lbl_Wait.Text = "Please wait";
            // 
            // timer_Load
            // 
            this.timer_Load.Enabled = true;
            this.timer_Load.Tick += new System.EventHandler(this.timer_Load_Tick);
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(177, 247);
            this.Controls.Add(this.lbl_Wait);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.ProgressBarload);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoad";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar ProgressBarload;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lbl_Wait;
        private System.Windows.Forms.Timer timer_Load;
    }
}