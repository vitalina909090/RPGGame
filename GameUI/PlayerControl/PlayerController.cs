using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GameUI
{
    public class PlayerController
    {
        private readonly PlayerSettings player;
        private readonly AnimationPlayer animationPlayer;

        private bool movingUp, movingDown, movingLeft, movingRight;

        public PlayerController(PlayerSettings player, AnimationPlayer animationPlayer)
        {
            this.player = player;
            this.animationPlayer = animationPlayer;
        }

        public void OnKeyDown(Keys key)
        {
            switch (key)
            {
                case Keys.W: movingUp = true; break;
                case Keys.S: movingDown = true; break;
                case Keys.A: movingLeft = true; break;
                case Keys.D: movingRight = true; break;
            }
        }

        public void OnKeyUp(Keys key)
        {
            switch (key)
            {
                case Keys.W: movingUp = false; break;
                case Keys.S: movingDown = false; break;
                case Keys.A: movingLeft = false; break;
                case Keys.D: movingRight = false; break;
            }
        }

        public void Update(Rectangle bounds)
        {
            if (movingUp && player.Top > bounds.Top)
                player.Top -= player.Speed;

            if (movingDown && player.Bottom < bounds.Bottom)
                player.Top += player.Speed;

            if (movingLeft && player.Left > bounds.Left)
                player.Left -= player.Speed;

            if (movingRight && player.Right < bounds.Right)
                player.Left += player.Speed;

            animationPlayer.UpdateFrame(movingUp, movingDown, movingLeft, movingRight);
        }

        public Image GetCurrentFrame()
        {
            return animationPlayer.CurrentFrame;
        }

        public Point GetPosition()
        {
            return player.Location;
        }
    }
}