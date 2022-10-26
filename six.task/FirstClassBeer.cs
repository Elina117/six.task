using System;

namespace SixTaskDraft
{
    public class Manufacturingprocess
    {
        public int VolumeLiters; //объем в литрах машины
        public int BoilingTime; //время кипячения
        public int PaymentForGasoline; //cтоимость бензина


        public Manufacturingprocess(int VolumeLiters, int BoilingTime)
        {
            this.VolumeLiters = VolumeLiters;
            this.BoilingTime = BoilingTime;

        }
        public Manufacturingprocess(int VolumeLiters, int BoilingTime, int PaymentForGasoline) : this(VolumeLiters, BoilingTime)
        {
            this.PaymentForGasoline = PaymentForGasoline;
        }


    }




    public class DeliveryProcess : Manufacturingprocess 
    {
        public int OccupiedPlace;
        public int TimeOfWork;
        public int Kilometes;

        public DeliveryProcess(int VolumeLiters, int OccupiedPlace, int TimeOfWork, int BoilingTime, int Kilometes, int PaymentForGasoline) : base(VolumeLiters, BoilingTime, PaymentForGasoline)
        {
            this.OccupiedPlace = OccupiedPlace;
            this.TimeOfWork = TimeOfWork;
            this.Kilometes = Kilometes;

        }
        
        public double printplace() // свободное место
        {
            double EmptyPlace = VolumeLiters - OccupiedPlace;

            return EmptyPlace;
        }


        public double printtime() //время доставки
        {
            double wating = (TimeOfWork - 12) * 10;

            return wating;
        }

        public double printpayment() // трата на бензин
        {
            double money = Kilometes * PaymentForGasoline;

            return money;
        }

        public double printsalary() //зарплата работникам
        {
            double salary = TimeOfWork * 100;

            return salary;
        }

        public double printtimeforlunch() //
        {
            double breakfast = (TimeOfWork - 2) / 11;

            return breakfast;
        }
    }









    public class Boiling : Manufacturingprocess
    {
        int MaxTemp;
        int ValumeOfBottle;
        int MeltingPoint;

        public Boiling(int VolumeLiters, int BoilingTime, int MaxTemp, int ValumeOfBottle, int MeltingPoint) : base(VolumeLiters, BoilingTime)
        {
            this.MaxTemp = MaxTemp;
            this.ValumeOfBottle = ValumeOfBottle;
            this.MeltingPoint = MeltingPoint;
        }
            
        public double printneedtemp() //нужная температура
        {
            double temp = (MeltingPoint * VolumeLiters) / MaxTemp;

            return temp;
        }

        public double printneedtime() //необходимое время
        {
            double time = MaxTemp / MeltingPoint;

            return time;
        }

        public double printvolume() //объем за один заход
        {
            double volume = ValumeOfBottle - 3;

            return volume;
        }

        public double printnumberofbatches()//количество партий
        {
            double batches = VolumeLiters / ValumeOfBottle;

            return batches;
        }

        public double printcoolingdown()//время остывания
        {
            double coolingdown = (MaxTemp - 2) - ValumeOfBottle;

            return coolingdown;
        }
    }


}
