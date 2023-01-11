using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanksGame_V4.GameObjects;
using TanksGame_V4;
using System.Drawing.Imaging;

namespace TanksGame_V4.Interface
{
    internal class GamePanel : Panel
    {
        private GameForm gameForm { get; set; }
        private TerrainObject terrainObj;
        private TankObject[] tankObject;
        private int playerNumber;
        private short[,] PMatrix;
        private int turnTimer;
        private int currentTankTurn;
        private int moves;
        private int _gameMode;
        Timer gameTimer;
        Font font;
        private bool fired;
        public GamePanel(GameForm gameForm)
        {
            this.gameForm = gameForm;
            this.DoubleBuffered = true;
            this.Dock = DockStyle.Fill;
            
            this.gameForm.Controls.Add(this);
            this.gameForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.gameForm.KeyDown += GameForm_KeyDown;
            this.gameForm.KeyPreview = true;
            font = new Font("Arian", 12, FontStyle.Bold);
        }

        public void StartGame(TerrainObject terrainObj, TankObject[] tankObj, int playerNumber, short[,] PMatrix)
        {
            gameTimer = new Timer();
            gameTimer.Interval = 50;
            gameTimer.Tick += GameTimer_Update;
            gameTimer.Start();
            turnTimer = 0;
            moves = 10;
            currentTankTurn = 0;
            this.terrainObj = terrainObj;
            this.tankObject = tankObj;
            this.playerNumber = playerNumber;
            this.Visible = true;
            this.PMatrix = PMatrix;
            gameForm.ShowInTaskbar = true;
            
        }
        protected void DrawGame(Graphics g)
        {
            try
            {
                terrainObj.DrawObject(g);
                for (int i = 0; i < tankObject.Length; i++)
                {
                    tankObject[i].DrawObject(g);
                }
                g.DrawString("Moves Left for P" + (currentTankTurn+1).ToString() + " : " + moves.ToString(), font, Brushes.Red, 0f, 0f);
                g.DrawString("Time Left for P" + (currentTankTurn+1).ToString() + " : " + (30 - (turnTimer / 20)).ToString(), font, Brushes.Purple, 0f, 30f);
                g.DrawString("Shoot Power for P" + (currentTankTurn + 1).ToString() + " : " + tankObject[currentTankTurn].Shot_power.ToString(), font, Brushes.DarkRed, 0f, 60f);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            DrawGame(e.Graphics);
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            Debug.Print(e.KeyValue.ToString());
            Random random = new Random();
            switch (e.KeyCode)
            {
                
                case (Keys.D):
                    {
                        if (moves > 0)
                        {
                            tankObject[currentTankTurn].MoveTank(PMatrix, 2);
                            moves -= 1;
                        }
                        this.Invalidate();
                        break;
                    }
                case (Keys.A):
                    {
                        if (moves > 0)
                        {
                            tankObject[currentTankTurn].MoveTank(PMatrix, -2);
                            moves -= 1;
                        }
                        this.Invalidate();
                        break;
                    }
                case (Keys.Left):
                    {
                        if (tankObject[currentTankTurn].Turret_angle < 180)
                            tankObject[currentTankTurn].Turret_angle += 1;
                        this.Invalidate();
                        break;
                    }
                case(Keys.Right):
                    {
                        if(tankObject[currentTankTurn].Turret_angle >0)
                            tankObject[currentTankTurn].Turret_angle += -1;
                        this.Invalidate();
                        break;
                    }
                case (Keys.Up):
                    {
                        if (tankObject[currentTankTurn].Shot_power < 100)
                            tankObject[currentTankTurn].Shot_power += 1;
                        this.Invalidate();
                        break;
                    }
                case (Keys.Down):
                    {
                        if (tankObject[currentTankTurn].Shot_power > 1)
                            tankObject[currentTankTurn].Shot_power += -1;
                        this.Invalidate();
                        break;
                    }
                case (Keys.Space):
                    {
                        fired = true;
                        this.Invalidate();
                        break;
                    }
            }
            e.Handled = true;
        }
        private void GameTimer_Update(object sender, EventArgs e)
        {
            this.Invalidate();
            turnTimer += 1;
            if(turnTimer ==600 || fired)
            {
                fired = false;
                gameTimer.Interval = 50;
                currentTankTurn += 1;
                currentTankTurn = currentTankTurn % playerNumber;
                moves = 10;
                turnTimer = 0;
            }
        }
    }
}
