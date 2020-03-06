using System;

namespace day_2
{
    public struct Box
    {
        private int width;
        private int length;
        private int height;

        public Box(int width, int length, int height)
        {
            this.width = width;
            this.length = length;
            this.height = height;
        }

        public int getRibbonAmount()
        {
            return getSmallestPerimiter() + getRibbonBow();
        }

        public int getSurfaceArea()
        {
            return 2 * (getTopSideArea() + getFrontSideArea() + getSideArea()) + getSmallestArea();
        }

        private int getTopSideArea()
        {
            return length * width;
        }

        private int getFrontSideArea()
        {
            return width * height;
        }

        private int getSideArea()
        {
            return height * length;
        }

        private int getSmallestArea()
        {
            return Math.Min(getSideArea(), Math.Min(getFrontSideArea(), getTopSideArea()));
        }

        private int getTopSidePerimiter()
        {
            return 2 * length + 2 * width;
        }

        private int getFrontSidePerimiter()
        {
            return 2 * width + 2 * height;
        }

        private int getSidePerimiter()
        {
            return 2 * height + 2 * length;
        }

        private int getRibbonBow()
        {
            return width * height * length;
        }

        private int getSmallestPerimiter()
        {
            return Math.Min(getTopSidePerimiter(), Math.Min(getFrontSidePerimiter(), getSidePerimiter()));
        }
    }
}