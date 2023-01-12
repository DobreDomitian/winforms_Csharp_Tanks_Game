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

namespace TanksGame.GameObjects
{
    internal class TankObject : BasicObject
    {
        private int playerNumber;
        private int tankNumber;
        private Image PlayerImage;
        private Size ImageSize;
        ProjectileObject projectileObj;
        public int turretAngle { get; set; }
        public int shotPower { get; set; }
        private double angleRad;
        private Pen turretPen;
        private Font font;
        public int health { get; set; }
        private PointF turretEnd;
        private PointF turretStart;
        Random random = new Random();
        public TankObject(int tankNumber, int playerNumber, float x, float y, float width, float height, short[,] PMatrix) : base(x, y, width, height)
        {
            this.playerNumber = playerNumber;
            this.tankNumber = tankNumber;
            turretPen = new Pen(Color.FromArgb(20, 50, 3), 5);
            if (tankNumber % 2 == 0)
            {
                turretAngle = 60;
                PlayerImage = Image.FromFile(Path.GetFullPath("GameResources/Tank1_3_48x32.png"));
            }
            else
            {
                turretAngle = 120;
                PlayerImage = Image.FromFile(Path.GetFullPath("GameResources/Tank2_1_48x32.png"));
            }
            ImageSize = PlayerImage.Size;
            shotPower = 100;
            health = 100;
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
            
            graphicObj.DrawImage(PlayerImage, this.X, this.Y);
            graphicObj.DrawString("P" + (tankNumber+1).ToString(), font,Brushes.Blue,this.X+(tankNumber%2)*ImageSize.Width/2,this.Y-ImageSize.Height);
            graphicObj.DrawString("HP P" + (tankNumber + 1).ToString(), font, Brushes.Blue, this.Width - 239, tankNumber * 20);
            graphicObj.DrawRectangle(Pens.Black, new Rectangle((int)this.Width - 206, tankNumber * 20, 201, 17));
            graphicObj.FillRectangle(Brushes.LightGreen, new RectangleF(this.Width - 205, tankNumber * 20, health*2, 16)) ;
        }

        public void MoveTank(short[,] PMatrix, int value)
        {

            if (this.X + value < PMatrix.GetLength(0) - ImageSize.Width && this.X + value > ImageSize.Width / 2)
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
            angleRad = turretAngle * (Math.PI / 180.0);
            turretStart.X = (int)(this.X + (ImageSize.Width / 2));
            turretStart.Y = (int)(this.Y + ImageSize.Height / 2.7);
            turretEnd.X = turretStart.X + (float)(len * Math.Cos(angleRad));
            turretEnd.Y = turretStart.Y - (float)(len * Math.Sin(angleRad));
            graphicObj.DrawLine(turretPen, new PointF(turretStart.X, turretStart.Y), new PointF(turretEnd.X, turretEnd.Y));
            
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
