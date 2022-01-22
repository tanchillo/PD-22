namespace ScrubberVenturi
{
    partial class Form2
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
            this.calc = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dg = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ld = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.L1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.L2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.D1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Dk = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Hk = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Dok = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ld)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dk)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hk)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dok)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.calc.Location = new System.Drawing.Point(6, 19);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(754, 32);
            this.calc.TabIndex = 3;
            this.calc.Text = "Создать модель";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(6, 57);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(754, 30);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить отчет";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(236, 19);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(518, 465);
            this.result.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Dg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 53);
            this.panel1.TabIndex = 4;
            // 
            // Dg
            // 
            this.Dg.DecimalPlaces = 3;
            this.Dg.Location = new System.Drawing.Point(7, 21);
            this.Dg.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Dg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Dg.Name = "Dg";
            this.Dg.Size = new System.Drawing.Size(120, 20);
            this.Dg.TabIndex = 1;
            this.Dg.Value = new decimal(new int[] {
            317,
            0,
            0,
            196608});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаметер горловины";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Ld);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 53);
            this.panel2.TabIndex = 5;
            // 
            // Ld
            // 
            this.Ld.DecimalPlaces = 3;
            this.Ld.Location = new System.Drawing.Point(7, 21);
            this.Ld.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Ld.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ld.Name = "Ld";
            this.Ld.Size = new System.Drawing.Size(120, 20);
            this.Ld.TabIndex = 1;
            this.Ld.Value = new decimal(new int[] {
            48,
            0,
            0,
            196608});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Длина горловины";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.L1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 53);
            this.panel3.TabIndex = 6;
            // 
            // L1
            // 
            this.L1.DecimalPlaces = 3;
            this.L1.Location = new System.Drawing.Point(7, 21);
            this.L1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.L1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(120, 20);
            this.L1.TabIndex = 1;
            this.L1.Value = new decimal(new int[] {
            1176,
            0,
            0,
            196608});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Длина конфузора";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.L2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(6, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 53);
            this.panel4.TabIndex = 6;
            // 
            // L2
            // 
            this.L2.DecimalPlaces = 3;
            this.L2.Location = new System.Drawing.Point(7, 21);
            this.L2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.L2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(120, 20);
            this.L2.TabIndex = 1;
            this.L2.Value = new decimal(new int[] {
            4262,
            0,
            0,
            196608});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Длина диффузора";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.D1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 255);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 53);
            this.panel5.TabIndex = 6;
            // 
            // D1
            // 
            this.D1.DecimalPlaces = 3;
            this.D1.Location = new System.Drawing.Point(7, 21);
            this.D1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.D1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(120, 20);
            this.D1.TabIndex = 1;
            this.D1.Value = new decimal(new int[] {
            838,
            0,
            0,
            196608});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Диаметер конфузора и диффузора";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.Dk);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 314);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 53);
            this.panel6.TabIndex = 6;
            // 
            // Dk
            // 
            this.Dk.DecimalPlaces = 3;
            this.Dk.Location = new System.Drawing.Point(7, 21);
            this.Dk.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Dk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Dk.Name = "Dk";
            this.Dk.Size = new System.Drawing.Size(120, 20);
            this.Dk.TabIndex = 1;
            this.Dk.Value = new decimal(new int[] {
            1662,
            0,
            0,
            196608});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Диаметер каплеуловителя";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.Hk);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(6, 373);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(224, 53);
            this.panel7.TabIndex = 7;
            // 
            // Hk
            // 
            this.Hk.DecimalPlaces = 3;
            this.Hk.Location = new System.Drawing.Point(7, 21);
            this.Hk.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Hk.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Hk.Name = "Hk";
            this.Hk.Size = new System.Drawing.Size(120, 20);
            this.Hk.TabIndex = 1;
            this.Hk.Value = new decimal(new int[] {
            4154,
            0,
            0,
            196608});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Высота каплеуловителя";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.Dok);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(6, 432);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(224, 53);
            this.panel8.TabIndex = 8;
            // 
            // Dok
            // 
            this.Dok.DecimalPlaces = 3;
            this.Dok.Location = new System.Drawing.Point(7, 21);
            this.Dok.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Dok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Dok.Name = "Dok";
            this.Dok.Size = new System.Drawing.Size(120, 20);
            this.Dok.TabIndex = 1;
            this.Dok.Value = new decimal(new int[] {
            17,
            0,
            0,
            196608});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Диаметер отверстий каплеловителя";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.calc);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Location = new System.Drawing.Point(12, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 132);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(7, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(753, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Location = new System.Drawing.Point(13, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 496);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Геометрические параметры";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Dg, м";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Lg, м";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "L1, м";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "L2, м";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "D1/D2, м";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Dk, м";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(133, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hk, м";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Dok, м";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(791, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Скруббер Вентури по размерам";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ld)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.D1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dk)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hk)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Dg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown Ld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown L1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown L2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown D1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown Dk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown Hk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown Dok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

