
namespace Stepr
{
    partial class Form2
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
            this.pnl_quad_top_left = new System.Windows.Forms.Panel();
            this.pnl_quad_top_right = new System.Windows.Forms.Panel();
            this.pnl_quad_bottom_left = new System.Windows.Forms.Panel();
            this.pnl_quad_bottom_right = new System.Windows.Forms.Panel();
            this.tmr_overlayUpdater = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnl_quad_top_left
            // 
            this.pnl_quad_top_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_quad_top_left.BackColor = System.Drawing.Color.Yellow;
            this.pnl_quad_top_left.Location = new System.Drawing.Point(12, 9);
            this.pnl_quad_top_left.Name = "pnl_quad_top_left";
            this.pnl_quad_top_left.Size = new System.Drawing.Size(128, 99);
            this.pnl_quad_top_left.TabIndex = 0;
            // 
            // pnl_quad_top_right
            // 
            this.pnl_quad_top_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_quad_top_right.BackColor = System.Drawing.Color.Yellow;
            this.pnl_quad_top_right.Location = new System.Drawing.Point(146, 9);
            this.pnl_quad_top_right.Name = "pnl_quad_top_right";
            this.pnl_quad_top_right.Size = new System.Drawing.Size(128, 99);
            this.pnl_quad_top_right.TabIndex = 1;
            // 
            // pnl_quad_bottom_left
            // 
            this.pnl_quad_bottom_left.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_quad_bottom_left.BackColor = System.Drawing.Color.Yellow;
            this.pnl_quad_bottom_left.Location = new System.Drawing.Point(12, 114);
            this.pnl_quad_bottom_left.Name = "pnl_quad_bottom_left";
            this.pnl_quad_bottom_left.Size = new System.Drawing.Size(128, 99);
            this.pnl_quad_bottom_left.TabIndex = 1;
            // 
            // pnl_quad_bottom_right
            // 
            this.pnl_quad_bottom_right.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_quad_bottom_right.BackColor = System.Drawing.Color.Yellow;
            this.pnl_quad_bottom_right.Location = new System.Drawing.Point(146, 114);
            this.pnl_quad_bottom_right.Name = "pnl_quad_bottom_right";
            this.pnl_quad_bottom_right.Size = new System.Drawing.Size(128, 99);
            this.pnl_quad_bottom_right.TabIndex = 1;
            // 
            // tmr_overlayUpdater
            // 
            this.tmr_overlayUpdater.Interval = 1;
            this.tmr_overlayUpdater.Tick += new System.EventHandler(this.tmr_overlayUpdater_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(286, 223);
            this.Controls.Add(this.pnl_quad_bottom_right);
            this.Controls.Add(this.pnl_quad_bottom_left);
            this.Controls.Add(this.pnl_quad_top_right);
            this.Controls.Add(this.pnl_quad_top_left);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Stepr - Select area";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_quad_top_left;
        private System.Windows.Forms.Panel pnl_quad_top_right;
        private System.Windows.Forms.Panel pnl_quad_bottom_left;
        private System.Windows.Forms.Panel pnl_quad_bottom_right;
        private System.Windows.Forms.Timer tmr_overlayUpdater;
    }
}