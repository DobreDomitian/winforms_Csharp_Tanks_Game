using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace TanksGame_V4.GameObjects
{
    internal class TankObject : BasicObject
    {
        private int playerNumber;
        private int tankNumber;
        private Image Player_Image;
        private Size ImageSize;
        private PointF Location;
        ProjectileObject projectileObject;
        public int Turret_angle { get; set; }
        public int Shot_power { get; set; }
        private double angle_rad;
        private Pen Turret_pen;
        private Font font;
        public int Health { get; set; }
        private PointF Turret_End;
        private PointF Turret_Start;
        Random random = new Random();
        public TankObject(int tankNumber, int playerNumber, float x, float y, float width, float height, short[,] PMatrix) : base(x, y, width, height)
        {
            this.playerNumber = playerNumber;
            this.tankNumber = tankNumber;
            Turret_pen = new Pen(Color.FromArgb(20, 50, 3), 5);
            if (tankNumber % 2 == 0)
            {
                Turret_angle = 60;
                Player_Image = Image.FromFile(Path.GetFullPath("GameResources/Tank1_3_48x32.png"));
            }
            else
            {
                Turret_angle = 120;
                Player_Image = Image.FromFile(Path.GetFullPath("GameResources/Tank2_1_48x32.png"));
            }
            ImageSize = Player_Image.Size;
            Shot_power = 100;
            Health = 100;
            font = new Font("Arial", 8);
            GenerateTank(PMatrix);
        }
        private void GenerateTank(short[,] PMatrix)
        {
            int step = (int)(this.Width / playerNumber);
            int startpoint = random.Next(step * tankNumber + ImageSize.Width, step * (tankNumber + 1) - ImageSize.Width);
            for (int i = PMatrix.GetLength(1) - 1; i > 0; i--)
            {
                if (PMatrix[startpoint + ImageSize.Width / 2, i] == 1)
                {
                    this.X = startpoint;
                    this.Y = (int)(i - ImageSize.Height / 1.3);
                    break;
                }
            }

        }
        public override void DrawObject(Graphics graphicObj)
        {
            GenerateTankTurret(graphicObj);
            
            graphicObj.DrawImage(Player_Image, this.X, this.Y);
            graphicObj.DrawString("P" + (tankNumber+1).ToString(), font,Brushes.Blue,Location.X+(tankNumber%2)*ImageSize.Width/2,Location.Y-ImageSize.Height);
            graphicObj.DrawString("HP P" + (tankNumber + 1).ToString(), font, Brushes.Blue, this.Width - 239, tankNumber * 20);
            graphicObj.DrawRectangle(Pens.Black, new Rectangle((int)this.Width - 206, tankNumber * 20, 201, 17));
            graphicObj.FillRectangle(Brushes.LightGreen, new RectangleF(this.Width - 205, tankNumber * 20, Health*2, 16)) ;
        }

        public void MoveTank(short[,] PMatrix, int value)
        {

            if (Location.X + value < PMatrix.GetLength(0) - ImageSize.Width && this.X + value > ImageSize.Width / 2)
            {
                this.X +=value;
                for (int i = PMatrix.GetLength(1) - 1; i > 0; i--)
                {
                    if (PMatrix[(int)this.X + ImageSize.Width / 2, i] == 1)
                    {
                        this.Y = (int)(i - ImageSize.Height / 1.3);
                        break;
                    }
                }
            }
        }
        private void GenerateTankTurret(Graphics graphicObj)
        {
            const int len = 20;
            angle_rad = Turret_angle * (Math.PI / 180.0);
            Turret_Start.X = (int)(this.X + (ImageSize.Width / 2));
            Turret_Start.Y = (int)(this.Y + ImageSize.Height / 2.7);
            Turret_End.X = Turret_Start.X + (float)(len * Math.Cos(angle_rad));
            Turret_End.Y = Turret_Start.Y - (float)(len * Math.Sin(angle_rad));
            graphicObj.DrawLine(Turret_pen, new PointF(Turret_Start.X, Turret_Start.Y), new PointF(Turret_End.X, Turret_End.Y));
            
        }
        //public void Shoot( TankObject[] tankObjects, short[,]PMatrix, Graphics g)
        //{
        //    PointF p = new PointF();
        //    PointF MaxH = new PointF();
        //    var Vx = Shot_power * Math.Cos(angle_rad);
        //    var Vy = Shot_power * Math.Sin(angle_rad);
        //    MaxH.X = Turret_End.X + (float)(Turret_End.Y + (Vy * Vy) / (2 * 10));
        //    MaxH.Y = Turret_End.Y + (float)((Vy / (2 * 10)) * Vx);
        //    var range = Location.X + (Vx / 10) * (Vy + Math.Sqrt((Vy * Vy) + 2 * 10 * Turret_End.Y) / 100);
        //    for (int i = PMatrix.GetLength(1) - 1; i > 0; i--)
        //    {
        //        if (PMatrix[(int)range, i] == 1)
        //        {
        //            p.X = (int)range;
        //            p.Y = i;
        //        }
        //    }
        //    this.projectileObject = new ProjectileObject(Turret_End.X, Turret_End.Y, this.Width, this.Height);
        //}
    }
}
