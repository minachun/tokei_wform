using System.DirectoryServices;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace tokei_wform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.clockCountCancel = null;
            this.clockCountTask = null;
            this.ClockString = "";
            InitializeComponent();

            this.currentOffset = null;
        }

        private Dictionary<Guid, string> config_files = new Dictionary<Guid, string>();
        private static string config_filename = "tokeiconfig.config";

        private bool ReadConfigFile()
        {
            // 設定ファイルの読み込み
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(Form1.config_filename);

                string _all = sr.ReadToEnd();

                // 設定ファイルを仮想デスクトップID別に取得
                string[] desktop = _all.Split("----");
                foreach (string d in desktop)
                {
                    string[] _dd = d.Split(System.Environment.NewLine, 2);
                    if (_dd.Length != 2) continue;

                    // 最初がデスクトップID
                    string[] _ddd = _dd[0].Split(new char[] { ':' });
                    if (_ddd.Length != 2) continue;
                    if (_ddd[0].Trim() != "desktopid") continue;

                    this.config_files.Add(Guid.Parse(_ddd[1].Trim()), _dd[1].Trim());
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
            if ( config_files.Count == 0 ) return false;
            return true;
        }

        private void WriteConfigFile()
        {
            // 設定ファイルの書き出し
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(Form1.config_filename);

                List<string> _c = new List<string>();

                if ( this.config_files.Count > 0 )
                {
                    foreach (var _k in this.config_files)
                    {
                        _c.Add($"desktopid:{_k.Key.ToString()}" + System.Environment.NewLine + _k.Value);
                    }
                }

                sw.Write(string.Join("----", _c.ToArray()));
                sw.Close();
            }
            catch
            {
                // 何もしない
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        private Task? clockCountTask;
        private CancellationTokenSource? clockCountCancel;

        private void Form1_Load(object sender, EventArgs e)
        {
            // アプリケーションロード完了

            // 時刻カウントタスクの起動
            this.clockCountCancel = new CancellationTokenSource();
            IntPtr _h = this.Handle;
            this.clockCountTask = Task.Factory.StartNew(() =>
            {
                // 設定ファイルの読み込み
                if (this.ReadConfigFile())
                {
                    // 自分自身の仮想デスクトップIDを取得
                    var my_guid = VirtualDesktopManager.DesktopManager.GetWindowDesktopId(_h);

                    if (this.config_files.ContainsKey(my_guid))
                    {
                        // 見つけたので採用
                        try
                        {
                            this.clockData = new ClockFontData(this.config_files[my_guid]);
                        }
                        catch
                        {
                            this.clockData = null;
                        }
                    }
                }
                if (this.clockData == null)
                {
                    // デフォルトで
                    this.clockData = new ClockFontData(new Font(this.Font.Name, 32.0f), new SolidBrush(this.ForeColor), this.BackColor, this.Opacity / 1.2, new PointF(1, 1));
                }

                this.ClockCount();
            });

        }

        // 描画文字列
        private string ClockString;
        private ClockFontData? clockData = null;


        // 描画イベント
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(this.ClockString) == false)
            {
                // 描画
                lock (this.ClockString)
                {
                    e.Graphics.DrawString(this.ClockString, this.clockData.font, this.clockData.foreColor, this.clockData.padding);
                }
            }
        }


        private void DispClock(DateTime _d)
        {
            // 時刻の描画

            lock (this.ClockString)
            {
                this.ClockString = $"{_d.Year:D04}/{_d.Month:D02}/{_d.Day:D02}({System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(_d.DayOfWeek)}) {_d.Hour:D02}:{_d.Minute:D02}:{_d.Second:D02}";

                Graphics _g = this.CreateGraphics();

                SizeF _s = _g.MeasureString(this.ClockString, this.clockData.font);

                // パディング分確保してみる
                this.ClientSize = new Size((int)(_s.Width + this.clockData.padding.X * 2), (int)(_s.Height + this.clockData.padding.Y * 2));

                _g.Dispose();

                this.BackColor = this.clockData.backColor;
                this.Opacity = this.clockData.opacity;
            }

            // 再描画要求
            this.Invalidate();
        }

        private void ClockCount()
        {
            if (this.clockCountCancel == null) { return; }
            CancellationToken _t = this.clockCountCancel.Token;
            IAsyncResult? ar = null;
            DateTime? cur_dt = null;

            if (_t.IsCancellationRequested == false)
            {
                // 前処理：まずは一発目の表示
                cur_dt = DateTime.Now;
                ar = this.BeginInvoke(new Action(() =>
                {
                    this.DispClock(cur_dt ?? DateTime.Now);
                }));
            }

            while (_t.IsCancellationRequested == false)
            {
                // 時間が経つまで待つ
                DateTime _c = DateTime.Now;

                //　”秒”が変わるまで待つ
                if (_c.Second == cur_dt?.Second)
                {
                    if (_c.Millisecond < 900)
                    {
                        Thread.Sleep(50);
                    }
                    else
                    {
                        Thread.Sleep(1);
                    }
                    continue;
                }

                // 前の処理が終わるまで待つ
                if (ar == null) break;
                this.EndInvoke(ar);

                // 次の処理
                if (_t.IsCancellationRequested) break;
                cur_dt = _c;
                ar = this.BeginInvoke(new Action(() =>
                {
                    this.DispClock(_c);
                }));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 閉じる前処理
            this.clockCountCancel?.Cancel();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 閉じる後処理
            while (this.clockCountTask?.Wait(1) == false)
            {
                Application.DoEvents();
            }
        }


        private Point? currentOffset;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Left)
            {
                // ウィンドウ移動モード開始
                // この時点でのマウスカーソルとウィンドウのtop/leftの差分を記憶
                // つーても、そもそも e.Location が差分らしいのでそれで。
                this.currentOffset = e.Location;

            } else if ( e.Button == MouseButtons.Right )
            {
                // メニュー出す（フォント変更・終了）
                ContextMenuStrip _m = new ContextMenuStrip();
                ToolStripLabel _i_fontchange = new ToolStripLabel();
                _i_fontchange.Text = $"フォントを変更";
                _i_fontchange.Click += (sender, e) =>
                {
                    // クリックされたのでフォント変更ダイアログを出す
                    ChangeFontForm _fm = new ChangeFontForm(this.clockData.DeepCopy());
                    if ( _fm.ShowDialog() == DialogResult.OK )
                    {
                        this.clockData = _fm.curArg;
                    }
                };
                _m.Items.Add(_i_fontchange);
                // 設定ファイルを書き出す
                ToolStripLabel _i_config = new ToolStripLabel();
                _i_config.Text = $"設定を保存";
                _i_config.Click += (sender, _e) =>
                {
                    // クリックされたので設定ファイルを更新する

                    // 設定ファイルを再度読み込む
                    this.config_files.Clear();

                    // 自分自身の仮想デスクトップIDを取得
                    var my_guid = VirtualDesktopManager.DesktopManager.GetWindowDesktopId(this.Handle);

                    this.ReadConfigFile();
                    // 設定を反映 or 上書き or 新規反映
                    this.config_files[my_guid] = this.clockData != null ? this.clockData.ToConfig() : "";

                    // ファイルに書き出し
                    this.WriteConfigFile();
                };
                _m.Items.Add(_i_config);
                _m.Items.Add(new ToolStripSeparator());
                ToolStripLabel _i_exit = new ToolStripLabel();
                _i_exit.Text = $"終了";
                _i_exit.Click += (sender, e) => {
                    // アプリ終了
                    Application.Exit();
                };
                _m.Items.Add(_i_exit);

                _m.Show(this, e.Location);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if ( e.Button == MouseButtons.Left && this.currentOffset != null )
            {
                // ウィンドウ移動モード終了
                this.currentOffset = null;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // ウィンドウ移動モードなら追従して移動する
            if (this.currentOffset != null)
            {
                Point _app = this.Location;
                this.Location = new Point(_app.X + e.Location.X - this.currentOffset.Value.X, _app.Y + e.Location.Y - this.currentOffset.Value.Y);
            }
        }
    }


    public class ClockFontData
    {
        public Font? font;
        public SolidBrush? foreColor;
        public Color backColor;
        public double opacity;
        // 描画パディング（上と左のみ：下は上と同じ、右は左と同じ
        public PointF padding;

        public ClockFontData(Font _f, SolidBrush _fb, Color _bc, double _o, PointF clockPadding)
        {
            this.font = _f;
            this.foreColor = _fb;
            this.backColor = _bc;
            this.opacity = _o;
            this.padding = clockPadding;
        }

        public float FontSize
        {
            get
            {
                return font.Size;
            }
            set
            {
                Font _f = new Font(this.font.Name, value);
                this.font = _f;
            }
        }

        public ClockFontData DeepCopy()
        {
            var _d = new ClockFontData(this.font, this.foreColor, this.backColor, this.opacity, this.padding);

            return _d;
        }

        public string ToConfig()
        {
            // コンフィグ文字列へ変換
            List<string> _c = new List<string>();

            _c.Add($"font: {this.font.Name}, {this.font.Size}");
            _c.Add($"color: {this.foreColor.Color.ToArgb()}, {this.backColor.ToArgb()}");
            _c.Add($"padding: {this.padding.X}, {this.padding.Y}");
            _c.Add($"opacity: {this.opacity}");

            return string.Join(System.Environment.NewLine, _c);
        }


        public ClockFontData(string config)
        {
            // コンフィグ文字列から変換
            string[] _t = config.Split(System.Environment.NewLine);
            Font _cf = null;
            SolidBrush _cfb = null;
            Color _cbc = Color.Black;
            double _co = -1;
            PointF _cp = new PointF(0,0);

            foreach ( var _tt in _t)
            {
                string[] _t0 = _tt.Split(new char[] { ':' });
                if (_t0.Length != 2) continue;

                switch (_t0[0].Trim())
                {
                    case "font":
                        string[] _tf = _t0[1].Split(new char[] { ',' });
                        if ( _tf.Length != 2) continue;
                        float _ss = float.Parse(_tf[1].Trim());
                        _cf = new Font(_tf[0].Trim(), _ss);
                        break;
                    case "color":
                        string[] _tc = _t0[1].Split(new char[] { ',' });
                        if (_tc.Length != 2) continue;
                        _cfb = new SolidBrush(Color.FromArgb(int.Parse(_tc[0].Trim())));
                        _cbc = Color.FromArgb(int.Parse(_tc[1].Trim()));
                        break;
                    case "padding":
                        string[] _tp = _t0[1].Split(new char[] { ',' });
                        if (_tp.Length != 2) continue;
                        _cp = new PointF(int.Parse(_tp[0].Trim()), int.Parse(_tp[1].Trim()));
                        break;
                    case "opacity":
                        _co = double.Parse(_t0[1].Trim());
                        break;
                }
            }

            if ( _cf == null || _cfb == null )
            {
                throw new Exception($"Bad format config exception");
            }

            this.font = _cf;
            this.foreColor = _cfb;
            this.backColor = _cbc;
            this.opacity = _co;
            this.padding = _cp;
        }
    }


}
