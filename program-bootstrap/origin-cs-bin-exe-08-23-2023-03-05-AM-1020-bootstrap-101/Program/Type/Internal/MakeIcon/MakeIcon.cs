using Core;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Drawing.Imaging;

    internal partial class Program
    {
        internal void MakeIcon(String path, Color foregroundColor, Color backgroundColor, Single impact, Int32 scale)
        {
            Bitmap bitmap;

            bitmap = new Bitmap(512, 512);

            using (bitmap)
            {
                Graphics graphics;

                using (graphics = Graphics.FromImage(bitmap))
                {
                    graphics.Clear(backgroundColor);

                    Brush brush;

                    brush = new SolidBrush(foregroundColor);

                    Single wave;
                    
                    wave = (impact / 2);

                    Int32 half;

                    half = (Int32)wave;

                    Int32 predecimal, subdecimal;

                    predecimal = (Int32)(Math.Round(wave) - Math.Floor(wave));

                    subdecimal = (Int32)Math.Ceiling(wave - Math.Truncate(wave));

                    Pen pen;

                    pen = new Pen(brush, impact);

                    var size = (512 / scale);

                    Int32 x, y, width, height;

                    x = (0 + size);

                    y = (0 + size);

                    width = (bitmap.Width - size);

                    height = (bitmap.Height - size);

                    width = width - size;

                    height = height - size;

                    var random = Immutable.ProgramRandom.Next(1, 5);

                    Boolean usesPen, usesBrush;

                    usesPen = false;

                    usesPen = usesPen || (random == 1) is true;

                    usesPen = usesPen || (random == 3) is true;

                    usesBrush = false;

                    usesBrush = usesBrush || (random == 2) is true;

                    usesBrush = usesBrush || (random == 4) is true;

                    if (usesPen is true)
                    {
                        x = x + half;

                        y = y + half;
                        
                        width = width - (half * 2);

                        height = height - (half * 2);

                        x = x + predecimal;

                        y = y + predecimal;

                        width = width - subdecimal;

                        height = height - subdecimal;
                    }
                    else
                        "false".ToString();

                    Rectangle rectangle;

                    rectangle = new Rectangle(x, y, width, height);

                    switch (random)
                    {
                        case 1:
                            graphics.DrawRectangle(pen, rectangle);
                            break;

                        case 2:
                            graphics.FillRectangle(pen.Brush, rectangle);
                            break;

                        case 3:
                            graphics.DrawEllipse(pen, rectangle);
                            break;

                        case 4:
                            graphics.FillEllipse(pen.Brush, rectangle);
                            break;

                        default:
                            break;
                    }

                    graphics.Dispose();
                }

                bitmap.Save(path, ImageFormat.Icon);

                bitmap.Dispose();
            }

            return;
        }
    }
}
