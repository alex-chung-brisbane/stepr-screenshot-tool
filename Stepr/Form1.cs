﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Stepr
{
    public partial class Form1 : Form
    {
        public Bitmap activeBmp;
        public Bitmap clearBmp;
        private Bitmap workingBmp;

        private ColorConverter colConverter = new ColorConverter();

        private IDictionary<ToolStripTextBox, string> defaultSettings = new Dictionary<ToolStripTextBox, string>();

        private int curTool = -1;

        private string[] tools = {
            "Label [ # ]",
            "Label [ T ]",
            "Rect (out)",
            "Rect (fill)",
            "Circle",
            "Line",
            "Blur"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defaultSettings.Add(new KeyValuePair<ToolStripTextBox, string>(tstb_color_fore, tstb_color_fore.Text));
            defaultSettings.Add(new KeyValuePair<ToolStripTextBox, string>(tstb_color_back, tstb_color_back.Text));
            defaultSettings.Add(new KeyValuePair<ToolStripTextBox, string>(tstb_size_thick, tstb_size_thick.Text));
            defaultSettings.Add(new KeyValuePair<ToolStripTextBox, string>(tstb_size_font, tstb_size_font.Text));
        }

        public void DisablePrompt()
        {
            lbl_info.Visible = false;
        }

        private void tstb_color_fore_TextChanged(object sender, EventArgs e)
        {
            ValidateHex(sender);
        }

        private void tstb_color_back_TextChanged(object sender, EventArgs e)
        {
            ValidateHex(sender);
        }

        private void ValidateHex(object sender)
        {
            try
            {
                colConverter.ConvertFromString(((ToolStripTextBox)sender).Text);
                ((ToolStripTextBox)sender).BackColor = SystemColors.Window;
                ((ToolStripTextBox)sender).ForeColor = Color.Black;
            } catch (Exception)
            {
                ((ToolStripTextBox)sender).BackColor = Color.Red;
                ((ToolStripTextBox)sender).ForeColor = Color.White;
            }
        }

        private void tstb_size_font_TextChanged(object sender, EventArgs e)
        {
            ValidateInt(sender);
        }

        private void tstb_size_thick_TextChanged(object sender, EventArgs e)
        {
            ValidateInt(sender);
        }

        private void ValidateInt(object sender)
        {
            int consumeInt = 0;
            if (int.TryParse(((ToolStripTextBox)sender).Text, out consumeInt))
            {
                ((ToolStripTextBox)sender).BackColor = SystemColors.Window;
                ((ToolStripTextBox)sender).ForeColor = Color.Black;
            } else
            {
                ((ToolStripTextBox)sender).BackColor = Color.Red;
                ((ToolStripTextBox)sender).ForeColor = Color.White;
            }
        }

        private void tsmi_default_Click(object sender, EventArgs e)
        {
            tstb_color_fore.Text = defaultSettings[tstb_color_fore];
            tstb_color_back.Text = defaultSettings[tstb_color_back];
            tstb_size_thick.Text = defaultSettings[tstb_size_thick];
            tstb_size_font.Text = defaultSettings[tstb_size_font];
        }

        private void tsmi_rect_outline_Click(object sender, EventArgs e)
        {
            ChangeTool(2);
        }

        private void tsmi_rect_filled_Click(object sender, EventArgs e)
        {
            ChangeTool(3);
        }

        private void circleoutlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTool(4);
        }

        private void tsmi_line_Click(object sender, EventArgs e)
        {
            ChangeTool(5);
        }

        private void tsmi_blur_Click(object sender, EventArgs e)
        {
            ChangeTool(6);
        }

        private void ChangeTool(int toolID)
        {
            curTool = toolID;
            tsmi_tools.Text = "Selected tool: " + tools[toolID];
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                curTool = -1;
                tsmi_tools.Text = "Selected tool: None";
            }
        }

        private void tsmi_clip_Click(object sender, EventArgs e)
        {
            Form2 areaSelector = new Form2();
            areaSelector.parentForm = this;
            areaSelector.Show();
            this.Hide();
        }

        private void pb_edit_Paint(object sender, PaintEventArgs e)
        {
            if (activeBmp != null)
            {
                pb_edit.Size = activeBmp.Size;
                e.Graphics.DrawImage(activeBmp, new Point(0, 0));
            }
        }

        private void tsmi_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(activeBmp);
        }

        private void tsmi_clear_Click(object sender, EventArgs e)
        {
            RefreshEditor(clearBmp);
        }

        private void RefreshEditor(Bitmap updatedBmp)
        {
            if (updatedBmp == null) return;

            // TODO: Handle history

            activeBmp.Dispose();
            activeBmp = (Bitmap)updatedBmp.Clone();
            pb_edit.Invalidate();
        }

        private void UpdateWorkingBmp()
        {
            workingBmp = (Bitmap)activeBmp.Clone();
        }

        private void pb_edit_MouseClick(object sender, MouseEventArgs e)
        {
            if (activeBmp == null || !(curTool == 0 || curTool == 1)) return;

            UpdateWorkingBmp();

            Font curFont = new Font("Tahoma", int.Parse(tstb_size_font.Text), FontStyle.Bold);
            int labelSize;
            RectangleF rectf;
            StringFormat strFormat;

            Graphics g = Graphics.FromImage(workingBmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            switch (curTool)
            {
                case 0:

                    labelSize = TextRenderer.MeasureText(tstb_label_num.Text, curFont).Width;
                    rectf = new RectangleF((float)(e.Location.X - (labelSize * 0.6)), (float)(e.Location.Y - (labelSize * 0.6)), (float)(labelSize * 1.2), (float)(labelSize * 1.2));
                    strFormat = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.FillEllipse(new SolidBrush((Color)colConverter.ConvertFromString(tstb_color_back.Text)), rectf);
                    g.DrawString(tstb_label_num.Text, curFont, new SolidBrush((Color)colConverter.ConvertFromString(tstb_color_fore.Text)), rectf, strFormat);
                    g.Flush();

                    tstb_label_num.Text = (int.Parse(tstb_label_num.Text) + 1).ToString();

                    break;
                case 1:

                    labelSize = TextRenderer.MeasureText(tstb_label_text.Text, curFont).Width;
                    rectf = new RectangleF(e.Location.X, e.Location.Y - int.Parse(tstb_size_font.Text), labelSize, int.Parse(tstb_size_font.Text) * 2);
                    strFormat = new StringFormat()
                    {
                        Alignment = StringAlignment.Near,
                        LineAlignment = StringAlignment.Center
                    };
                    g.FillRectangle(new SolidBrush((Color)colConverter.ConvertFromString(tstb_color_back.Text)), rectf);
                    g.DrawString(tstb_label_text.Text, curFont, new SolidBrush((Color)colConverter.ConvertFromString(tstb_color_fore.Text)), rectf, strFormat);
                    g.Flush();

                    break;
                default:
                    break;
            }

            RefreshEditor(workingBmp);
        }

        private void tstb_label_num_TextChanged(object sender, EventArgs e)
        {
            ValidateInt(sender);
        }

        private void tsmi_use_label_num_Click(object sender, EventArgs e)
        {
            ChangeTool(0);
        }

        private void tsmi_use_label_text_Click(object sender, EventArgs e)
        {
            ChangeTool(1);
        }
    }
}