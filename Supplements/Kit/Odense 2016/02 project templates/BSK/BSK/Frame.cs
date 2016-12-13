using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDU.Assignments.BSK
{
    public class Frame
    {
        private int _firstThrow;
        private int _secondThrow;

        public Frame(int firstThrow, int secondThrow)
        {
            this._firstThrow = firstThrow;
            this._secondThrow = secondThrow;
        }

        public int FirstThrow
        {
            get
            {
                return _firstThrow;
            }
        }

        public int SecondThrow
        {
            get
            {
                return _secondThrow;
            }
        }

        //the score of a single frame
        public int Score
        {
            get
            {
                ///TODO: to be implemented
                return 0;
            }
        }

        //returns whether the frame is a strike or not
        public bool IsStrike
        {
            get
            {
                ///TODO: to be implemented
                return false;
            }
        }

        //return whether a frame is a spare or not
        public bool IsSpare
        {
            get
            {
                ///TODO: to be implemented
                return false;
            }
        }
    }
}
