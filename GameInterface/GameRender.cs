using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanksGame_V4.GameObjects;
using TanksGame_V4;
using TanksGame_V4.GameServer;

namespace TanksGame_V4.Interface
{

    internal class GameRender
    {
        GameForm gameForm;
        private short[,] PixelMatrix;
        public GameRender(GameForm gameForm, int playerNumber)
        {
            this.gameForm = gameForm;
            PixelMatrix = new short[gameForm.ClientSize.Width, gameForm.ClientSize.Height];
            GamePanel gamePanel = new GamePanel(gameForm);
            gameForm.Controls.Add(gamePanel);
            gamePanel.StartGame(this.CreateTerrain(), this.CreateTanks(playerNumber), playerNumber, PixelMatrix);
        }
        public GameRender(GameForm gameForm, int playerNumber, Host _host)
        {
            this.gameForm = gameForm;
            PixelMatrix = new short[gameForm.ClientSize.Width, gameForm.ClientSize.Height];
            GamePanel gamePanel = new GamePanel(gameForm);
            gameForm.Controls.Add(gamePanel);
            Random random = new Random();
            var seed = random.Next();
            var coef = 1.2 + random.NextDouble();
            if (coef > 1.5)
                coef = 1.5;
            var amp = random.Next((int)80 * 10, (int)80 * 1000);
            _host._gameData = seed.ToString() + " " + coef.ToString() + amp
            gamePanel.StartGame(this.CreateTerrain(seed, coef,amp), this.CreateTanks(playerNumber), playerNumber, PixelMatrix);
            
        }
        public GameRender(GameForm gameForm, int playerNumber, short[,] pixelMatrix, Client _client)
        {
            this.gameForm = gameForm;
            GamePanel gamePanel = new GamePanel(gameForm);
            gameForm.Controls.Add(gamePanel);
            PixelMatrix = new short[gameForm.ClientSize.Width, gameForm.ClientSize.Height];
            gamePanel.StartGame(this.CreateTerrain(), this.CreateTanks(playerNumber), playerNumber, PixelMatrix);
        }

        private TerrainObject CreateTerrain()
        {
            TerrainObject terrainObject = new TerrainObject(0, (float)(gameForm.ClientSize.Height / 1.5), gameForm.ClientSize.Width, gameForm.ClientSize.Height, PixelMatrix);
            return terrainObject;
        }
        private TerrainObject CreateTerrain(long seed, double coef, int amp )
        {
            TerrainObject terrainObject = new TerrainObject(0, (float)(gameForm.ClientSize.Height / 1.5), gameForm.ClientSize.Width, gameForm.ClientSize.Height, PixelMatrix, seed, coef, amp);
            return terrainObject;
        }
        private TankObject[] CreateTanks(int playerNumber)
        {
            TankObject[] tanks = new TankObject[playerNumber];
            for(int i = 0; i < playerNumber; i++)
            {
                TankObject tankObject = new TankObject(i,playerNumber,0,(float)(gameForm.ClientSize.Height / 1.5), gameForm.ClientSize.Height, gameForm.ClientSize.Width, PixelMatrix);
                tanks[i] = tankObject;
            }
            return tanks;
        }
    }
}

