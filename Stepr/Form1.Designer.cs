
namespace Stepr
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
            this.ms_toolbar = new System.Windows.Forms.MenuStrip();
            this.tsmi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_clip = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_export = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_history = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_label_num = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_label_num = new System.Windows.Forms.ToolStripTextBox();
            this.tsmi_use_label_num = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_label_text = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_label_text = new System.Windows.Forms.ToolStripTextBox();
            this.tsmi_use_label_text = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_shapes = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_rect_outline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_rect_filled = new System.Windows.Forms.ToolStripMenuItem();
            this.circleoutlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_line = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_extra = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_blur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_heading_color_fore = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_color_fore = new System.Windows.Forms.ToolStripTextBox();
            this.tsmi_heading_color_back = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_color_back = new System.Windows.Forms.ToolStripTextBox();
            this.tss_sizes = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_heading_size_thick = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_size_thick = new System.Windows.Forms.ToolStripTextBox();
            this.tsmi_info_size_thick = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_heading_size_font = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_size_font = new System.Windows.Forms.ToolStripTextBox();
            this.tsmi_info_size_font = new System.Windows.Forms.ToolStripMenuItem();
            this.tss_reset = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_default = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_viewport = new System.Windows.Forms.Panel();
            this.pb_edit = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.ms_toolbar.SuspendLayout();
            this.pnl_viewport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_toolbar
            // 
            this.ms_toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_new,
            this.tsmi_tools,
            this.tsmi_settings});
            this.ms_toolbar.Location = new System.Drawing.Point(0, 0);
            this.ms_toolbar.Name = "ms_toolbar";
            this.ms_toolbar.Size = new System.Drawing.Size(1657, 28);
            this.ms_toolbar.TabIndex = 0;
            this.ms_toolbar.Text = "menuStrip1";
            // 
            // tsmi_new
            // 
            this.tsmi_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_clip,
            this.tss_export,
            this.tsmi_copy,
            this.tsmi_save,
            this.tss_history,
            this.tsmi_undo,
            this.tsmi_redo,
            this.tsmi_clear});
            this.tsmi_new.Name = "tsmi_new";
            this.tsmi_new.Size = new System.Drawing.Size(46, 24);
            this.tsmi_new.Text = "File";
            // 
            // tsmi_clip
            // 
            this.tsmi_clip.Name = "tsmi_clip";
            this.tsmi_clip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmi_clip.Size = new System.Drawing.Size(263, 26);
            this.tsmi_clip.Text = "Create clip";
            this.tsmi_clip.Click += new System.EventHandler(this.tsmi_clip_Click);
            // 
            // tss_export
            // 
            this.tss_export.Name = "tss_export";
            this.tss_export.Size = new System.Drawing.Size(260, 6);
            // 
            // tsmi_copy
            // 
            this.tsmi_copy.Name = "tsmi_copy";
            this.tsmi_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmi_copy.Size = new System.Drawing.Size(263, 26);
            this.tsmi_copy.Text = "Copy to clipboard";
            this.tsmi_copy.Click += new System.EventHandler(this.tsmi_copy_Click);
            // 
            // tsmi_save
            // 
            this.tsmi_save.Name = "tsmi_save";
            this.tsmi_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmi_save.Size = new System.Drawing.Size(263, 26);
            this.tsmi_save.Text = "Save to file";
            // 
            // tss_history
            // 
            this.tss_history.Name = "tss_history";
            this.tss_history.Size = new System.Drawing.Size(260, 6);
            // 
            // tsmi_undo
            // 
            this.tsmi_undo.Name = "tsmi_undo";
            this.tsmi_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmi_undo.Size = new System.Drawing.Size(263, 26);
            this.tsmi_undo.Text = "Undo";
            // 
            // tsmi_redo
            // 
            this.tsmi_redo.Name = "tsmi_redo";
            this.tsmi_redo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.tsmi_redo.Size = new System.Drawing.Size(263, 26);
            this.tsmi_redo.Text = "Redo";
            // 
            // tsmi_clear
            // 
            this.tsmi_clear.Name = "tsmi_clear";
            this.tsmi_clear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.tsmi_clear.Size = new System.Drawing.Size(263, 26);
            this.tsmi_clear.Text = "Clear all edits";
            this.tsmi_clear.Click += new System.EventHandler(this.tsmi_clear_Click);
            // 
            // tsmi_tools
            // 
            this.tsmi_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_label_num,
            this.tsmi_label_text,
            this.tss_shapes,
            this.tsmi_rect_outline,
            this.tsmi_rect_filled,
            this.circleoutlineToolStripMenuItem,
            this.tsmi_line,
            this.tss_extra,
            this.tsmi_blur});
            this.tsmi_tools.Name = "tsmi_tools";
            this.tsmi_tools.Size = new System.Drawing.Size(154, 24);
            this.tsmi_tools.Text = "Selected tool: None";
            // 
            // tsmi_label_num
            // 
            this.tsmi_label_num.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_label_num,
            this.tsmi_use_label_num});
            this.tsmi_label_num.Name = "tsmi_label_num";
            this.tsmi_label_num.Size = new System.Drawing.Size(269, 26);
            this.tsmi_label_num.Text = "Label [ # ]";
            // 
            // tstb_label_num
            // 
            this.tstb_label_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstb_label_num.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstb_label_num.Name = "tstb_label_num";
            this.tstb_label_num.Size = new System.Drawing.Size(50, 27);
            this.tstb_label_num.Text = "1";
            this.tstb_label_num.ToolTipText = "Next # on click";
            this.tstb_label_num.TextChanged += new System.EventHandler(this.tstb_label_num_TextChanged);
            // 
            // tsmi_use_label_num
            // 
            this.tsmi_use_label_num.Name = "tsmi_use_label_num";
            this.tsmi_use_label_num.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmi_use_label_num.Size = new System.Drawing.Size(224, 26);
            this.tsmi_use_label_num.Text = "Use tool";
            this.tsmi_use_label_num.Click += new System.EventHandler(this.tsmi_use_label_num_Click);
            // 
            // tsmi_label_text
            // 
            this.tsmi_label_text.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_label_text,
            this.tsmi_use_label_text});
            this.tsmi_label_text.Name = "tsmi_label_text";
            this.tsmi_label_text.Size = new System.Drawing.Size(269, 26);
            this.tsmi_label_text.Text = "Label [ T ]";
            // 
            // tstb_label_text
            // 
            this.tstb_label_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstb_label_text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstb_label_text.Name = "tstb_label_text";
            this.tstb_label_text.Size = new System.Drawing.Size(200, 27);
            this.tstb_label_text.Text = "Your text here";
            this.tstb_label_text.ToolTipText = "Text of the label added on click";
            // 
            // tsmi_use_label_text
            // 
            this.tsmi_use_label_text.Name = "tsmi_use_label_text";
            this.tsmi_use_label_text.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsmi_use_label_text.Size = new System.Drawing.Size(274, 26);
            this.tsmi_use_label_text.Text = "Use tool";
            this.tsmi_use_label_text.Click += new System.EventHandler(this.tsmi_use_label_text_Click);
            // 
            // tss_shapes
            // 
            this.tss_shapes.Name = "tss_shapes";
            this.tss_shapes.Size = new System.Drawing.Size(266, 6);
            // 
            // tsmi_rect_outline
            // 
            this.tsmi_rect_outline.Name = "tsmi_rect_outline";
            this.tsmi_rect_outline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmi_rect_outline.Size = new System.Drawing.Size(269, 26);
            this.tsmi_rect_outline.Text = "Rectangle (outline)";
            this.tsmi_rect_outline.Click += new System.EventHandler(this.tsmi_rect_outline_Click);
            // 
            // tsmi_rect_filled
            // 
            this.tsmi_rect_filled.Name = "tsmi_rect_filled";
            this.tsmi_rect_filled.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmi_rect_filled.Size = new System.Drawing.Size(269, 26);
            this.tsmi_rect_filled.Text = "Rectangle (filled)";
            this.tsmi_rect_filled.Click += new System.EventHandler(this.tsmi_rect_filled_Click);
            // 
            // circleoutlineToolStripMenuItem
            // 
            this.circleoutlineToolStripMenuItem.Name = "circleoutlineToolStripMenuItem";
            this.circleoutlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.circleoutlineToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.circleoutlineToolStripMenuItem.Text = "Circle (outline)";
            this.circleoutlineToolStripMenuItem.Click += new System.EventHandler(this.circleoutlineToolStripMenuItem_Click);
            // 
            // tsmi_line
            // 
            this.tsmi_line.Name = "tsmi_line";
            this.tsmi_line.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmi_line.Size = new System.Drawing.Size(269, 26);
            this.tsmi_line.Text = "Line";
            this.tsmi_line.Click += new System.EventHandler(this.tsmi_line_Click);
            // 
            // tss_extra
            // 
            this.tss_extra.Name = "tss_extra";
            this.tss_extra.Size = new System.Drawing.Size(266, 6);
            // 
            // tsmi_blur
            // 
            this.tsmi_blur.Name = "tsmi_blur";
            this.tsmi_blur.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsmi_blur.Size = new System.Drawing.Size(269, 26);
            this.tsmi_blur.Text = "Blur (censor)";
            this.tsmi_blur.Click += new System.EventHandler(this.tsmi_blur_Click);
            // 
            // tsmi_settings
            // 
            this.tsmi_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_heading_color_fore,
            this.tsmi_heading_color_back,
            this.tss_sizes,
            this.tsmi_heading_size_thick,
            this.tsmi_heading_size_font,
            this.tss_reset,
            this.tsmi_default});
            this.tsmi_settings.Name = "tsmi_settings";
            this.tsmi_settings.Size = new System.Drawing.Size(76, 24);
            this.tsmi_settings.Text = "Settings";
            // 
            // tsmi_heading_color_fore
            // 
            this.tsmi_heading_color_fore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_color_fore});
            this.tsmi_heading_color_fore.Name = "tsmi_heading_color_fore";
            this.tsmi_heading_color_fore.Size = new System.Drawing.Size(249, 26);
            this.tsmi_heading_color_fore.Text = "Color (foreground)";
            // 
            // tstb_color_fore
            // 
            this.tstb_color_fore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstb_color_fore.Name = "tstb_color_fore";
            this.tstb_color_fore.Size = new System.Drawing.Size(100, 27);
            this.tstb_color_fore.Text = "#FFFFFF";
            this.tstb_color_fore.ToolTipText = "Only use hex values including #";
            this.tstb_color_fore.TextChanged += new System.EventHandler(this.tstb_color_fore_TextChanged);
            // 
            // tsmi_heading_color_back
            // 
            this.tsmi_heading_color_back.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_color_back});
            this.tsmi_heading_color_back.Name = "tsmi_heading_color_back";
            this.tsmi_heading_color_back.Size = new System.Drawing.Size(249, 26);
            this.tsmi_heading_color_back.Text = "Color (background)";
            // 
            // tstb_color_back
            // 
            this.tstb_color_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstb_color_back.Name = "tstb_color_back";
            this.tstb_color_back.Size = new System.Drawing.Size(100, 27);
            this.tstb_color_back.Text = "#FF0000";
            this.tstb_color_back.ToolTipText = "Only use hex values including #";
            this.tstb_color_back.TextChanged += new System.EventHandler(this.tstb_color_back_TextChanged);
            // 
            // tss_sizes
            // 
            this.tss_sizes.Name = "tss_sizes";
            this.tss_sizes.Size = new System.Drawing.Size(246, 6);
            // 
            // tsmi_heading_size_thick
            // 
            this.tsmi_heading_size_thick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_size_thick,
            this.tsmi_info_size_thick});
            this.tsmi_heading_size_thick.Name = "tsmi_heading_size_thick";
            this.tsmi_heading_size_thick.Size = new System.Drawing.Size(249, 26);
            this.tsmi_heading_size_thick.Text = "Size (thickness)";
            // 
            // tstb_size_thick
            // 
            this.tstb_size_thick.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstb_size_thick.Name = "tstb_size_thick";
            this.tstb_size_thick.Size = new System.Drawing.Size(100, 27);
            this.tstb_size_thick.Text = "2";
            this.tstb_size_thick.ToolTipText = "Only allows whole numbers";
            this.tstb_size_thick.TextChanged += new System.EventHandler(this.tstb_size_thick_TextChanged);
            // 
            // tsmi_info_size_thick
            // 
            this.tsmi_info_size_thick.Name = "tsmi_info_size_thick";
            this.tsmi_info_size_thick.Size = new System.Drawing.Size(224, 26);
            this.tsmi_info_size_thick.Text = "(px)";
            // 
            // tsmi_heading_size_font
            // 
            this.tsmi_heading_size_font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstb_size_font,
            this.tsmi_info_size_font});
            this.tsmi_heading_size_font.Name = "tsmi_heading_size_font";
            this.tsmi_heading_size_font.Size = new System.Drawing.Size(249, 26);
            this.tsmi_heading_size_font.Text = "Size (font)";
            // 
            // tstb_size_font
            // 
            this.tstb_size_font.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstb_size_font.Name = "tstb_size_font";
            this.tstb_size_font.Size = new System.Drawing.Size(100, 27);
            this.tstb_size_font.Text = "12";
            this.tstb_size_font.ToolTipText = "Only allows whole numbers";
            this.tstb_size_font.TextChanged += new System.EventHandler(this.tstb_size_font_TextChanged);
            // 
            // tsmi_info_size_font
            // 
            this.tsmi_info_size_font.Name = "tsmi_info_size_font";
            this.tsmi_info_size_font.Size = new System.Drawing.Size(224, 26);
            this.tsmi_info_size_font.Text = "(px)";
            // 
            // tss_reset
            // 
            this.tss_reset.Name = "tss_reset";
            this.tss_reset.Size = new System.Drawing.Size(246, 6);
            // 
            // tsmi_default
            // 
            this.tsmi_default.Name = "tsmi_default";
            this.tsmi_default.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmi_default.Size = new System.Drawing.Size(249, 26);
            this.tsmi_default.Text = "Default settings";
            this.tsmi_default.Click += new System.EventHandler(this.tsmi_default_Click);
            // 
            // pnl_viewport
            // 
            this.pnl_viewport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_viewport.AutoScroll = true;
            this.pnl_viewport.Controls.Add(this.pb_edit);
            this.pnl_viewport.Controls.Add(this.lbl_info);
            this.pnl_viewport.Location = new System.Drawing.Point(16, 33);
            this.pnl_viewport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_viewport.Name = "pnl_viewport";
            this.pnl_viewport.Size = new System.Drawing.Size(1625, 871);
            this.pnl_viewport.TabIndex = 1;
            // 
            // pb_edit
            // 
            this.pb_edit.BackColor = System.Drawing.Color.Transparent;
            this.pb_edit.Location = new System.Drawing.Point(0, 0);
            this.pb_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_edit.Name = "pb_edit";
            this.pb_edit.Size = new System.Drawing.Size(1, 1);
            this.pb_edit.TabIndex = 0;
            this.pb_edit.TabStop = false;
            this.pb_edit.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_edit_Paint);
            this.pb_edit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_edit_MouseClick);
            this.pb_edit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_edit_MouseDown);
            this.pb_edit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_edit_MouseMove);
            this.pb_edit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_edit_MouseUp);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(16, 15);
            this.lbl_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(738, 17);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "Start by making a new clip (Ctrl+N) - Make sure your cursor is on the same monito" +
    "r as where you\'re trying to capture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 919);
            this.Controls.Add(this.pnl_viewport);
            this.Controls.Add(this.ms_toolbar);
            this.MainMenuStrip = this.ms_toolbar;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Stepr - Advanced Screenshots";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ms_toolbar.ResumeLayout(false);
            this.ms_toolbar.PerformLayout();
            this.pnl_viewport.ResumeLayout(false);
            this.pnl_viewport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_toolbar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_clip;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools;
        private System.Windows.Forms.ToolStripMenuItem tsmi_label_num;
        private System.Windows.Forms.ToolStripMenuItem tsmi_label_text;
        private System.Windows.Forms.ToolStripMenuItem tsmi_rect_outline;
        private System.Windows.Forms.ToolStripMenuItem tsmi_rect_filled;
        private System.Windows.Forms.ToolStripMenuItem circleoutlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_line;
        private System.Windows.Forms.ToolStripMenuItem tsmi_blur;
        private System.Windows.Forms.ToolStripMenuItem tsmi_settings;
        private System.Windows.Forms.ToolStripSeparator tss_shapes;
        private System.Windows.Forms.ToolStripSeparator tss_extra;
        private System.Windows.Forms.ToolStripMenuItem tsmi_heading_color_fore;
        private System.Windows.Forms.ToolStripMenuItem tsmi_heading_color_back;
        private System.Windows.Forms.ToolStripSeparator tss_sizes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_heading_size_thick;
        private System.Windows.Forms.ToolStripMenuItem tsmi_heading_size_font;
        private System.Windows.Forms.ToolStripSeparator tss_reset;
        private System.Windows.Forms.ToolStripMenuItem tsmi_default;
        private System.Windows.Forms.ToolStripTextBox tstb_color_fore;
        private System.Windows.Forms.ToolStripTextBox tstb_color_back;
        private System.Windows.Forms.ToolStripTextBox tstb_size_thick;
        private System.Windows.Forms.ToolStripTextBox tstb_size_font;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copy;
        private System.Windows.Forms.ToolStripMenuItem tsmi_save;
        private System.Windows.Forms.ToolStripMenuItem tsmi_info_size_thick;
        private System.Windows.Forms.ToolStripMenuItem tsmi_info_size_font;
        private System.Windows.Forms.ToolStripSeparator tss_history;
        private System.Windows.Forms.ToolStripMenuItem tsmi_undo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_redo;
        private System.Windows.Forms.ToolStripSeparator tss_export;
        private System.Windows.Forms.Panel pnl_viewport;
        private System.Windows.Forms.PictureBox pb_edit;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ToolStripMenuItem tsmi_clear;
        private System.Windows.Forms.ToolStripTextBox tstb_label_num;
        private System.Windows.Forms.ToolStripTextBox tstb_label_text;
        private System.Windows.Forms.ToolStripMenuItem tsmi_use_label_num;
        private System.Windows.Forms.ToolStripMenuItem tsmi_use_label_text;
    }
}

