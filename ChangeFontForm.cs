using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokei_wform
{
    public partial class ChangeFontForm : Form
    {
        public ChangeFontForm(ClockFontData _arg)
        {
            InitializeComponent();

            if (_arg.foreColor != null)
            {
                this.pnl_FrontColor.BackColor = _arg.foreColor.Color;
            }
            this.pnl_BackColor.BackColor = _arg.backColor;
            this.trk_FontSize.Value = (int)(_arg.font.Size);

            this.curArg = _arg;
        }

        public ClockFontData curArg;


        private void RenderFont()
        {
            // 今の情報で文字を表示してみる
            this.tb_DispSample.ForeColor = this.curArg.foreColor.Color;
            this.tb_DispSample.Font = this.curArg.font;
            this.tb_DispSample.BackColor = this.curArg.backColor;
            this.Opacity = this.curArg.opacity;
            DateTime _d = DateTime.Now;
            this.tb_DispSample.Text = $"{_d.Year:D04}/{_d.Month:D02}/{_d.Day:D02}({System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(_d.DayOfWeek)}) {_d.Hour:D02}:{_d.Minute:D02}:{_d.Second:D02}";
        }

        private void ChangeFontForm_Load(object sender, EventArgs e)
        {
            // フォント種別を列挙する
            InstalledFontCollection _fc = new();
            float fsize = this.curArg.font.Size;
            int sameidx = -1;
            int curidx = 0;
            foreach (var _f in _fc.Families)
            {
                Font _i = new(_f.Name, fsize);
                if (_f.Name == this.curArg.font.Name)
                {
                    sameidx = curidx;
                }
                this.cb_FontType.Items.Add(_i);
                curidx++;
            }
            if (sameidx >= 0)
            {
                this.cb_FontType.SelectedIndex = sameidx;
            }

            this.RenderFont();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 戻る
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pnl_FrontColor_Click(object sender, EventArgs e)
        {
            // 文字色の変更
            ColorDialog dlg = new ColorDialog();
            dlg.Color = this.curArg.foreColor.Color;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.curArg.foreColor = new SolidBrush(dlg.Color);
                this.RenderFont();
            }
        }

        private void pnl_BackColor_Click(object sender, EventArgs e)
        {
            // 背景色の変更
            ColorDialog dlg = new ColorDialog();
            dlg.Color = this.curArg.backColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.curArg.backColor = dlg.Color;
                this.RenderFont();
            }
        }

        private void trk_FontSize_Scroll(object sender, EventArgs e)
        {
            // フォントサイズ変更
            this.curArg.FontSize = (float)this.trk_FontSize.Value;
            this.RenderFont();
        }

        private void cb_FontType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // フォント変更
            this.curArg.font = this.cb_FontType.SelectedItem as Font;
            this.curArg.FontSize = (float)this.trk_FontSize.Value;
            this.RenderFont();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 変更終了
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
