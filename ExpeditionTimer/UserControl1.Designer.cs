namespace 遠征タイマー2
{
	partial class UserControl1
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonReStart = new System.Windows.Forms.Button();
			this.labelTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonStart.Location = new System.Drawing.Point(79, 0);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(34, 23);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "始";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonReStart
			// 
			this.buttonReStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonReStart.Location = new System.Drawing.Point(119, 0);
			this.buttonReStart.Name = "buttonReStart";
			this.buttonReStart.Size = new System.Drawing.Size(34, 23);
			this.buttonReStart.TabIndex = 2;
			this.buttonReStart.Text = "再";
			this.buttonReStart.UseVisualStyleBackColor = true;
			this.buttonReStart.Click += new System.EventHandler(this.buttonReStart_Click);
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.BackColor = System.Drawing.Color.White;
			this.labelTime.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTime.Location = new System.Drawing.Point(0, 3);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(62, 16);
			this.labelTime.TabIndex = 3;
			this.labelTime.Text = "00:00:00";
			this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 200;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.buttonReStart);
			this.Controls.Add(this.buttonStart);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(160, 23);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonReStart;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer1;
	}
}
