using System;


namespace SixTaskDraft
{
    public class ComplexNumber
    {
        public int r;
        public int i;


        public ComplexNumber(int r, int i)
        {
            this.r = r;
            this.i = i;

        }

        public string print()
        {
            string z = r + " + " + i + "i";

            return z;
        }

        
    }
}

