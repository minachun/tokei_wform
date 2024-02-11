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
            trk_FontSize = new TrackBar();
            tableLayoutPanel3 = new TableLayoutPanel();
            lbl_Front = new Label();
            lbl_Back = new Label();
            pnl_FrontColor = new Panel();
            pnl_BackColor = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trk_FontSize).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(lbl_FontType, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_FontSize, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_FontColor, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutPanel1.Controls.Add(lbl_FontSample, 0, 3);
            tableLayoutPanel1.Controls.Add(tb_DispSample, 1, 3);
            tableLayoutPanel1.Controls.Add(cb_FontType, 1, 0);
            tableLayoutPanel1.Controls.Add(trk_FontSize, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(675, 275);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_FontType
            // 
            lbl_FontType.Anchor = AnchorStyles.Right;
            lbl_FontType.AutoSize = true;
            lbl_FontType.Location = new Point(68, 12);
            lbl_FontType.Name = "lbl_FontType";
            lbl_FontType.Size = new Size(64, 15);
            lbl_FontType.TabIndex = 0;
            lbl_FontType.Text = "フォント種別";
            // 
            // lbl_FontSize
            // 
            lbl_FontSize.Anchor = AnchorStyles.Right;
            lbl_FontSize.AutoSize = true;
            lbl_FontSize.Location = new Point(64, 52);
            lbl_FontSize.Name = "lbl_FontSize";
            lbl_FontSize.Size = new Size(68, 15);
            lbl_FontSize.TabIndex = 1;
            lbl_FontSize.Text = "フォントサイズ";
            // 
            // lbl_FontColor
            // 
            lbl_FontColor.Anchor = AnchorStyles.Right;
            lbl_FontColor.AutoSize = true;
            lbl_FontColor.Location = new Point(67, 92);
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
            tableLayoutPanel2.Location = new Point(3, 238);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(669, 34);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Dock = DockStyle.Fill;
            btnOK.Location = new Point(538, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(60, 28);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(604, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(62, 28);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "キャンセル";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbl_FontSample
            // 
            lbl_FontSample.Anchor = AnchorStyles.Right;
            lbl_FontSample.AutoSize = true;
            lbl_FontSample.Location = new Point(64, 170);
            lbl_FontSample.Name = "lbl_FontSample";
            lbl_FontSample.Size = new Size(68, 15);
            lbl_FontSample.TabIndex = 4;
            lbl_FontSample.Text = "表示サンプル";
            // 
            // tb_DispSample
            // 
            tb_DispSample.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_DispSample.Location = new Point(138, 166);
            tb_DispSample.Name = "tb_DispSample";
            tb_DispSample.Size = new Size(534, 23);
            tb_DispSample.TabIndex = 5;
            // 
            // cb_FontType
            // 
            cb_FontType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_FontType.FormattingEnabled = true;
            cb_FontType.Location = new Point(138, 8);
            cb_FontType.Name = "cb_FontType";
            cb_FontType.Size = new Size(534, 23);
            cb_FontType.TabIndex = 6;
            cb_FontType.SelectedIndexChanged += cb_FontType_SelectedIndexChanged;
            // 
            // trk_FontSize
            // 
            trk_FontSize.Dock = DockStyle.Fill;
            trk_FontSize.LargeChange = 3;
            trk_FontSize.Location = new Point(138, 43);
            trk_FontSize.Maximum = 256;
            trk_FontSize.Minimum = 1;
            trk_FontSize.Name = "trk_FontSize";
            trk_FontSize.Size = new Size(534, 34);
            trk_FontSize.TabIndex = 7;
            trk_FontSize.TickFrequency = 8;
            trk_FontSize.Value = 1;
            trk_FontSize.Scroll += trk_FontSize_Scroll;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(lbl_Front, 0, 0);
            tableLayoutPanel3.Controls.Add(lbl_Back, 2, 0);
            tableLayoutPanel3.Controls.Add(pnl_FrontColor, 1, 0);
            tableLayoutPanel3.Controls.Add(pnl_BackColor, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(138, 83);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(534, 34);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // lbl_Front
            // 
            lbl_Front.Anchor = AnchorStyles.Right;
            lbl_Front.AutoSize = true;
            lbl_Front.Location = new Point(19, 9);
            lbl_Front.Name = "lbl_Front";
            lbl_Front.Size = new Size(31, 15);
            lbl_Front.TabIndex = 0;
            lbl_Front.Text = "文字";
            // 
            // lbl_Back
            // 
            lbl_Back.Anchor = AnchorStyles.Right;
            lbl_Back.AutoSize = true;
            lbl_Back.Location = new Point(285, 9);
            lbl_Back.Name = "lbl_Back";
            lbl_Back.Size = new Size(31, 15);
            lbl_Back.TabIndex = 1;
            lbl_Back.Text = "背景";
            // 
            // pnl_FrontColor
            // 
            pnl_FrontColor.Dock = DockStyle.Fill;
            pnl_FrontColor.Location = new Point(56, 3);
            pnl_FrontColor.Name = "pnl_FrontColor";
            pnl_FrontColor.Size = new Size(207, 28);
            pnl_FrontColor.TabIndex = 2;
            pnl_FrontColor.Click += pnl_FrontColor_Click;
            // 
            // pnl_BackColor
            // 
            pnl_BackColor.Dock = DockStyle.Fill;
            pnl_BackColor.Location = new Point(322, 3);
            pnl_BackColor.Name = "pnl_BackColor";
            pnl_BackColor.Size = new Size(209, 28);
            pnl_BackColor.TabIndex = 3;
            pnl_BackColor.Click += pnl_BackColor_Click;
            // 
            // ChangeFontForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 275);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ChangeFontForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangeFontForm";
            Load += ChangeFontForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trk_FontSize).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private TrackBar trk_FontSize;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbl_Front;
        private Label lbl_Back;
        private Panel pnl_FrontColor;
        private Panel pnl_BackColor;
    }
}