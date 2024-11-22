
namespace SkladKurylev
{
    partial class SkladPage
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
            this.ManagerdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductdataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NewManager = new System.Windows.Forms.Button();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.VvodName = new System.Windows.Forms.Label();
            this.SurenametextBox2 = new System.Windows.Forms.TextBox();
            this.VvodSurename = new System.Windows.Forms.Label();
            this.RolecomboBox1 = new System.Windows.Forms.ComboBox();
            this.Role = new System.Windows.Forms.Label();
            this.DeleteManager = new System.Windows.Forms.Button();
            this.IdtextBox3 = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagerdataGridView1
            // 
            this.ManagerdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerdataGridView1.Location = new System.Drawing.Point(12, 45);
            this.ManagerdataGridView1.Name = "ManagerdataGridView1";
            this.ManagerdataGridView1.Size = new System.Drawing.Size(446, 146);
            this.ManagerdataGridView1.TabIndex = 0;
            this.ManagerdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(12, 408);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(99, 30);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Менеджеры";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductdataGridView2
            // 
            this.ProductdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductdataGridView2.Location = new System.Drawing.Point(495, 45);
            this.ProductdataGridView2.Name = "ProductdataGridView2";
            this.ProductdataGridView2.Size = new System.Drawing.Size(535, 146);
            this.ProductdataGridView2.TabIndex = 6;
            this.ProductdataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продукция";
            // 
            // NewManager
            // 
            this.NewManager.Location = new System.Drawing.Point(11, 317);
            this.NewManager.Name = "NewManager";
            this.NewManager.Size = new System.Drawing.Size(240, 29);
            this.NewManager.TabIndex = 8;
            this.NewManager.Text = "Добавить менеджера";
            this.NewManager.UseVisualStyleBackColor = true;
            this.NewManager.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(11, 214);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(240, 20);
            this.NametextBox1.TabIndex = 10;
            // 
            // VvodName
            // 
            this.VvodName.AutoSize = true;
            this.VvodName.Location = new System.Drawing.Point(12, 198);
            this.VvodName.Name = "VvodName";
            this.VvodName.Size = new System.Drawing.Size(72, 13);
            this.VvodName.TabIndex = 11;
            this.VvodName.Text = "Введите имя";
            // 
            // SurenametextBox2
            // 
            this.SurenametextBox2.Location = new System.Drawing.Point(11, 253);
            this.SurenametextBox2.Name = "SurenametextBox2";
            this.SurenametextBox2.Size = new System.Drawing.Size(240, 20);
            this.SurenametextBox2.TabIndex = 12;
            // 
            // VvodSurename
            // 
            this.VvodSurename.AutoSize = true;
            this.VvodSurename.Location = new System.Drawing.Point(9, 237);
            this.VvodSurename.Name = "VvodSurename";
            this.VvodSurename.Size = new System.Drawing.Size(100, 13);
            this.VvodSurename.TabIndex = 13;
            this.VvodSurename.Text = "Введите фамилию";
            this.VvodSurename.Click += new System.EventHandler(this.label4_Click);
            // 
            // RolecomboBox1
            // 
            this.RolecomboBox1.FormattingEnabled = true;
            this.RolecomboBox1.Items.AddRange(new object[] {
            "Менеджер"});
            this.RolecomboBox1.Location = new System.Drawing.Point(11, 290);
            this.RolecomboBox1.Name = "RolecomboBox1";
            this.RolecomboBox1.Size = new System.Drawing.Size(240, 21);
            this.RolecomboBox1.TabIndex = 14;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(12, 276);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(84, 13);
            this.Role.TabIndex = 15;
            this.Role.Text = "Выберете роль";
            // 
            // DeleteManager
            // 
            this.DeleteManager.Location = new System.Drawing.Point(257, 317);
            this.DeleteManager.Name = "DeleteManager";
            this.DeleteManager.Size = new System.Drawing.Size(201, 29);
            this.DeleteManager.TabIndex = 16;
            this.DeleteManager.Text = "Удалить менеджера";
            this.DeleteManager.UseVisualStyleBackColor = true;
            this.DeleteManager.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdtextBox3
            // 
            this.IdtextBox3.Location = new System.Drawing.Point(257, 290);
            this.IdtextBox3.Name = "IdtextBox3";
            this.IdtextBox3.Size = new System.Drawing.Size(201, 20);
            this.IdtextBox3.TabIndex = 17;
            this.IdtextBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(257, 256);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(143, 26);
            this.Id.TabIndex = 18;
            this.Id.Text = "Для удаления/обновления\r\n введите код сотрудника";
            this.Id.Click += new System.EventHandler(this.label6_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(11, 352);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(447, 23);
            this.Update.TabIndex = 19;
            this.Update.Text = "Обновить данные";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button3_Click);
            // 
            // SkladPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 451);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.IdtextBox3);
            this.Controls.Add(this.DeleteManager);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.RolecomboBox1);
            this.Controls.Add(this.VvodSurename);
            this.Controls.Add(this.SurenametextBox2);
            this.Controls.Add(this.VvodName);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.NewManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductdataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ManagerdataGridView1);
            this.Name = "SkladPage";
            this.Text = "SkladPage";
            this.Load += new System.EventHandler(this.SkladPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductdataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ManagerdataGridView1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductdataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewManager;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.Label VvodName;
        private System.Windows.Forms.TextBox SurenametextBox2;
        private System.Windows.Forms.Label VvodSurename;
        private System.Windows.Forms.ComboBox RolecomboBox1;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Button DeleteManager;
        private System.Windows.Forms.TextBox IdtextBox3;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button Update;
    }
}