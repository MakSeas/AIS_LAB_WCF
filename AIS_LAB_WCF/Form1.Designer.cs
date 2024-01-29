
namespace AIS_LAB_WCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MarkComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EngineComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComplectationComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MarkComboBox
            // 
            this.MarkComboBox.FormattingEnabled = true;
            this.MarkComboBox.Items.AddRange(new object[] {
            "Ford",
            "Opel",
            "Renault"});
            this.MarkComboBox.Location = new System.Drawing.Point(12, 12);
            this.MarkComboBox.Name = "MarkComboBox";
            this.MarkComboBox.Size = new System.Drawing.Size(121, 21);
            this.MarkComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка автомобиля";
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "1930",
            "1995",
            "2017"});
            this.YearComboBox.Location = new System.Drawing.Point(12, 39);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(121, 21);
            this.YearComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Год выпуска";
            // 
            // EngineComboBox
            // 
            this.EngineComboBox.FormattingEnabled = true;
            this.EngineComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.EngineComboBox.Location = new System.Drawing.Point(12, 66);
            this.EngineComboBox.Name = "EngineComboBox";
            this.EngineComboBox.Size = new System.Drawing.Size(121, 21);
            this.EngineComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Объем двигателя в литрах";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Черный",
            "Белый",
            "Красный"});
            this.ColorComboBox.Location = new System.Drawing.Point(12, 93);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цвет";
            // 
            // ComplectationComboBox
            // 
            this.ComplectationComboBox.FormattingEnabled = true;
            this.ComplectationComboBox.Items.AddRange(new object[] {
            "Миниальная",
            "Средняя",
            "Максимальная"});
            this.ComplectationComboBox.Location = new System.Drawing.Point(12, 120);
            this.ComplectationComboBox.Name = "ComplectationComboBox";
            this.ComplectationComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComplectationComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Комплектация";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Узнать стоимость автомобиля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComplectationComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EngineComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MarkComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Стоимость авто";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MarkComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EngineComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComplectationComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

