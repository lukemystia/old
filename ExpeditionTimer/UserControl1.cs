using System;
using System.Drawing;
using System.Windows.Forms;

namespace 遠征タイマー2
{
	public partial class UserControl1 : UserControl
	{
		//終了時刻
		DateTime appointedTime = DateTime.Now;

		//再ボタン用の指定時間保存
		string determinatTime = "00:00:00";

		public UserControl1()
		{
			InitializeComponent();
		}

		//ラベルをクリックすることで別フォームを開き時間指定ができる
		//始ボタンをクリックで指定した時間をカウントをする
		//再ボタンで再び指定時間のカウントが出来る

		//ラベルをクリックした時の
		private void labelTime_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(labelTime);
			form2.StartPosition = FormStartPosition.Manual;
			form2.Location = new Point(System.Windows.Forms.Cursor.Position.X - 50, System.Windows.Forms.Cursor.Position.Y - 50);
			form2.Show();
		}

		//始ボタン
		private void buttonStart_Click(object sender, EventArgs e)
		{
			//タイマーを無効に
			timer1.Enabled = false;

			labelTime.BackColor = Color.White;

			//再ボタン用に指定時間を別保存
			determinatTime = labelTime.Text;

			//ボタンをおした時の現在時刻を取得
			DateTime dateTimeNow = DateTime.Now;

			#region 指定時間を現在時刻に足し、終了時刻を求める

			//現在時刻を秒に変換
			int nowTimeSec = dateTimeNow.Hour * 3600 + dateTimeNow.Minute * 60 + dateTimeNow.Second;

			//指定時間の文字列から秒数を求める
			int designatedTimeSec = GetSecondTime(labelTime.Text);

			//(Sec)(終了時刻) = (現在時刻) + (指定時間)
			int appointedTimeSec = nowTimeSec + designatedTimeSec;

			//終了時刻(Sec)を時刻になおす
			//日付を又く時のための処理
			if (appointedTimeSec > 86400)
			{
				appointedTimeSec = appointedTimeSec - 86400;

				int hour = (int)(appointedTimeSec / 3600);
				int minute = (int)((appointedTimeSec - hour * 3600) / 60);
				int second = (int)(appointedTimeSec - (hour * 3600) - (minute * 60));

				appointedTime = new DateTime(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day + 1, hour, minute, second);
			}
			else 
			{
				int hour = (int)(appointedTimeSec / 3600);
				int minute = (int)((appointedTimeSec - hour * 3600) / 60);
				int second = (int)(appointedTimeSec - (hour * 3600) - (minute * 60));

				appointedTime = new DateTime(dateTimeNow.Year, dateTimeNow.Month, dateTimeNow.Day, hour, minute, second);
			}

			#endregion 指定時間を現在時刻に足し、終了時刻を求める

			//タイマーを有効に
			timer1.Enabled = true;
		}

		//再ボタン
		private void buttonReStart_Click(object sender, EventArgs e)
		{
			//再び設定
			labelTime.Text = determinatTime;

			//始ボタン　クリック
			buttonStart_Click(sender, e);
		}

		//タイマー
		private void timer1_Tick(object sender, EventArgs e)
		{
			//現在の時刻を取得
			DateTime dateTimeNow = DateTime.Now;

			//終了時刻を秒に変換
			int appointedTimeSec = appointedTime.Hour * 3600 + appointedTime.Minute * 60 + appointedTime.Second;

			//現在時刻を秒に変換
			int nowTimeSec = dateTimeNow.Hour * 3600 + dateTimeNow.Minute * 60 + dateTimeNow.Second;

			//残り時間を計算(Sec)
			int remainTimeSec;

			if (appointedTime.Day == dateTimeNow.Day)
			{
				remainTimeSec = appointedTimeSec - nowTimeSec;
			}
			else
			{
				remainTimeSec = 86400 + appointedTimeSec - nowTimeSec;
			}

			//ここから表示関連

			if (remainTimeSec < 1)
			{
				//タイマーを無効に
				timer1.Enabled = false;

				labelTime.Text = "遠征終了";

				labelTime.BackColor = Color.Pink;
			}
			else
			{
				if (remainTimeSec < 70)
				{
					labelTime.BackColor = Color.Cyan;
				}

				if (remainTimeSec == 70)
				{
					//PlaySound();
				}

				int hours;
				int minutes;
				int seconds;

				hours = (int)(remainTimeSec / 3600);

				minutes = (int)((remainTimeSec - (hours * 3600)) / 60);

				seconds = remainTimeSec - (hours * 3600) - (minutes * 60);

				labelTime.Text = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2");
			}
			labelTime.Update();
		}

		//読みこんだ時間を秒にする
		private int GetSecondTime(string readTime)
		{
			//秒時間格納変数
			int secondTime;

			if (readTime == "遠征終了") { return 0; }
			else
			{
				//セミコロン区切りで分割して配列に格納する
				string[] timeArray = readTime.Split(':');

				secondTime = int.Parse(timeArray[0]) * 3600 + int.Parse(timeArray[1]) * 60 + int.Parse(timeArray[2]);

				return secondTime;
			}
		}

		

		
	}
}
