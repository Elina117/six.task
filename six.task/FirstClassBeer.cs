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




}
