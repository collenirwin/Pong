using System;
using System.Drawing;
using System.Windows.Forms;

namespace pong {

    enum Direction {
        up,
        down,
        none
    }

    public partial class Form1 : Form {

        const int PADDLE_SPEED = 8;
        const int AI_SPEED     = 4;
        const int BALL_SPEED   = 5;

        Direction playerDirection = Direction.none;
        Direction aiDirection     = Direction.none;
        Point ballDirection = new Point(-BALL_SPEED, -BALL_SPEED);

        int playerPoints = 0;
        int aiPoints     = 0;

        public Form1() {
            InitializeComponent();
        }

        private void tmrMain_Tick(object sender, EventArgs e) {

            // moving the player's paddle
            if (playerDirection == Direction.up) {
                if (player.Top + player.Height <= 0) {
                    player.Top = this.Height - 1;
                }

                player.Top -= PADDLE_SPEED;
            } else if (playerDirection == Direction.down) {
                if (player.Top >= this.Height) {
                    player.Top = -player.Height + 1;
                }

                player.Top += PADDLE_SPEED;
            }

            if (ballHit()) {
                ballDirection.X = -ballDirection.X;
            }

            if (ballBounced()) {
                ballDirection.Y = -ballDirection.Y;
            }

            if (playerScored()) {
                playerPoints++;
                reset();
            } else if (aiScored()) {
                aiPoints++;
                reset();
            }

            ball.Left += ballDirection.X;
            ball.Top  += ballDirection.Y;

            decideAIDirection();
            if (aiDirection == Direction.up) {
                ai.Top -= AI_SPEED;
            } else if (aiDirection == Direction.down) {
                ai.Top += AI_SPEED;
            }
        }

        private bool ballHit() {
            return ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(ai.Bounds);
        }

        private bool ballBounced() {
            return ball.Top <= 0 || (ball.Top + (ball.Height * 3)) >= this.Height;
        }

        private bool playerScored() {
            return ball.Left >= this.Width;
        }

        private bool aiScored() {
            return ball.Left <= 0;
        }

        private void reset() {
            ball.Location = new Point(368, 189);
            ballDirection.X = -BALL_SPEED;
            ballDirection.Y = -BALL_SPEED;
            updateScores();
        }

        private void updateScores() {
            lblScores.Text = playerPoints.ToString() + lblScores.Tag.ToString() + aiPoints.ToString();
        }

        private void decideAIDirection() {
            if (ai.Top == ball.Top) {
                aiDirection = Direction.none;
            } else if (ai.Top > ball.Top) {
                aiDirection = Direction.up;
            } else {
                aiDirection = Direction.down;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Up) {
                playerDirection = Direction.up;
            } else if (e.KeyCode == Keys.Down) {
                playerDirection = Direction.down;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            playerDirection = Direction.none;
        }
    }
}
