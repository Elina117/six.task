using System;

namespace SixTaskDraft
{
    public class Manufacturingprocess
    {
        public int VolumeLiters; //объем в литрах машины
        public int BoilingTime; //время кипячения
     
        public Manufacturingprocess(int VolumeLiters)
        {
            this.VolumeLiters = VolumeLiters;

        }

        public Manufacturingprocess(int VolumeLiters, int BoilingTime) : this(VolumeLiters) //время доставки
        {
            this.BoilingTime = BoilingTime;
            
        }

    }






    public class DeliveryProcess : Manufacturingprocess // количество свободного места в грузовике с товаром
    {
        int OccupiedPlace;

        public DeliveryProcess(int OccupiedPlace, int VolumeLiters) : base(VolumeLiters)
        {
            this.OccupiedPlace = OccupiedPlace;
            this.VolumeLiters = VolumeLiters;


        }



        public double printplace()
        {
            double EmptyPlace = VolumeLiters - OccupiedPlace;

            return EmptyPlace;
        }

        //public double printtime() 
        //{
        //    double wating = (TimeOfWork - 12) * 10;

        //    return wating;
        //}
    }

    
}
