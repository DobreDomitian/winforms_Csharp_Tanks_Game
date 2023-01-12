using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame.GameObjects
{
    abstract class BasicObject
    {
        protected float X { get; set; }
        protected float Y { get; set; }
        protected float Height { get; set; }
        protected float Width { get; set; }

        public BasicObject(float x, float y, float height, float width)
        {
            this.X = x;
            this.Y = y;
            this.Height = height;
            this.Width = width;
        }
        public bool checkCollision(BasicObject Base1, BasicObject Base2)
        {
            double Base1_centerX = Base1.X + Base1.Width / 2.0;
            double Base1_centerY = Base1.Y + Base1.Height / 2.0;

            double Base2_centerX = Base2.X + Base2.Width / 2.0;
            double Base2_centerY = Base2.Y + Base2.Height / 2.0;

            double distX = Math.Abs(Base1_centerX - Base2_centerX);
            double distY = Math.Abs(Base1_centerY - Base2_centerY);

            double sum_width = Base1.Width / 2.0 + Base2.Width / 2.0;
            double sum_height = Base1.Height / 2.0 + Base2.Height / 2.0;

            return (distX <= sum_width && distY <= sum_height);

        }
        public abstract void DrawObject(Graphics g);
    }
}
