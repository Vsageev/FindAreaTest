using System;

namespace FigureLib
{
    public static class Figures
    {
        /// <summary>
        /// finds area of a figure based on ammount of arguments (circle for 1 argument) 
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double findArea(double radius)
        {
            return (radius * radius * Math.PI);
        }

        /// <summary>
        /// finds area of a figure based on ammount of arguments (triangle for 3 arguments).
        /// 
        /// returns -1 if triangle is invalid. returns area otherwise
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static double findArea(double side1, double side2, double side3)
        {
            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side2 + side1 <= side2)
            {
                return -1;
            }

            double s = (side1 + side2 + side3) / 2;
            return (float)Math.Sqrt(s * (s - side1) *
                                (s - side2) * (s - side3));
        }
    }
}
