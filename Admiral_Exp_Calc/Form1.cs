using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace 提督経験値加算器
{
	public partial class Form1 : Form
	{
		//提督経験値
		double empiricalValue;

		//一つ前の提督経験値
		double oldEmpiricalValue;

		//戦果
		int veterans;

		//マップの経験値
		const double M1_1W = 10;
		const double M1_1B = 20;

		const double M1_5W = 75;
		const double M1_5B = 1050;

		const double M2_2W = 70;
		const double M2_2B = 840;

		const double M2_3W = 80;
		const double M2_3B = 960;

		const double M3_2W = 120;

		const double M5_4W = 190;
		const double M5_4B = 2880;

		const double M5_5W = 200;
		const double M5_5B = 3100;

		public Form1()
		{
			InitializeComponent();
		}

		//ロード時の処理 保存データを読み込み反映
		private void Form1_Load(object sender, EventArgs e)
		{
			string line = "";
			ArrayList al = new ArrayList();

			using (StreamReader sr = new StreamReader("Veterans.sv", Encoding.GetEncoding("Shift_JIS")))
			{
				while ((line = sr.ReadLine()) != null)
				{
					al.Add(line);
				}
			}

			//提督経験値に反映
			empiricalValue = Convert.ToInt32(al[0]);

			//戦果計算
			veterans = (int)(empiricalValue / 1428);

			//ラベルに反映
			labelEmpiricalValue.Text = empiricalValue.ToString();
			labelVeterans.Text = veterans.ToString();
		}

		//手動反映ボタン
		private void button11_Click(object sender, EventArgs e)
		{
			string num = textBoxManual.Text;

			empiricalValue += Convert.ToInt32(num);

			LabelUpDating();

			textBoxManual.Text = "";
		}

		//リセットボタン
		private void button4_Click(object sender, EventArgs e)
		{
			empiricalValue = 0;

			LabelUpDating();
		}

		//保存ボタン
		private void button12_Click(object sender, EventArgs e)
		{
			//前データ削除
			System.IO.File.Delete("Veterans.sv");

			//新規作成
			string logTextPath = "Veterans.sv";

			//書き込み
			System.IO.File.AppendAllText(logTextPath, empiricalValue.ToString());
		}

		//ラベル更新
		public void LabelUpDating()
		{
			//変わる前の値記憶
			oldEmpiricalValue = double.Parse(labelEmpiricalValue.Text);

			//戦果計算
			veterans = (int)(empiricalValue / 1428);

			labelEmpiricalValue.Text = empiricalValue.ToString();
			labelVeterans.Text = veterans.ToString();
		}

		#region 1-1
		private void buttonM1WayS_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_1W;
			LabelUpDating();
		}

		private void buttonM1_1WayA_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_1W * 0.8;
			LabelUpDating();
		}

		private void buttonM1_1WayB_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_1W * 0.5;
			LabelUpDating();
		}

		private void buttonM1_1BossS_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_1B;
			LabelUpDating();
		}

		private void buttonM1_1BossA_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_1B - (M1_1W * 0.5);
			LabelUpDating();
		}

		private void buttonM1_1BossB_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_1B - (M1_1W * 0.8);
			LabelUpDating();
		}

		private void buttonM1_1BossC_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_1W;
			LabelUpDating();
		}
		#endregion 1-1

		#region 1-5
		private void buttonM1_5WayS_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_5W;
			LabelUpDating();
		}

		private void buttonM1_5WayA_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_5W * 0.8;
			LabelUpDating();
		}

		private void buttonM1_5WayB_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_5W * 0.5;
			LabelUpDating();
		}

		private void buttonM1_5BossS_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_5B;
			LabelUpDating();
		}

		private void buttonM1_5BossA_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_5B - (M1_5W * 0.5);
			LabelUpDating();
		}

		private void buttonM1_5BossB_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_5B - (M1_5W * 0.8);
			LabelUpDating();
		}

		private void buttonM1_5BossC_Click(object sender, EventArgs e)
		{
			empiricalValue += M1_5W;
			LabelUpDating();
		}
		#endregion 1-5

		#region 2-2
		private void buttonM2_2WayS_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_2W;
			LabelUpDating();
		}

		private void buttonM2_2WayA_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_2W * 0.8;
			LabelUpDating();
		}

		private void buttonM2_2WayB_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_2W * 0.5;
			LabelUpDating();
		}

		private void buttonM2_2BossS_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_2B;
			LabelUpDating();
		}

		private void buttonM2_2BossA_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_2B - (M2_2W * 0.5);
			LabelUpDating();
		}

		private void buttonM2_2BossB_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_2B - (M2_2W * 0.8);
			LabelUpDating();
		}

		private void buttonM2_2BossC_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_2W;
			LabelUpDating();
		}
		#endregion 2-2

		#region 2-3
		private void buttonM2_3WayS_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_3W;
			LabelUpDating();
		}

		private void buttonM2_3WayA_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_3W * 0.8;
			LabelUpDating();
		}

		private void buttonM2_3WayB_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_3W * 0.5;
			LabelUpDating();
		}

		private void buttonM2_3BossS_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_3B;
			LabelUpDating();
		}

		private void buttonM2_3BossA_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_3B - (M2_3W * 0.5);
			LabelUpDating();
		}

		private void buttonM2_3BossB_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_3B - (M2_3W * 0.8);
			LabelUpDating();
		}

		private void buttonM2_3BossC_Click(object sender, EventArgs e)
		{
			empiricalValue += M2_3W;
			LabelUpDating();
		}
		#endregion 2-3

		#region 3-2
		private void buttonM3_2WayS_Click(object sender, EventArgs e)
		{
			empiricalValue += M3_2W;
			LabelUpDating();
		}

		private void buttonM3_2WayA_Click(object sender, EventArgs e)
		{
			empiricalValue += M3_2W * 0.8;
			LabelUpDating();
		}

		private void buttonM3_2WayB_Click(object sender, EventArgs e)
		{
			empiricalValue += M3_2W * 0.5;
			LabelUpDating();
		}
		#endregion 3-2

		#region 5-4
		private void buttonM5_4WayS_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_4W;
			LabelUpDating();
		}

		private void buttonM5_4WayA_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_4W * 0.8;
			LabelUpDating();
		}

		private void buttonM5_4WayB_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_4W * 0.5;
			LabelUpDating();
		}

		private void buttonM5_4BossS_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_4B;
			LabelUpDating();
		}

		private void buttonM5_4BossA_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_4B - (M5_4W * 0.5);
			LabelUpDating();
		}

		private void buttonM5_4BossB_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_4B - (M5_4W * 0.8);
			LabelUpDating();
		}

		private void buttonM5_4BossC_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_4W;
			LabelUpDating();
		}
		#endregion 5-4

		#region 5-5
		private void buttonM5_5WayS_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_5W;
			LabelUpDating();
		}

		private void buttonM5_5WayA_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_5W * 0.8;
			LabelUpDating();
		}

		private void buttonM5_5WayB_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_5W * 0.5;
			LabelUpDating();
		}

		private void buttonM5_5BossS_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_5B;
			LabelUpDating();
		}

		private void buttonM5_5BossA_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_5B - (M5_5W * 0.5);
			LabelUpDating();
		}

		private void buttonM5_5BossB_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_5W - (M5_5W * 0.8);
			LabelUpDating();
		}

		private void buttonM5_5BossC_Click(object sender, EventArgs e)
		{
			empiricalValue += M5_5W;
			LabelUpDating();
		}
		#endregion 5-5

		private void buttonReMove_Click(object sender, EventArgs e)
		{
			empiricalValue = oldEmpiricalValue;
			LabelUpDating();
		}
	}
}
