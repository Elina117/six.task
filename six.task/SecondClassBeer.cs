using System;

namespace SixTaskDraft
{
    public class TheSalesProcess
    {
        public int NumberOfLiters;
        public int NumberOfBottle;
        public int PriceOfBottle;

        public TheSalesProcess(int NumberOfLiters, int NumberOfBottle)
        {
            this.NumberOfBottle = NumberOfBottle;
            this.NumberOfLiters = NumberOfLiters;
        }

        public TheSalesProcess(int NumberOfLiters, int NumberOfBottle, int PriceOfBottle) : this(NumberOfLiters, NumberOfBottle)
        {
            this.PriceOfBottle = PriceOfBottle;
        }
    }


    public class Pour : TheSalesProcess
    {
        public int NumberOfEmployee;
        public int ValumeBottle;

        public Pour(int NumberOfLiters, int NumberOfBottle, int PriceOfBottle, int NumberOfEmployee, int ValumeBottle) : base(NumberOfLiters, NumberOfBottle, PriceOfBottle)
        {
            this.NumberOfEmployee = NumberOfEmployee;
            this.ValumeBottle = ValumeBottle;
        }

        public int printnumberbottle()
        {
            int bottles = NumberOfLiters / ValumeBottle;

            return bottles;
        }

        public int printdidntused()
        {
            int usless = NumberOfLiters - (NumberOfLiters / ValumeBottle);

            return usless;
        }

        public int printdefective()
        {
            int defective = NumberOfLiters / 100 * 10;

            return defective;
        }
        public int printdrinked()
        {
            int drinked = NumberOfEmployee - 10;

            return drinked;
        }

        public int printtimeforpour()
        {
            int pourtime = (NumberOfEmployee + NumberOfLiters) / 10;

            return pourtime;
        }
    }



    public class Sale
    {
        public int price;

        public Sale(int NumberOfLiters, int NumberOfBottle, int price)
    }
}

