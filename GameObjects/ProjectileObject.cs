using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TanksGame.Interface;

namespace TanksGame.GameObjects
{
    internal class ProjectileObject : BasicObject
    {
        private Image ProjectileImage;
        private Image ExplosionImage;
        private Size expImageSize;
        private Size projectileImageSize;
        public ProjectileObject(float x, float y, float width, float height) : base(x, y, height, width)
        {
            ProjectileImage = Image.FromFile(Path.GetFullPath("GameResources/index32x32.png"));
            ExplosionImage = Image.FromFile(Path.GetFullPath("GameResources/Explosion32x32.png"));
            projectileImageSize = ProjectileImage.Size;
            expImageSize = ExplosionImage.Size;
        }

        public override void DrawObject(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}