namespace Ödev2
{
    partial class Form1
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            adTxt = new TextBox();
            adresTxt = new TextBox();
            label2 = new Label();
            yasTxt = new TextBox();
            measiTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 287);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(257, 351);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 1;
            button1.Text = "Personel Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(109, 31);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 3;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(109, 89);
            adresTxt.Multiline = true;
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(137, 63);
            adresTxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 101);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 5;
            label2.Text = "Adres";
            label2.Click += label2_Click;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(111, 192);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(125, 27);
            yasTxt.TabIndex = 6;
            // 
            // measiTxt
            // 
            measiTxt.Location = new Point(111, 241);
            measiTxt.Name = "measiTxt";
            measiTxt.Size = new Size(125, 27);
            measiTxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 195);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 8;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 244);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 9;
            label4.Text = "mesai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 295);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "Unvan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(measiTxt);
            Controls.Add(yasTxt);
            Controls.Add(label2);
            Controls.Add(adresTxt);
            Controls.Add(adTxt);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private TextBox adTxt;
        private TextBox adresTxt;
        private Label label2;
        private TextBox yasTxt;
        private TextBox measiTxt;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}