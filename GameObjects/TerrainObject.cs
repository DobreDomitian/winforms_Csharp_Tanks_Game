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
using TanksGame.GameResources;

namespace TanksGame.GameObjects
{
    internal class TerrainObject : BasicObject
    {
        private int mapLength;
        private float amplitude = 80;
        private float frequency = 0.007f;
        OpenSimplexNoise noise;
        private Bitmap bitmap;
        Random random = new Random();
        public TerrainObject(float x, float y, float width, float height, short[,] PixelMatrix) : base(x, y, height, width)
        {
            mapLength = (int)width;
            noise = new OpenSimplexNoise();
            GenerateMap1DNoise(PixelMatrix);
            bitmap = Convert(PixelMatrix);

        }
        public TerrainObject(float x, float y, float width, float height, short[,] PixelMatrix, long seed, double coef, int amp) : base(x, y, height, width)
        {
            mapLength = (int)width;
            noise = new OpenSimplexNoise(seed);
            GenerateMap1DNoise(PixelMatrix, coef, amp);
            bitmap = Convert(PixelMatrix);

        }
        private float GetNoiseValue(int x, int y)
        {
            return (float)(amplitude * noise.Evaluate(x * frequency, y * frequency));
        }

        private void GenerateMap1DNoise(short[,] PixelMatrix)
        {
            PointF[] points = new PointF[mapLength];
            var coef = 1.2 + random.NextDouble();
            if (coef > 1.5)
                coef = 1.5;
            var amp = random.Next((int)amplitude * 10, (int)amplitude * 1000);
            for (int x = 0; x < mapLength; x++)
            {
                var _noise = (float)(this.Height / coef - Math.Abs(GetNoiseValue(x, amp) * coef));
                points[x].X = x;
                points[x].Y = _noise;
                for (int j = 0; j < this.Height; j++)
                {
                    if (j > points[x].Y)
                        PixelMatrix[x, j] = 0;
                    else
                        PixelMatrix[x, j] = 1;

                }
            }

        }
        private void GenerateMap1DNoise(short[,] PixelMatrix, double coef, int amp)
        {
            PointF[] points = new PointF[mapLength];
            Random random = new Random();
            for (int x = 0; x < mapLength; x++)
            {
                var _noise = (float)(this.Height / coef - Math.Abs(GetNoiseValue(x, amp) * coef));
                points[x].X = x;
                points[x].Y = _noise;
                for (int j = 0; j < this.Height; j++)
                {
                    if (j > points[x].Y)
                        PixelMatrix[x, j] = 0;
                    else
                        PixelMatrix[x, j] = 1;

                }
            }
        }
        private static Bitmap Convert(short[,] PixelMatrix)
        {
            int width = PixelMatrix.GetLength(0);
            int height = PixelMatrix.GetLength(1);

            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    float value = PixelMatrix[x, y];
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
            g.DrawImage(bitmap, 0, 0);
        }
    }
}
