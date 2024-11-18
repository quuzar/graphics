namespace graphics_engine
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sizX = new System.Windows.Forms.NumericUpDown();
            this.sizY = new System.Windows.Forms.NumericUpDown();
            this.sizZ = new System.Windows.Forms.NumericUpDown();
            this.rolX = new System.Windows.Forms.NumericUpDown();
            this.rolY = new System.Windows.Forms.NumericUpDown();
            this.rolZ = new System.Windows.Forms.NumericUpDown();
            this.error = new System.Windows.Forms.Label();
            this.traX = new System.Windows.Forms.NumericUpDown();
            this.traY = new System.Windows.Forms.NumericUpDown();
            this.traZ = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traZ)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 439);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Размер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Поворот";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Движение";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sizX
            // 
            this.sizX.DecimalPlaces = 1;
            this.sizX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sizX.Location = new System.Drawing.Point(77, 23);
            this.sizX.Name = "sizX";
            this.sizX.Size = new System.Drawing.Size(74, 20);
            this.sizX.TabIndex = 18;
            this.sizX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sizY
            // 
            this.sizY.DecimalPlaces = 1;
            this.sizY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sizY.Location = new System.Drawing.Point(157, 23);
            this.sizY.Name = "sizY";
            this.sizY.Size = new System.Drawing.Size(74, 20);
            this.sizY.TabIndex = 19;
            this.sizY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sizZ
            // 
            this.sizZ.DecimalPlaces = 1;
            this.sizZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sizZ.Location = new System.Drawing.Point(237, 23);
            this.sizZ.Name = "sizZ";
            this.sizZ.Size = new System.Drawing.Size(73, 20);
            this.sizZ.TabIndex = 20;
            this.sizZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rolX
            // 
            this.rolX.DecimalPlaces = 1;
            this.rolX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.rolX.Location = new System.Drawing.Point(77, 49);
            this.rolX.Name = "rolX";
            this.rolX.Size = new System.Drawing.Size(74, 20);
            this.rolX.TabIndex = 21;
            // 
            // rolY
            // 
            this.rolY.DecimalPlaces = 1;
            this.rolY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.rolY.Location = new System.Drawing.Point(157, 49);
            this.rolY.Name = "rolY";
            this.rolY.Size = new System.Drawing.Size(74, 20);
            this.rolY.TabIndex = 22;
            // 
            // rolZ
            // 
            this.rolZ.DecimalPlaces = 1;
            this.rolZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.rolZ.Location = new System.Drawing.Point(237, 49);
            this.rolZ.Name = "rolZ";
            this.rolZ.Size = new System.Drawing.Size(73, 20);
            this.rolZ.TabIndex = 23;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(6, 16);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(35, 13);
            this.error.TabIndex = 24;
            this.error.Text = "label8";
            // 
            // traX
            // 
            this.traX.Location = new System.Drawing.Point(77, 75);
            this.traX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.traX.Name = "traX";
            this.traX.Size = new System.Drawing.Size(74, 20);
            this.traX.TabIndex = 26;
            // 
            // traY
            // 
            this.traY.Location = new System.Drawing.Point(157, 75);
            this.traY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.traY.Name = "traY";
            this.traY.Size = new System.Drawing.Size(74, 20);
            this.traY.TabIndex = 27;
            // 
            // traZ
            // 
            this.traZ.Location = new System.Drawing.Point(237, 75);
            this.traZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.traZ.Name = "traZ";
            this.traZ.Size = new System.Drawing.Size(73, 20);
            this.traZ.TabIndex = 28;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Куб";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Text = "Пирамида";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 78);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Додэкаэдр";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(768, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 157);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор объекта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.traZ);
            this.groupBox2.Controls.Add(this.sizX);
            this.groupBox2.Controls.Add(this.traY);
            this.groupBox2.Controls.Add(this.sizY);
            this.groupBox2.Controls.Add(this.traX);
            this.groupBox2.Controls.Add(this.sizZ);
            this.groupBox2.Controls.Add(this.rolX);
            this.groupBox2.Controls.Add(this.rolY);
            this.groupBox2.Controls.Add(this.rolZ);
            this.groupBox2.Location = new System.Drawing.Point(257, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 114);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение объекта";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 114);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры объекта";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.error);
            this.groupBox4.Location = new System.Drawing.Point(768, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 396);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ошибки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1103, 573);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traZ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sizX;
        private System.Windows.Forms.NumericUpDown sizY;
        private System.Windows.Forms.NumericUpDown sizZ;
        private System.Windows.Forms.NumericUpDown rolX;
        private System.Windows.Forms.NumericUpDown rolY;
        private System.Windows.Forms.NumericUpDown rolZ;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.NumericUpDown traX;
        private System.Windows.Forms.NumericUpDown traY;
        private System.Windows.Forms.NumericUpDown traZ;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

