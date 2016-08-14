using System;
using System.Windows.Forms;

namespace 遠征タイマー2
{
	public partial class Form2 : Form
	{
		Label readLabel;

		public Form2(Label la)
		{
			//メインフォームへの参照を保存
			readLabel = la;

			InitializeComponent();
		}

		//キャンセルボタン
		private void button2_Click(object sender, EventArgs e)
		{
			//自分自身のフォームを閉じる
			this.Close();
		}

		//決定ボタン
		private void button1_Click(object sender, EventArgs e)
		{
			//選択されている項目名を取得
			string determinatTime = comboBoxDesignatedTime.Text;

			//読み込み元formへ渡す
			readLabel.Text = determinatTime;

			//自分自身のフォームを閉じる
			this.Close();
		}
	}
}
