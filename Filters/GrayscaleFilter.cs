using System;

namespace MyPhotoshop
{
    public class GrayscaleFilter : PixelFilter
    {

        public override string ToString()
        {
            return "Оттенки серого";
        }

        public GrayscaleFilter() : base(new EmptyParameters())
        {

        }

        public override Pixel ProcessPixel(Pixel original,IParameters parameters)
        {
            var lightness = original.R + original.G + original.B;
            lightness /= 3;
            return new Pixel(lightness, lightness, lightness);
        }
    }
}

