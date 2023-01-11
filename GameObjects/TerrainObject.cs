using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using TanksGame_V4.GameResources;

namespace TanksGame_V4.GameObjects
{
    internal class TerrainObject : BasicObject
    {
        private int _mapLength;
        private float amplitude = 80;
        private float frequency = 0.007f;
        OpenSimplexNoise noise;
        private Bitmap _bitmap;
        Random random = new Random();
        public TerrainObject(float x, float y, float width, float height, short[,] PMatrix) : base(x, y, height, width)
        {
            _mapLength = (int)width;
            noise = new OpenSimplexNoise();
            GenerateMap1DNoise(PMatrix);
            _bitmap = Convert(PMatrix);

        }
        public TerrainObject(float x, float y, float width, float height, short[,] PMatrix, long seed, double coef, int amp) : base(x, y, height, width)
        {
            _mapLength = (int)width;
            noise = new OpenSimplexNoise(seed);
            GenerateMap1DNoise(PMatrix, coef, amp);
            _bitmap = Convert(PMatrix);

        }
        private float GetNoiseValue(int x, int y)
        {
            return (float)(amplitude * noise.Evaluate(x * frequency, y * frequency));
        }

        private void GenerateMap1DNoise(short[,] PMatrix)
        {
            PointF[] points = new PointF[_mapLength];
            var coef = 1.2 + random.NextDouble();
            if (coef > 1.5)
                coef = 1.5;
            var amp = random.Next((int)amplitude * 10, (int)amplitude * 1000);
            for (int x = 0; x < _mapLength; x++)
            {
                var _noise = (float)(this.Height / coef - Math.Abs(GetNoiseValue(x, amp) * coef));
                points[x].X = x;
                points[x].Y = _noise;
                for (int j = 0; j < this.Height; j++)
                {
                    if (j > points[x].Y)
                        PMatrix[x, j] = 0;
                    else
                        PMatrix[x, j] = 1;

                }
            }

        }
        private void GenerateMap1DNoise(short[,] PMatrix, double coef, int amp)
        {
            PointF[] points = new PointF[_mapLength];
            Random random = new Random();
            for (int x = 0; x < _mapLength; x++)
            {
                var _noise = (float)(this.Height / coef - Math.Abs(GetNoiseValue(x, amp) * coef));
                points[x].X = x;
                points[x].Y = _noise;
                for (int j = 0; j < this.Height; j++)
                {
                    if (j > points[x].Y)
                        PMatrix[x, j] = 0;
                    else
                        PMatrix[x, j] = 1;

                }
            }
        }
        private static Bitmap Convert(short[,] matrix)
        {
            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);

            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    float value = matrix[x, y];
                    switch (value)
                    {
                        case 1:
                            bitmap.SetPixel(x, y, Color.LightSkyBlue);
                            break;
                        case 0:
                            bitmap.SetPixel(x, y, Color.Green);
                            break;
                        default:
                            bitmap.SetPixel(x, y, Color.LightSkyBlue);
                            break;
                    }


                }
            }

            return bitmap;
        }

        public override void DrawObject(Graphics g)
        {
            g.DrawImage(_bitmap, 0, 0);
        }
    }
}
