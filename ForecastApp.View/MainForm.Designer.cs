namespace ForecastApp.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tempTextBox = new TextBox();
            windSpeedTextBox = new TextBox();
            descTextBox = new TextBox();
            errorTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(259, 83);
            button1.Name = "button1";
            button1.Size = new Size(111, 46);
            button1.TabIndex = 0;
            button1.Text = "Узнать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(202, 38);
            label1.TabIndex = 1;
            label1.Text = "Введите город";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(220, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 43);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(189, 38);
            label2.TabIndex = 3;
            label2.Text = "Температура:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 265);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 4;
            label3.Text = "Скорость ветра:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 331);
            label4.Name = "label4";
            label4.Size = new Size(150, 38);
            label4.TabIndex = 5;
            label4.Text = "Описание:";
            // 
            // tempTextBox
            // 
            tempTextBox.Enabled = false;
            tempTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tempTextBox.Location = new Point(269, 197);
            tempTextBox.Name = "tempTextBox";
            tempTextBox.Size = new Size(245, 43);
            tempTextBox.TabIndex = 6;
            // 
            // windSpeedTextBox
            // 
            windSpeedTextBox.Enabled = false;
            windSpeedTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            windSpeedTextBox.Location = new Point(269, 265);
            windSpeedTextBox.Name = "windSpeedTextBox";
            windSpeedTextBox.Size = new Size(245, 43);
            windSpeedTextBox.TabIndex = 7;
            // 
            // descTextBox
            // 
            descTextBox.Enabled = false;
            descTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descTextBox.Location = new Point(269, 331);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(245, 43);
            descTextBox.TabIndex = 8;
            // 
            // errorTextBox
            // 
            errorTextBox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            errorTextBox.Location = new Point(12, 144);
            errorTextBox.Name = "errorTextBox";
            errorTextBox.ReadOnly = true;
            errorTextBox.Size = new Size(519, 25);
            errorTextBox.TabIndex = 9;
            errorTextBox.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(542, 433);
            Controls.Add(errorTextBox);
            Controls.Add(descTextBox);
            Controls.Add(windSpeedTextBox);
            Controls.Add(tempTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Погода";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tempTextBox;
        private TextBox windSpeedTextBox;
        private TextBox descTextBox;
        private TextBox errorTextBox;
    }
}
