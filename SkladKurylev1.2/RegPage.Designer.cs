namespace SkladKurylev
{
    partial class RegPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameRegTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurenameRegTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogRegTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PassRegTextBox = new System.Windows.Forms.TextBox();
            this.RegButton2 = new System.Windows.Forms.Button();
            this.BackWelcomPageButton1 = new System.Windows.Forms.Button();
            this.RoleRegComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameRegTextBox
            // 
            this.NameRegTextBox.Location = new System.Drawing.Point(308, 144);
            this.NameRegTextBox.Name = "NameRegTextBox";
            this.NameRegTextBox.Size = new System.Drawing.Size(193, 20);
            this.NameRegTextBox.TabIndex = 0;
            this.NameRegTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(304, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // SurenameRegTextBox
            // 
            this.SurenameRegTextBox.Location = new System.Drawing.Point(308, 190);
            this.SurenameRegTextBox.Name = "SurenameRegTextBox";
            this.SurenameRegTextBox.Size = new System.Drawing.Size(193, 20);
            this.SurenameRegTextBox.TabIndex = 2;
            this.SurenameRegTextBox.TextChanged += new System.EventHandler(this.SurenameRegTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(304, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Логин";
            // 
            // LogRegTextBox
            // 
            this.LogRegTextBox.Location = new System.Drawing.Point(308, 234);
            this.LogRegTextBox.Name = "LogRegTextBox";
            this.LogRegTextBox.Size = new System.Drawing.Size(193, 20);
            this.LogRegTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(304, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // PassRegTextBox
            // 
            this.PassRegTextBox.Location = new System.Drawing.Point(308, 277);
            this.PassRegTextBox.Name = "PassRegTextBox";
            this.PassRegTextBox.Size = new System.Drawing.Size(193, 20);
            this.PassRegTextBox.TabIndex = 6;
            // 
            // RegButton2
            // 
            this.RegButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton2.Location = new System.Drawing.Point(308, 303);
            this.RegButton2.Name = "RegButton2";
            this.RegButton2.Size = new System.Drawing.Size(193, 38);
            this.RegButton2.TabIndex = 8;
            this.RegButton2.Text = "Зарегистрироваться";
            this.RegButton2.UseVisualStyleBackColor = true;
            this.RegButton2.Click += new System.EventHandler(this.RegButton2_Click);
            // 
            // BackWelcomPageButton1
            // 
            this.BackWelcomPageButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackWelcomPageButton1.Location = new System.Drawing.Point(348, 372);
            this.BackWelcomPageButton1.Name = "BackWelcomPageButton1";
            this.BackWelcomPageButton1.Size = new System.Drawing.Size(111, 34);
            this.BackWelcomPageButton1.TabIndex = 9;
            this.BackWelcomPageButton1.Text = "Назад";
            this.BackWelcomPageButton1.UseVisualStyleBackColor = true;
            this.BackWelcomPageButton1.Click += new System.EventHandler(this.button2_Click);
            // 
            // RoleRegComboBox
            // 
            this.RoleRegComboBox.FormattingEnabled = true;
            this.RoleRegComboBox.Items.AddRange(new object[] {
            "Менеджер",
            "Директор"});
            this.RoleRegComboBox.Location = new System.Drawing.Point(308, 97);
            this.RoleRegComboBox.Name = "RoleRegComboBox";
            this.RoleRegComboBox.Size = new System.Drawing.Size(193, 21);
            this.RoleRegComboBox.TabIndex = 10;
            this.RoleRegComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleRegComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(304, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Роль";
            // 
            // RegPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoleRegComboBox);
            this.Controls.Add(this.BackWelcomPageButton1);
            this.Controls.Add(this.RegButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PassRegTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogRegTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurenameRegTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameRegTextBox);
            this.Name = "RegPage";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameRegTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurenameRegTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LogRegTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassRegTextBox;
        private System.Windows.Forms.Button RegButton2;
        private System.Windows.Forms.Button BackWelcomPageButton1;
        private System.Windows.Forms.ComboBox RoleRegComboBox;
        private System.Windows.Forms.Label label5;
    }
}