using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace GameUI
{
    public class AnimationPlayer
    {
        private Image[,] animations = new Image[4, 3];
        private int frame = 0;
        private int lastDirection = 0;

        public Image CurrentFrame { get; private set; }

        public AnimationPlayer()
        {
            LoadAnimations();
            CurrentFrame = animations[0, 0];
        }

        private void LoadAnimations()
        {
            string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Player");
            try
            {
                animations[0, 0] = LoadImage(basePath, "player_front.png");
                animations[0, 1] = LoadImage(basePath, "player_front_step_1.png");
                animations[0, 2] = LoadImage(basePath, "player_front_step_2.png");

                animations[1, 0] = LoadImage(basePath, "player_behind.png");
                animations[1, 1] = LoadImage(basePath, "player_behind_step_1.png");
                animations[1, 2] = LoadImage(basePath, "player_behind_step_2.png");

                animations[2, 0] = LoadImage(basePath, "player_right.png");
                animations[2, 1] = LoadImage(basePath, "player_right_step_1.png");
                animations[2, 2] = LoadImage(basePath, "player_right_step_2.png");

                animations[3, 0] = LoadImage(basePath, "player_left.png");
                animations[3, 1] = LoadImage(basePath, "player_left_step_1.png");
                animations[3, 2] = LoadImage(basePath, "player_left_step_2.png");
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка загрузки анимаций игрока: " + ex.Message);
            }
        }

        private Image LoadImage(string path, string fileName)
        {
            string fullPath = Path.Combine(path, fileName);
            if (!File.Exists(fullPath))
                throw new FileNotFoundException("Не найден файл изображения: " + fullPath);

            return Image.FromFile(fullPath);
        }

        public void UpdateFrame(bool movingUp, bool movingDown, bool movingLeft, bool movingRight)
        {
            int direction = GetDirectionIndex(movingUp, movingDown, movingLeft, movingRight);

            if (IsMoving(movingUp, movingDown, movingLeft, movingRight))
            {
                frame = (frame + 1) % 2;
                CurrentFrame = animations[direction, frame + 1];
                lastDirection = direction;
            }
            else
            {
                CurrentFrame = animations[lastDirection, 0];
            }
        }

        private int GetDirectionIndex(bool up, bool down, bool left, bool right)
        {
            if (up) return 1;
            if (down) return 0;
            if (right) return 2;
            if (left) return 3;
            return lastDirection;
        }

        private bool IsMoving(bool up, bool down, bool left, bool right)
        {
            return up || down || left || right;
        }
    }
}
