namespace tokei_wform
{
    partial class ChangeFontForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_FontType = new Label();
            lbl_FontSize = new Label();
            lbl_FontColor = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnOK = new Button();
            btnCancel = new Button();
            lbl_FontSample = new Label();
            tb_DispSample = new TextBox();
            cb_FontType = new ComboBox();
            lbl_opacity = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lbl_OpacityValue = new Label();
            trk_Opacity = new TrackBar();
            tableLayoutPanel4 = new TableLayoutPanel();
            trk_FontSize = new TrackBar();
            lbl_FontSizeValue = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            lbl_FrontColor = new Label();
            lbl_BackColor = new Label();
            pnl_FrontColor = new Panel();
            pnl_BackColor = new Panel();
            lbl_FontRenderQ = new Label();
            cb_FontQuality = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trk_Opacity).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trk_FontSize).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(lbl_FontType, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_FontSize, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_FontColor, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 6);
            tableLayoutPanel1.Controls.Add(lbl_FontSample, 0, 5);
            tableLayoutPanel1.Controls.Add(tb_DispSample, 1, 5);
            tableLayoutPanel1.Controls.Add(cb_FontType, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_opacity, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_FontRenderQ, 0, 2);
            tableLayoutPanel1.Controls.Add(cb_FontQuality, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(706, 404);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_FontType
            // 
            lbl_FontType.Anchor = AnchorStyles.Right;
            lbl_FontType.AutoSize = true;
            lbl_FontType.Location = new Point(74, 12);
            lbl_FontType.Name = "lbl_FontType";
            lbl_FontType.Size = new Size(64, 15);
            lbl_FontType.TabIndex = 0;
            lbl_FontType.Text = "フォント種別";
            // 
            // lbl_FontSize
            // 
            lbl_FontSize.Anchor = AnchorStyles.Right;
            lbl_FontSize.AutoSize = true;
            lbl_FontSize.Location = new Point(70, 52);
            lbl_FontSize.Name = "lbl_FontSize";
            lbl_FontSize.Size = new Size(68, 15);
            lbl_FontSize.TabIndex = 1;
            lbl_FontSize.Text = "フォントサイズ";
            // 
            // lbl_FontColor
            // 
            lbl_FontColor.Anchor = AnchorStyles.Right;
            lbl_FontColor.AutoSize = true;
            lbl_FontColor.Location = new Point(73, 132);
            lbl_FontColor.Name = "lbl_FontColor";
            lbl_FontColor.Size = new Size(65, 15);
            lbl_FontColor.TabIndex = 2;
            lbl_FontColor.Text = "フォントカラー";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(btnOK, 1, 0);
            tableLayoutPanel2.Controls.Add(btnCancel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 367);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(700, 34);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Dock = DockStyle.Fill;
            btnOK.Location = new Point(563, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(64, 28);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(633, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(64, 28);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbl_FontSample
            // 
            lbl_FontSample.Anchor = AnchorStyles.Right;
            lbl_FontSample.AutoSize = true;
            lbl_FontSample.Location = new Point(70, 274);
            lbl_FontSample.Name = "lbl_FontSample";
            lbl_FontSample.Size = new Size(68, 15);
            lbl_FontSample.TabIndex = 4;
            lbl_FontSample.Text = "表示サンプル";
            // 
            // tb_DispSample
            // 
            tb_DispSample.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_DispSample.Location = new Point(144, 270);
            tb_DispSample.Name = "tb_DispSample";
            tb_DispSample.Size = new Size(559, 23);
            tb_DispSample.TabIndex = 5;
            // 
            // cb_FontType
            // 
            cb_FontType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_FontType.FormattingEnabled = true;
            cb_FontType.Location = new Point(144, 8);
            cb_FontType.Name = "cb_FontType";
            cb_FontType.Size = new Size(559, 23);
            cb_FontType.TabIndex = 6;
            cb_FontType.SelectedIndexChanged += cb_FontType_SelectedIndexChanged;
            // 
            // lbl_opacity
            // 
            lbl_opacity.Anchor = AnchorStyles.Right;
            lbl_opacity.AutoSize = true;
            lbl_opacity.Location = new Point(95, 172);
            lbl_opacity.Name = "lbl_opacity";
            lbl_opacity.Size = new Size(43, 15);
            lbl_opacity.TabIndex = 8;
            lbl_opacity.Text = "透過率";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.Controls.Add(lbl_OpacityValue, 0, 0);
            tableLayoutPanel3.Controls.Add(trk_Opacity, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(144, 163);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(559, 34);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // lbl_OpacityValue
            // 
            lbl_OpacityValue.Anchor = AnchorStyles.Right;
            lbl_OpacityValue.AutoSize = true;
            lbl_OpacityValue.Location = new Point(29, 9);
            lbl_OpacityValue.Name = "lbl_OpacityValue";
            lbl_OpacityValue.Size = new Size(23, 15);
            lbl_OpacityValue.TabIndex = 0;
            lbl_OpacityValue.Text = "0%";
            // 
            // trk_Opacity
            // 
            trk_Opacity.Dock = DockStyle.Fill;
            trk_Opacity.Location = new Point(58, 3);
            trk_Opacity.Maximum = 100;
            trk_Opacity.Minimum = 1;
            trk_Opacity.Name = "trk_Opacity";
            trk_Opacity.Size = new Size(498, 28);
            trk_Opacity.TabIndex = 1;
            trk_Opacity.TickFrequency = 10;
            trk_Opacity.Value = 1;
            trk_Opacity.Scroll += trk_Opacity_Scroll;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.Controls.Add(trk_FontSize, 1, 0);
            tableLayoutPanel4.Controls.Add(lbl_FontSizeValue, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(144, 43);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(559, 34);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // trk_FontSize
            // 
            trk_FontSize.Dock = DockStyle.Fill;
            trk_FontSize.LargeChange = 8;
            trk_FontSize.Location = new Point(58, 3);
            trk_FontSize.Maximum = 256;
            trk_FontSize.Minimum = 1;
            trk_FontSize.Name = "trk_FontSize";
            trk_FontSize.Size = new Size(498, 28);
            trk_FontSize.TabIndex = 0;
            trk_FontSize.TickFrequency = 16;
            trk_FontSize.Value = 1;
            trk_FontSize.Scroll += trk_FontSize_Scroll;
            // 
            // lbl_FontSizeValue
            // 
            lbl_FontSizeValue.Anchor = AnchorStyles.Right;
            lbl_FontSizeValue.AutoSize = true;
            lbl_FontSizeValue.Location = new Point(23, 9);
            lbl_FontSizeValue.Name = "lbl_FontSizeValue";
            lbl_FontSizeValue.Size = new Size(29, 15);
            lbl_FontSizeValue.TabIndex = 1;
            lbl_FontSizeValue.Text = "1em";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.Controls.Add(lbl_BackColor, 2, 0);
            tableLayoutPanel5.Controls.Add(pnl_FrontColor, 1, 0);
            tableLayoutPanel5.Controls.Add(pnl_BackColor, 3, 0);
            tableLayoutPanel5.Controls.Add(lbl_FrontColor, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(144, 123);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(559, 34);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // lbl_FrontColor
            // 
            lbl_FrontColor.Anchor = AnchorStyles.Right;
            lbl_FrontColor.AutoSize = true;
            lbl_FrontColor.Location = new Point(21, 9);
            lbl_FrontColor.Name = "lbl_FrontColor";
            lbl_FrontColor.Size = new Size(31, 15);
            lbl_FrontColor.TabIndex = 0;
            lbl_FrontColor.Text = "文字";
            // 
            // lbl_BackColor
            // 
            lbl_BackColor.Anchor = AnchorStyles.Right;
            lbl_BackColor.AutoSize = true;
            lbl_BackColor.Location = new Point(299, 9);
            lbl_BackColor.Name = "lbl_BackColor";
            lbl_BackColor.Size = new Size(31, 15);
            lbl_BackColor.TabIndex = 1;
            lbl_BackColor.Text = "背景";
            // 
            // pnl_FrontColor
            // 
            pnl_FrontColor.BorderStyle = BorderStyle.Fixed3D;
            pnl_FrontColor.Dock = DockStyle.Fill;
            pnl_FrontColor.Location = new Point(58, 3);
            pnl_FrontColor.Name = "pnl_FrontColor";
            pnl_FrontColor.Size = new Size(217, 28);
            pnl_FrontColor.TabIndex = 2;
            pnl_FrontColor.Click += pnl_FrontColor_Click;
            // 
            // pnl_BackColor
            // 
            pnl_BackColor.BorderStyle = BorderStyle.Fixed3D;
            pnl_BackColor.Dock = DockStyle.Fill;
            pnl_BackColor.Location = new Point(336, 3);
            pnl_BackColor.Name = "pnl_BackColor";
            pnl_BackColor.Size = new Size(220, 28);
            pnl_BackColor.TabIndex = 3;
            pnl_BackColor.Click += pnl_BackColor_Click;
            // 
            // lbl_FontRenderQ
            // 
            lbl_FontRenderQ.Anchor = AnchorStyles.Right;
            lbl_FontRenderQ.AutoSize = true;
            lbl_FontRenderQ.Location = new Point(54, 92);
            lbl_FontRenderQ.Name = "lbl_FontRenderQ";
            lbl_FontRenderQ.Size = new Size(84, 15);
            lbl_FontRenderQ.TabIndex = 12;
            lbl_FontRenderQ.Text = "レンダリング品質";
            // 
            // cb_FontQuality
            // 
            cb_FontQuality.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_FontQuality.FormattingEnabled = true;
            cb_FontQuality.Location = new Point(144, 88);
            cb_FontQuality.Name = "cb_FontQuality";
            cb_FontQuality.Size = new Size(559, 23);
            cb_FontQuality.TabIndex = 13;
            cb_FontQuality.SelectedIndexChanged += cb_FontQuality_SelectedIndexChanged;
            // 
            // ChangeFontForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 404);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ChangeFontForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "change dialog";
            Load += ChangeFontForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trk_Opacity).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trk_FontSize).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_FontType;
        private Label lbl_FontSize;
        private Label lbl_FontColor;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbl_FontSample;
        private Button btnOK;
        private Button btnCancel;
        private TextBox tb_DispSample;
        private ComboBox cb_FontType;
        private Label lbl_opacity;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbl_OpacityValue;
        private TrackBar trk_Opacity;
        private TableLayoutPanel tableLayoutPanel4;
        private TrackBar trk_FontSize;
        private Label lbl_FontSizeValue;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lbl_FrontColor;
        private Label lbl_BackColor;
        private Panel pnl_FrontColor;
        private Panel pnl_BackColor;
        private Label lbl_FontRenderQ;
        private ComboBox cb_FontQuality;
    }
}