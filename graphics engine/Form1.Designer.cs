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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.traX = new System.Windows.Forms.NumericUpDown();
            this.traY = new System.Windows.Forms.NumericUpDown();
            this.traZ = new System.Windows.Forms.NumericUpDown();
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
            this.label1.Location = new System.Drawing.Point(12, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(630, 470);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(760, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Размер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(760, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Поворот";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(760, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Движение";
            // 
            // sizX
            // 
            this.sizX.DecimalPlaces = 1;
            this.sizX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sizX.Location = new System.Drawing.Point(831, 23);
            this.sizX.Name = "sizX";
            this.sizX.Size = new System.Drawing.Size(34, 20);
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
            this.sizY.Location = new System.Drawing.Point(871, 23);
            this.sizY.Name = "sizY";
            this.sizY.Size = new System.Drawing.Size(34, 20);
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
            this.sizZ.Location = new System.Drawing.Point(911, 23);
            this.sizZ.Name = "sizZ";
            this.sizZ.Size = new System.Drawing.Size(34, 20);
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
            1,
            0,
            0,
            65536});
            this.rolX.Location = new System.Drawing.Point(831, 53);
            this.rolX.Name = "rolX";
            this.rolX.Size = new System.Drawing.Size(34, 20);
            this.rolX.TabIndex = 21;
            // 
            // rolY
            // 
            this.rolY.DecimalPlaces = 1;
            this.rolY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rolY.Location = new System.Drawing.Point(871, 53);
            this.rolY.Name = "rolY";
            this.rolY.Size = new System.Drawing.Size(34, 20);
            this.rolY.TabIndex = 22;
            // 
            // rolZ
            // 
            this.rolZ.DecimalPlaces = 1;
            this.rolZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rolZ.Location = new System.Drawing.Point(911, 53);
            this.rolZ.Name = "rolZ";
            this.rolZ.Size = new System.Drawing.Size(34, 20);
            this.rolZ.TabIndex = 23;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(760, 294);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(35, 13);
            this.error.TabIndex = 24;
            this.error.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(760, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ошибки";
            // 
            // traX
            // 
            this.traX.Location = new System.Drawing.Point(831, 81);
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
            this.traY.Location = new System.Drawing.Point(831, 107);
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
            this.traZ.Location = new System.Drawing.Point(832, 133);
            this.traZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.traZ.Name = "traZ";
            this.traZ.Size = new System.Drawing.Size(73, 20);
            this.traZ.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1053, 560);
            this.Controls.Add(this.traZ);
            this.Controls.Add(this.traY);
            this.Controls.Add(this.traX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.error);
            this.Controls.Add(this.rolZ);
            this.Controls.Add(this.rolY);
            this.Controls.Add(this.rolX);
            this.Controls.Add(this.sizZ);
            this.Controls.Add(this.sizY);
            this.Controls.Add(this.sizX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown traX;
        private System.Windows.Forms.NumericUpDown traY;
        private System.Windows.Forms.NumericUpDown traZ;
    }
}

