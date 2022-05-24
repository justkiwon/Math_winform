namespace Math
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.diffRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diffLeftLabel = new System.Windows.Forms.Label();
            this.double1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.doubleRightLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.doubleLeftLabel = new System.Windows.Forms.Label();
            this.split = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.splitRightLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.splitLeftLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.double1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(176, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("굴림", 18F);
            this.plus.Location = new System.Drawing.Point(116, 75);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 50);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.plusRightLabel.Location = new System.Drawing.Point(182, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 18F);
            this.label3.Location = new System.Drawing.Point(248, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("굴림", 18F);
            this.sum.Location = new System.Drawing.Point(316, 82);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            this.sum.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("굴림", 18F);
            this.difference.Location = new System.Drawing.Point(318, 139);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 2;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 18F);
            this.label4.Location = new System.Drawing.Point(250, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diffRightLabel
            // 
            this.diffRightLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.diffRightLabel.Location = new System.Drawing.Point(184, 132);
            this.diffRightLabel.Name = "diffRightLabel";
            this.diffRightLabel.Size = new System.Drawing.Size(60, 50);
            this.diffRightLabel.TabIndex = 9;
            this.diffRightLabel.Text = "?";
            this.diffRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("굴림", 18F);
            this.label6.Location = new System.Drawing.Point(118, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diffLeftLabel
            // 
            this.diffLeftLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.diffLeftLabel.Location = new System.Drawing.Point(52, 132);
            this.diffLeftLabel.Name = "diffLeftLabel";
            this.diffLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.diffLeftLabel.TabIndex = 7;
            this.diffLeftLabel.Text = "?";
            this.diffLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // double1
            // 
            this.double1.Font = new System.Drawing.Font("굴림", 18F);
            this.double1.Location = new System.Drawing.Point(316, 198);
            this.double1.Name = "double1";
            this.double1.Size = new System.Drawing.Size(100, 35);
            this.double1.TabIndex = 3;
            this.double1.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("굴림", 18F);
            this.label8.Location = new System.Drawing.Point(248, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doubleRightLabel
            // 
            this.doubleRightLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.doubleRightLabel.Location = new System.Drawing.Point(182, 191);
            this.doubleRightLabel.Name = "doubleRightLabel";
            this.doubleRightLabel.Size = new System.Drawing.Size(60, 50);
            this.doubleRightLabel.TabIndex = 14;
            this.doubleRightLabel.Text = "?";
            this.doubleRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 18F);
            this.label10.Location = new System.Drawing.Point(116, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 13;
            this.label10.Text = "X";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doubleLeftLabel
            // 
            this.doubleLeftLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.doubleLeftLabel.Location = new System.Drawing.Point(50, 191);
            this.doubleLeftLabel.Name = "doubleLeftLabel";
            this.doubleLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.doubleLeftLabel.TabIndex = 12;
            this.doubleLeftLabel.Text = "?";
            this.doubleLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // split
            // 
            this.split.BackColor = System.Drawing.SystemColors.Window;
            this.split.Font = new System.Drawing.Font("굴림", 18F);
            this.split.Location = new System.Drawing.Point(317, 263);
            this.split.Name = "split";
            this.split.Size = new System.Drawing.Size(100, 35);
            this.split.TabIndex = 4;
            this.split.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("굴림", 18F);
            this.label12.Location = new System.Drawing.Point(249, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitRightLabel
            // 
            this.splitRightLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.splitRightLabel.Location = new System.Drawing.Point(183, 256);
            this.splitRightLabel.Name = "splitRightLabel";
            this.splitRightLabel.Size = new System.Drawing.Size(60, 50);
            this.splitRightLabel.TabIndex = 19;
            this.splitRightLabel.Text = "?";
            this.splitRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("굴림", 18F);
            this.label14.Location = new System.Drawing.Point(117, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 18;
            this.label14.Text = "/";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitLeftLabel
            // 
            this.splitLeftLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.splitLeftLabel.Location = new System.Drawing.Point(51, 256);
            this.splitLeftLabel.Name = "splitLeftLabel";
            this.splitLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.splitLeftLabel.TabIndex = 17;
            this.splitLeftLabel.Text = "?";
            this.splitLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Start.Location = new System.Drawing.Point(186, 326);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(125, 29);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start the quiz";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.split);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.splitRightLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.splitLeftLabel);
            this.Controls.Add(this.double1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doubleRightLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.doubleLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diffRightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.diffLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.double1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label diffRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label diffLeftLabel;
        private System.Windows.Forms.NumericUpDown double1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label doubleRightLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label doubleLeftLabel;
        private System.Windows.Forms.NumericUpDown split;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label splitRightLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label splitLeftLabel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer timer1;
    }
}

