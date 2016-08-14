using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Counter
{
	public partial class Form1 : Form
	{
		private struct Counter 
		{
			public string name;
			public int countNum;
		}

		//カウント変数
		Counter[] count = new Counter[6];

		public Form1()
		{
			InitializeComponent();
		}

		//ロード時の処理
		//保存データを読み込み反映
		private void Form1_Load(object sender, EventArgs e)
		{
			string line = "";
			ArrayList al = new ArrayList();

			using (StreamReader sr = new StreamReader("savedata", Encoding.GetEncoding("Shift_JIS")))
			{
				while ((line = sr.ReadLine()) != null)
				{
					al.Add(line);
				}
			}

			count[1].name = al[0].ToString();
			count[1].countNum = Convert.ToInt32(al[1]);

			count[2].name = al[2].ToString();
			count[2].countNum = Convert.ToInt32(al[3]);

			count[3].name = al[4].ToString();
			count[3].countNum = Convert.ToInt32(al[5]);

			count[4].name = al[6].ToString();
			count[4].countNum = Convert.ToInt32(al[7]);

			count[5].name = al[8].ToString();
			count[5].countNum = Convert.ToInt32(al[9]);


			textBoxCount1Name.Text = count[1].name;
			textBoxCount1Show.Text = count[1].countNum.ToString();

			textBoxCount2Name.Text = count[2].name;
			textBoxCount2Show.Text = count[2].countNum.ToString();

			textBoxCount3Name.Text = count[3].name;
			textBoxCount3Show.Text = count[3].countNum.ToString();

			textBoxCount4Name.Text = count[4].name;
			textBoxCount4Show.Text = count[4].countNum.ToString();

			textBoxCount5Name.Text = count[5].name;
			textBoxCount5Show.Text = count[5].countNum.ToString();
		}

		#region カウントボタン
		#region カウント1
		//+ボタン
		private void buttonCount1Plus_Click(object sender, EventArgs e)
		{
			count[1].countNum++;
			textBoxCount1Show.Text = count[1].countNum.ToString();
		}

		//-ボタン
		private void buttonCount1Minus_Click(object sender, EventArgs e)
		{
			count[1].countNum--;
			textBoxCount1Show.Text = count[1].countNum.ToString();
		}

		//0ボタン
		private void buttonCount1Zero_Click(object sender, EventArgs e)
		{
			count[1].countNum = 0;
			textBoxCount1Show.Text = count[1].countNum.ToString();
		}
		#endregion カウント1

		#region カウント2
		private void button3_Click(object sender, EventArgs e)
		{
			count[2].countNum++;
			textBoxCount2Show.Text = count[2].countNum.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			count[2].countNum--;
			textBoxCount2Show.Text = count[2].countNum.ToString();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			count[2].countNum = 0;
			textBoxCount2Show.Text = count[2].countNum.ToString();
		}
		#endregion カウント2

		#region カウント3
		private void button5_Click(object sender, EventArgs e)
		{
			count[3].countNum++;
			textBoxCount3Show.Text = count[3].countNum.ToString();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			count[3].countNum--;
			textBoxCount3Show.Text = count[3].countNum.ToString();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			count[3].countNum = 0;
			textBoxCount3Show.Text = count[3].countNum.ToString();
		}
		#endregion カウント3

		#region カウント4
		private void button7_Click(object sender, EventArgs e)
		{
			count[4].countNum++;
			textBoxCount4Show.Text = count[4].countNum.ToString();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			count[4].countNum--;
			textBoxCount4Show.Text = count[4].countNum.ToString();

		}

		private void button15_Click(object sender, EventArgs e)
		{
			count[4].countNum = 0;
			textBoxCount4Show.Text = count[4].countNum.ToString();
		}
		#endregion カウント4

		#region カウント5
		private void button9_Click(object sender, EventArgs e)
		{
			count[5].countNum++;
			textBoxCount5Show.Text = count[5].countNum.ToString();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			count[5].countNum--;
			textBoxCount5Show.Text = count[5].countNum.ToString();
		}

		private void button16_Click(object sender, EventArgs e)
		{
			count[5].countNum = 0;
			textBoxCount5Show.Text = count[5].countNum.ToString();
		}
		#endregion カウント5
		#endregion カウントボタン

		//保存ボタン
		private void buttonSave_Click(object sender, EventArgs e)
		{
			//前データ削除
			System.IO.File.Delete("savedata");

			Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
			StreamWriter writer = new StreamWriter("savedata", true, sjisEnc);
			
			writer.WriteLine(textBoxCount1Name.Text);
			writer.WriteLine(textBoxCount1Show.Text);
			writer.WriteLine(textBoxCount2Name.Text);
			writer.WriteLine(textBoxCount2Show.Text);
			writer.WriteLine(textBoxCount3Name.Text);
			writer.WriteLine(textBoxCount3Show.Text);
			writer.WriteLine(textBoxCount4Name.Text);
			writer.WriteLine(textBoxCount4Show.Text);
			writer.WriteLine(textBoxCount5Name.Text);
			writer.WriteLine(textBoxCount5Show.Text);
			
			writer.Close();
		}
	}
}
