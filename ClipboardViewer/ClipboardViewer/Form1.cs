using System;
using System.Windows.Forms;

namespace ClipboardViewer
{
	public partial class Form1 : Form
	{
		private MyClipboardViewer viewer;
		private bool flag = false;

		public Form1()
		{
			viewer = new MyClipboardViewer(this);

			//イベントハンドラを登録
			viewer.ClipboardHandler += this.OnClipBoardChanged;
			InitializeComponent();
		}

		//クリップボードにテキストがコピーされると呼び出される
		private void OnClipBoardChanged(object sender, ClipboardEventArgs args)
		{
			if (flag == true)
			{
				this.textBox2.Text = this.textBox.Text;
				this.textBox.Text = args.Text;
			}
		}

		//初期設定
		private void Form1_Load(object sender, EventArgs e)
		{
			this.textBox.Text = "クリップボードが変更されるたびに更新されます";
			flag = true;
		}
	}
}
