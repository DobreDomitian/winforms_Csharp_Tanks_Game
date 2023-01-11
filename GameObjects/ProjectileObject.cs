using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TanksGame_V4.Interface;

namespace TanksGame_V4.GameObjects
{
    internal class ProjectileObject : BasicObject
    {
        private Image Projectile_Image;
        private Image Explosion_Image;
        private Size ImageSize;
        public ProjectileObject(float x, float y, float width, float height) : base(x, y, height, width)
        {
            Projectile_Image = Image.FromFile(Path.GetFullPath("GameResources/index32x32.png"));
            Explosion_Image = Image.FromFile(Path.GetFullPath("GameResources/Explosion32x32.png"));
            ImageSize = Projectile_Image.Size;
            this.Width = ImageSize.Width;
            this.Height = ImageSize.Height;
        }

        public override void DrawObject(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}