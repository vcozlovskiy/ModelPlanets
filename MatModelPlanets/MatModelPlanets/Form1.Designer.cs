namespace MatModelPlanets
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newRandPlan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startSys = new System.Windows.Forms.Button();
            this.tBMass = new System.Windows.Forms.TextBox();
            this.tBvelositiX = new System.Windows.Forms.TextBox();
            this.tBvelositiY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imPulse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 775);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // newRandPlan
            // 
            this.newRandPlan.Location = new System.Drawing.Point(1015, 14);
            this.newRandPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newRandPlan.Name = "newRandPlan";
            this.newRandPlan.Size = new System.Drawing.Size(115, 50);
            this.newRandPlan.TabIndex = 1;
            this.newRandPlan.Text = "New random Planet";
            this.newRandPlan.UseVisualStyleBackColor = true;
            this.newRandPlan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startSys
            // 
            this.startSys.Location = new System.Drawing.Point(1015, 70);
            this.startSys.Margin = new System.Windows.Forms.Padding(4);
            this.startSys.Name = "startSys";
            this.startSys.Size = new System.Drawing.Size(115, 50);
            this.startSys.TabIndex = 2;
            this.startSys.Text = "Start System";
            this.startSys.UseVisualStyleBackColor = true;
            this.startSys.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // tBMass
            // 
            this.tBMass.Location = new System.Drawing.Point(1096, 170);
            this.tBMass.Margin = new System.Windows.Forms.Padding(4);
            this.tBMass.Name = "tBMass";
            this.tBMass.Size = new System.Drawing.Size(103, 22);
            this.tBMass.TabIndex = 3;
            // 
            // tBvelositiX
            // 
            this.tBvelositiX.Location = new System.Drawing.Point(1096, 197);
            this.tBvelositiX.Margin = new System.Windows.Forms.Padding(4);
            this.tBvelositiX.Name = "tBvelositiX";
            this.tBvelositiX.Size = new System.Drawing.Size(103, 22);
            this.tBvelositiX.TabIndex = 4;
            // 
            // tBvelositiY
            // 
            this.tBvelositiY.Location = new System.Drawing.Point(1096, 227);
            this.tBvelositiY.Margin = new System.Windows.Forms.Padding(4);
            this.tBvelositiY.Name = "tBvelositiY";
            this.tBvelositiY.Size = new System.Drawing.Size(103, 22);
            this.tBvelositiY.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поля для создания планеты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "с заданнми парметрами";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1017, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "для ее появления нажмите";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1017, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "на черную область";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1032, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Масса :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1003, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Скорость Х:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1003, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Скорость Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1035, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete Planets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1098, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Faster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1005, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Slowle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imPulse
            // 
            this.imPulse.Location = new System.Drawing.Point(1006, 401);
            this.imPulse.Name = "imPulse";
            this.imPulse.Size = new System.Drawing.Size(100, 22);
            this.imPulse.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1268, 804);
            this.Controls.Add(this.imPulse);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBvelositiY);
            this.Controls.Add(this.tBvelositiX);
            this.Controls.Add(this.tBMass);
            this.Controls.Add(this.startSys);
            this.Controls.Add(this.newRandPlan);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newRandPlan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startSys;
        private System.Windows.Forms.TextBox tBMass;
        private System.Windows.Forms.TextBox tBvelositiX;
        private System.Windows.Forms.TextBox tBvelositiY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox imPulse;
    }
}

