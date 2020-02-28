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
        public Tuple<int,int> LCoord { get; private set; }
        public Tuple<int, int> RCoord { get; private set; }

        public bool IsValid { get; set; }

        public Rectangle( Tuple<int, int> coord1, Tuple<int, int> coord2 )
        {
            //TODO: Set LCoord to smallest of each input x,y values. Set RCoord to largest of each input x,y values.
            Normalize(coord1, coord2);
            CheckIsValid();
        }

        public void Resize(Tuple<int, int> p1, Tuple<int, int> p2)
        {
            Normalize(p1, p2);
            CheckIsValid();
        }

        public bool CheckIsValid()
        {
            bool valid = true;
            if(LCoord.Item1 == RCoord.Item1 || LCoord.Item2 == RCoord.Item2) //Horizontal or vertical line and points are not valid rectangles.
            {
                valid = false;
            }
            IsValid = valid;
            return valid;
        }

        public void MarkInvalid()
        {
            IsValid = false;
            LCoord = null;
            RCoord = null;
        }

        private void Normalize(Tuple<int,int> p1, Tuple<int,int> p2)
        {
            LCoord = new Tuple<int, int>(Math.Min(p1.Item1, p2.Item1), Math.Max(p1.Item2, p2.Item2));
            RCoord = new Tuple<int, int>(Math.Max(p1.Item1, p2.Item1), Math.Min(p1.Item2, p2.Item2));
        }
    }
}
