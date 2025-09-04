namespace GameUI
{
    partial class MainMenuControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuControl));
            RPGGame = new Label();
            btnStart = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // RPGGame
            // 
            RPGGame.AutoSize = true;
            RPGGame.Location = new Point(319, 239);
            RPGGame.Name = "RPGGame";
            RPGGame.Size = new Size(60, 15);
            RPGGame.TabIndex = 0;
            RPGGame.Text = "RPGGame";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(250, 319);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 70);
            btnStart.TabIndex = 1;
            btnStart.Text = "btnStart";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(250, 436);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 70);
            btnExit.TabIndex = 2;
            btnExit.Text = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // MainMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(RPGGame);
            Name = "MainMenuControl";
            Size = new Size(700, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RPGGame;
        private Button btnStart;
        private Button btnExit;
    }
}
