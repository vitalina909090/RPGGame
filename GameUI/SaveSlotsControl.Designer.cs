namespace GameUI
{
    partial class SaveSlotsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveSlotsControl));
            btnSlot1 = new Button();
            btnSlot2 = new Button();
            btnSlot3 = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnSlot1
            // 
            btnSlot1.Location = new Point(247, 223);
            btnSlot1.Name = "btnSlot1";
            btnSlot1.Size = new Size(200, 70);
            btnSlot1.TabIndex = 0;
            btnSlot1.Text = "btnSlot1";
            btnSlot1.UseVisualStyleBackColor = true;
            btnSlot1.Click += btnSlot1_Click;
            // 
            // btnSlot2
            // 
            btnSlot2.Location = new Point(247, 326);
            btnSlot2.Name = "btnSlot2";
            btnSlot2.Size = new Size(200, 70);
            btnSlot2.TabIndex = 1;
            btnSlot2.Text = "btnSlot2";
            btnSlot2.UseVisualStyleBackColor = true;
            btnSlot2.Click += btnSlot2_Click_1;
            // 
            // btnSlot3
            // 
            btnSlot3.Location = new Point(247, 437);
            btnSlot3.Name = "btnSlot3";
            btnSlot3.Size = new Size(200, 70);
            btnSlot3.TabIndex = 2;
            btnSlot3.Text = "btnSlot3";
            btnSlot3.UseVisualStyleBackColor = true;
            btnSlot3.Click += btnSlot3_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(17, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 70);
            btnBack.TabIndex = 3;
            btnBack.Text = "btnBack";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // SaveSlotsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnBack);
            Controls.Add(btnSlot3);
            Controls.Add(btnSlot2);
            Controls.Add(btnSlot1);
            Name = "SaveSlotsControl";
            Size = new Size(700, 700);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSlot1;
        private Button btnSlot2;
        private Button btnSlot3;
        private Button btnBack;
    }
}
