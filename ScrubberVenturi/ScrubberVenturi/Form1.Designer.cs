namespace ScrubberVenturi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vz = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.w = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.w1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Vb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.h = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.K = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vz)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vb)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Vz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 53);
            this.panel1.TabIndex = 0;
            // 
            // Vz
            // 
            this.Vz.Location = new System.Drawing.Point(7, 21);
            this.Vz.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Vz.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Vz.Name = "Vz";
            this.Vz.Size = new System.Drawing.Size(120, 20);
            this.Vz.TabIndex = 1;
            this.Vz.Value = new decimal(new int[] {
            29819,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Объём очищаемого газа";
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc.Location = new System.Drawing.Point(6, 19);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(755, 33);
            this.calc.TabIndex = 3;
            this.calc.Text = "Создать модель";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(7, 96);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(754, 32);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить отчет";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.w);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 53);
            this.panel2.TabIndex = 2;
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(7, 21);
            this.w.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.w.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(120, 20);
            this.w.TabIndex = 1;
            this.w.Value = new decimal(new int[] {
            105,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Скорость газа в горловине";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.w1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 53);
            this.panel3.TabIndex = 2;
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(7, 21);
            this.w1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.w1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(120, 20);
            this.w1.TabIndex = 1;
            this.w1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cкорость газа в выходном сечении трубы";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.Vb);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 53);
            this.panel4.TabIndex = 3;
            // 
            // Vb
            // 
            this.Vb.Location = new System.Drawing.Point(7, 21);
            this.Vb.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Vb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Vb.Name = "Vb";
            this.Vb.Size = new System.Drawing.Size(120, 20);
            this.Vb.TabIndex = 1;
            this.Vb.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Объём воды";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.h);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(7, 255);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 53);
            this.panel5.TabIndex = 3;
            // 
            // h
            // 
            this.h.DecimalPlaces = 2;
            this.h.Location = new System.Drawing.Point(7, 21);
            this.h.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.h.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(120, 20);
            this.h.TabIndex = 1;
            this.h.Value = new decimal(new int[] {
            73,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Коэффициент расхода воды";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(247, 19);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(505, 436);
            this.result.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(6, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(755, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Построить по размерам";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.calc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(12, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(7, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(754, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Выйти из программы";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 461);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчёты";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "V, м3/ч";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ω, м/с";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ω1, м/с";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Vb, м3/ч";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "μ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(7, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 436);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Исходные данные";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.pb);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(6, 314);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 53);
            this.panel7.TabIndex = 9;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(7, 21);
            this.pb.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(120, 20);
            this.pb.TabIndex = 1;
            this.pb.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Плотность воды";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Menu;
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.K);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(6, 373);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 53);
            this.panel8.TabIndex = 10;
            // 
            // K
            // 
            this.K.DecimalPlaces = 2;
            this.K.InterceptArrowKeys = false;
            this.K.Location = new System.Drawing.Point(7, 21);
            this.K.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.K.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(120, 20);
            this.K.TabIndex = 1;
            this.K.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Коэффициент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ρb, кг/м3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(143, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(791, 662);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Скруббер Вентури";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vz)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.w1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vb)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.K)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Vz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown w;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown w1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown Vb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown h;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown K;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown pb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
    }
}

