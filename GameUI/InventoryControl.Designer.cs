namespace GameUI
{
    partial class InventoryControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblHealth = new Label();
            lblExperience = new Label();
            lblGold = new Label();
            lblWeapon = new Label();
            lblArmor = new Label();
            lstItems = new ListBox();
            X = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(406, 23);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(55, 15);
            lblHealth.TabIndex = 0;
            lblHealth.Text = "lblHealth";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(406, 52);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(77, 15);
            lblExperience.TabIndex = 1;
            lblExperience.Text = "lblExperience";
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(406, 76);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(45, 15);
            lblGold.TabIndex = 2;
            lblGold.Text = "lblGold";
            // 
            // lblWeapon
            // 
            lblWeapon.AutoSize = true;
            lblWeapon.Location = new Point(406, 103);
            lblWeapon.Name = "lblWeapon";
            lblWeapon.Size = new Size(64, 15);
            lblWeapon.TabIndex = 3;
            lblWeapon.Text = "lblWeapon";
            // 
            // lblArmor
            // 
            lblArmor.AutoSize = true;
            lblArmor.Location = new Point(407, 128);
            lblArmor.Name = "lblArmor";
            lblArmor.Size = new Size(54, 15);
            lblArmor.TabIndex = 4;
            lblArmor.Text = "lblArmor";
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.Location = new Point(338, 295);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(255, 199);
            lstItems.TabIndex = 5;
            lstItems.DoubleClick += lstItems_DoubleClick;
            // 
            // X
            // 
            X.Location = new Point(3, 3);
            X.Name = "X";
            X.Size = new Size(43, 23);
            X.TabIndex = 6;
            X.Text = "X";
            X.UseVisualStyleBackColor = true;
            X.Click += X_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "Здоровье:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 52);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Опыт:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 76);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 9;
            label3.Text = "Золото:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 267);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 10;
            label4.Text = "Предметы:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 128);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Броня:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(338, 103);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Оружие:";
            // 
            // InventoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(X);
            Controls.Add(lstItems);
            Controls.Add(lblArmor);
            Controls.Add(lblWeapon);
            Controls.Add(lblGold);
            Controls.Add(lblExperience);
            Controls.Add(lblHealth);
            Name = "InventoryControl";
            Size = new Size(647, 542);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHealth;
        private Label lblExperience;
        private Label lblGold;
        private Label lblWeapon;
        private Label lblArmor;
        private ListBox lstItems;
        private Button X;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
