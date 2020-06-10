using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_DRAssignment1
{
    public class Rectangle
    {
        private int rectangleLength = 1;
        private int rectangleWidth = 1;

        private int userLength;
        private int userWidth;

        private int perimeter;
        private int area;


        public int UserLength
        {
            get { return userLength; }
            set { userLength = value; }
        }

        public int UserWidth
        {
            get { return userWidth; }
            set { userWidth = value; }
        }

       
        public int GetRectangleLength()
        {
            return rectangleLength;
        }

        public int GetRectangleWidth()
        {
            return rectangleLength;
        }

        public void SetRectangleLength(int userLength)
        {
            this.userLength = userLength;
        }

        public int GetPerimeter()
        {

            return ((userLength * 2) + (userWidth * 2)); ;
        }

        public int GetArea()
        {
            return (userLength * userWidth);
        }
    }
}
