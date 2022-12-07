using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stepr
{
    public partial class Form2 : Form
    {
        public Form1 parentForm;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();

        private bool isDragging = false;
        private Point startPoint;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetProcessDPIAware();
            this.Location = Cursor.Position;
            this.WindowState = FormWindowState.Maximized;

            UpdateOverlay();
            tmr_overlayUpdater.Start();
        }

        private void tmr_overlayUpdater_Tick(object sender, EventArgs e)
        {
            UpdateOverlay();
        }

        private void UpdateOverlay()
        {
            if (isDragging)
            {
                pnl_quad_top_left.Size = new Size(Cursor.Position.X - startPoint.X, Cursor.Position.Y - startPoint.Y);
            }
            else
            {
                Size screenSize = this.Size;
                Point targetPoint = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);

                pnl_quad_top_left.Size = new Size(targetPoint.X - 1, targetPoint.Y - 1);
                pnl_quad_top_left.Location = new Point(0, 0);

                pnl_quad_top_right.Size = new Size(screenSize.Width - targetPoint.X - 1, targetPoint.Y - 1);
                pnl_quad_top_right.Location = new Point(targetPoint.X + 1, 0);

                pnl_quad_bottom_left.Size = new Size(targetPoint.X - 1, screenSize.Height - targetPoint.Y - 1);
                pnl_quad_bottom_left.Location = new Point(0, targetPoint.Y + 1);

                pnl_quad_bottom_right.Size = new Size(screenSize.Width - targetPoint.X - 1, screenSize.Height - targetPoint.Y - 1);
                pnl_quad_bottom_right.Location = new Point(targetPoint.X + 1, targetPoint.Y + 1);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            startPoint = Cursor.Position;

            pnl_quad_top_right.Visible = false;
            pnl_quad_bottom_left.Visible = false;
            pnl_quad_bottom_right.Visible = false;

            pnl_quad_top_left.Location = new Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            EndSequence();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) EndSequence();
        }

        private void EndSequence()
        {
            tmr_overlayUpdater.Stop();

            this.Hide();

            parentForm.activeBmp = CaptureScreen(startPoint.X, startPoint.Y, pnl_quad_top_left.Width, pnl_quad_top_left.Height);
            parentForm.clearBmp = (Bitmap)parentForm.activeBmp.Clone();
            parentForm.DisablePrompt();

            this.Close();
        }

        private Bitmap CaptureScreen(int x, int y, int w, int h)
        {
            w = w < 1 ? 1 : w;
            h = h < 1 ? 1 : h;

            Bitmap b = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(x, y, 0, 0, new Size(w, h), CopyPixelOperation.SourceCopy);
            }
            return b;
        }
    }
}
