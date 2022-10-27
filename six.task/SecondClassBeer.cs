using System;

namespace SixTaskDraft
{
    abstract public class TheSalesProcess
    {
        private int _numberOfLiters;
        private int _numberOfBottle;
        private int _priceOfBottle;

        public int NumberOfLiters
        {
            set { _numberOfLiters = value; }
            get { return _numberOfLiters; }
        }
        public int NumberOfBottle
        {
            set { _numberOfBottle = value; }
            get { return _numberOfBottle; }
        }
        public int PriceOfBottle
        {
            set { _priceOfBottle = value; }
            get { return _priceOfBottle; }
        }

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
        private int _numberOfEmployee;
        private int _valumeBottle;

        public int NumberOfEmployee
        {
            set {
                _numberOfEmployee = value;
            }
            get {
                return _numberOfEmployee;
            }
        }

        public int getNumberOfEmployee()
        {
            return _numberOfEmployee;
        }

        public void setNumberOfEmployee(int value)
        {
            _numberOfEmployee = value;
        }

        public int ValumeBottle
        {
            set { _valumeBottle = value; }
            get { return _valumeBottle; }
        }


        public Pour(int NumberOfLiters, int NumberOfBottle, int PriceOfBottle, int NumberOfEmployee, int ValumeBottle) : base(NumberOfLiters, NumberOfBottle, PriceOfBottle)
        {
            int var = this.NumberOfEmployee;

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



    public class Sale : TheSalesProcess
    {
        private int _price;
        private int _numberOfEmployee;
        private int _volumeone;

        public int Price
        {
            set {
                    _price = value;
            }
            get { return _price; }
        }
        public int NumberOfEmployee
        {
            set {  _numberOfEmployee = value; }
            get { return _numberOfEmployee; }
        }
        public int Volumeone
        {
            set { _volumeone = value; }
            get { return _volumeone; }
        }


        public Sale(int NumberOfLiters, int NumberOfBottle, int Price, int NumberOfEmployee, int Volumeone) : base(NumberOfLiters, NumberOfBottle)
        {
            this.Price = Price;
            this.NumberOfEmployee = NumberOfEmployee;
            this.Volumeone = Volumeone;
        }

        public int printprice()
        {
            int prices = NumberOfBottle * Price;

            return prices;
        }

        public int salesontheday()
        {
            int sales = NumberOfLiters - NumberOfBottle;

            return sales;
        }

        public int printvolume()
        {
            int volume = NumberOfLiters / Volumeone;

            return volume;
        }

        public int printnumberofpeople()
        {
            int people = NumberOfEmployee - 20;

            return people;
        }

        public int printprofit()
        {
            int profit = Price + NumberOfEmployee;

            return profit;
        }

    }
}

