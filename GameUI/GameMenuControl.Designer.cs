namespace GameUI
{
    partial class GameMenuControl
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
            btnHints = new Button();
            btnMainMenu = new Button();
            btnExit = new Button();
            X = new Button();
            SuspendLayout();
            // 
            // btnHints
            // 
            btnHints.Location = new Point(304, 183);
            btnHints.Name = "btnHints";
            btnHints.Size = new Size(75, 23);
            btnHints.TabIndex = 0;
            btnHints.Text = "btnHints";
            btnHints.UseVisualStyleBackColor = true;
            btnHints.Click += btnHints_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(304, 252);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(75, 23);
            btnMainMenu.TabIndex = 1;
            btnMainMenu.Text = "btnMainMenu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(304, 323);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 27);
            btnExit.TabIndex = 2;
            btnExit.Text = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // X
            // 
            X.Location = new Point(3, 3);
            X.Name = "X";
            X.Size = new Size(57, 32);
            X.TabIndex = 3;
            X.Text = "X";
            X.UseVisualStyleBackColor = true;
            X.Click += X_Click;
            // 
            // GameMenuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(X);
            Controls.Add(btnExit);
            Controls.Add(btnMainMenu);
            Controls.Add(btnHints);
            Name = "GameMenuControl";
            Size = new Size(703, 605);
            ResumeLayout(false);
        }

        #endregion

        private Button btnHints;
        private Button btnMainMenu;
        private Button btnExit;
        private Button X;
    }
}
