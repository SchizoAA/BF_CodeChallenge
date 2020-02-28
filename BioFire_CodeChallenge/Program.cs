using System;

namespace BioFire_CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        /*
         * For the purposes of these questions, assume all rectangles are not skew, that is, their sides are parallel to the X- and Y-axis.
         * In a Cartesian plane, a rectangle can be completely described by a pair of points representing two opposing corners.
         * Another way of looking at this is:  two points in a plane uniquely describe a single rectangle.
         * There may be ambiguities or corner cases; use your judgment to resolve them.
         * For each of the parts below, be prepared to discuss your decisions and implementation when you come on site.
         */

        /*
         *Part 1
         * Write a class definition for a rectangle as described above.  There are two requirements:
         * -	A class object should be able to be constructed by passing in two points.
         * -	There should be a mechanism for marking an object as valid or invalid, and another for testing that state.  By default, objects should be marked valid.
         * Besides these, the design is up to you.  Include whatever methods you think would be appropriate or useful to your users.
         */

        /*
         *Part 2
         * Write a function which takes as input two Rectangle objects and returns a third which represents the overlap of them.
         * For example, for rectangles 1 and 2 below, the function would return a Rectangle object containing 3.
         * If the two rectangles do not overlap, the return object should be marked as invalid; the coordinate data is undefined.
         */

        /*
         *Part 3
         * Come up with a set of test cases for the function in Part 2.  You can represent these visually, as data, or as simple descriptions.
         */
    }
}
