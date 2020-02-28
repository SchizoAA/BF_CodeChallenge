using System;

namespace BioFire_CodeChallenge
{

    /*
     * For the purposes of these questions, assume all rectangles are not skew, that is, their sides are parallel to the X- and Y-axis.
     * In a Cartesian plane, a rectangle can be completely described by a pair of points representing two opposing corners.
     * Another way of looking at this is:  two points in a plane uniquely describe a single rectangle.
     * There may be ambiguities or corner cases; use your judgment to resolve them.
     * For each of the parts below, be prepared to discuss your decisions and implementation when you come on site.
     */

    public class RectangleOperations
    {
        /*
         *Part 2
         * Write a function which takes as input two Rectangle objects and returns a third which represents the overlap of them.
         * For example, for rectangles 1 and 2 below, the function would return a Rectangle object containing 3.
         * If the two rectangles do not overlap, the return object should be marked as invalid; the coordinate data is undefined.
         */

        public Rectangle GetRectangleOverlap(Rectangle r1, Rectangle r2)
        {
            Rectangle result;

            var x1 = Math.Max(r1.LCoord.Item1, r2.LCoord.Item1);
            var y1 = Math.Min(r1.LCoord.Item2, r2.LCoord.Item2);
            var x2 = Math.Min(r1.RCoord.Item1, r2.RCoord.Item1);
            var y2 = Math.Max(r1.RCoord.Item2, r2.RCoord.Item2);

            var p1 = new Tuple<int, int>(x1, y1);
            var p2 = new Tuple<int, int>(x2, y2);
            result = new Rectangle(p1, p2);

            if (x1 > x2 || y1 < y2)
            {
                Console.WriteLine("Rectangles do not overlap.");
                result.MarkInvalid();
            }
            return result;
        }
    }
}
