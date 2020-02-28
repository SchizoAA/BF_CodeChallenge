using System;
namespace BioFire_CodeChallenge
{
    /*
     *Part 1
     * Write a class definition for a rectangle as described above.  There are two requirements:
     * -	A class object should be able to be constructed by passing in two points.
     * -	There should be a mechanism for marking an object as valid or invalid, and another for testing that state.  By default, objects should be marked valid.
     * Besides these, the design is up to you.  Include whatever methods you think would be appropriate or useful to your users.
     */

    public class Rectangle
    {
        public Tuple<int,int> LCoord { get; set; }
        public Tuple<int, int> RCoord { get; set; }

        public Rectangle( Tuple<int, int> coord1, Tuple<int, int> coord2 )
        {
            //TODO: Set LCoord to smallest of each input x,y values. Set RCoord to largest of each input x,y values.

        }
    }
}
