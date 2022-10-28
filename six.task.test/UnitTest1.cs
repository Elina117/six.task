using SixTaskDraft;


namespace six.task.test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int r = 3;      
        int i = 4;

        ComplexNumber classObject = new ComplexNumber(r, i);
        
        string expected = "3 + 4i";
        string actual = classObject.print();

        Assert.AreEqual(expected, actual);


    }

    
    [TestMethod]
    public void TestMethod2()
    {
        int VolumeLiters = 50;
        int OccupiedPlace = 20;
        int TimeOfWork = 24;
        int BoilingTime = 10;
        int Kilometes = 15;
        int PaymentForGasoline = 45;



        DeliveryProcess classObject = new DeliveryProcess(VolumeLiters, OccupiedPlace, TimeOfWork, BoilingTime, Kilometes, PaymentForGasoline);

        double expected = 30;
        double actual = classObject.printplace();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod3()
    {
        int VolumeLiters = 50;
        int OccupiedPlace = 20;
        int TimeOfWork = 24;
        int BoilingTime = 10;
        int Kilometes = 15;
        int PaymentForGasoline = 45;



        DeliveryProcess classObject = new DeliveryProcess(VolumeLiters, OccupiedPlace, TimeOfWork, BoilingTime, Kilometes, PaymentForGasoline);

        double expected = 120;
        double actual = classObject.printtime();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod4()
    {
        int VolumeLiters = 50;
        int OccupiedPlace = 20;
        int TimeOfWork = 24;
        int BoilingTime = 10;
        int Kilometes = 15;
        int PaymentForGasoline = 45;



        DeliveryProcess classObject = new DeliveryProcess(VolumeLiters, OccupiedPlace, TimeOfWork, BoilingTime, Kilometes, PaymentForGasoline);

        double expected = 675;
        double actual = classObject.printpayment();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod5()
    {
        int VolumeLiters = 50;
        int OccupiedPlace = 20;
        int TimeOfWork = 24;
        int BoilingTime = 10;
        int Kilometes = 15;
        int PaymentForGasoline = 45;


        DeliveryProcess classObject = new DeliveryProcess(VolumeLiters, OccupiedPlace, TimeOfWork, BoilingTime, Kilometes, PaymentForGasoline);

        double expected = 2400;
        double actual = classObject.printsalary();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod6()
    {
        int VolumeLiters = 50;
        int OccupiedPlace = 20;
        int TimeOfWork = 24;
        int BoilingTime = 10;
        int Kilometes = 15;
        int PaymentForGasoline = 45;


        DeliveryProcess classObject = new DeliveryProcess(VolumeLiters, OccupiedPlace, TimeOfWork, BoilingTime, Kilometes, PaymentForGasoline);

        double expected = 2;
        double actual = classObject.printtimeforlunch();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod7()
    {
        int VolumeLiters = 50;
        int BoilingTime = 10;
        int MaxTemp = 500;
        int ValumeOfBottle = 20;
        int MeltingPoint = 50;


        Boiling classObject = new 3(VolumeLiters, MaxTemp, ValumeOfBottle, BoilingTime, MeltingPoint);

        double expected = 125;
        double actual = classObject.printneedtemp();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod8()
    {
        int VolumeLiters = 50;
        int BoilingTime = 10;
        int MaxTemp = 500;
        int ValumeOfBottle = 20;
        int MeltingPoint = 50;


        Boiling classObject = new Boiling(VolumeLiters, MaxTemp, ValumeOfBottle, BoilingTime, MeltingPoint);

        double expected = 0; //10
        double actual = classObject.printneedtime();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod9()
    {
        int VolumeLiters = 50;
        int BoilingTime = 10;
        int MaxTemp = 500;
        int ValumeOfBottle = 20;
        int MeltingPoint = 50;


        Boiling classObject = new Boiling(VolumeLiters, MaxTemp, ValumeOfBottle, BoilingTime, MeltingPoint);

        double expected = 7;
        double actual = classObject.printvolume();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod10()
    {
        int VolumeLiters = 50;
        int BoilingTime = 10;
        int MaxTemp = 500;
        int ValumeOfBottle = 20;
        int MeltingPoint = 50;


        Boiling classObject = new Boiling(VolumeLiters, MaxTemp, ValumeOfBottle, BoilingTime, MeltingPoint);

        double expected = 5;
        double actual = classObject.printnumberofbatches();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod11()
    {
        int VolumeLiters = 50;
        int BoilingTime = 10;
        int MaxTemp = 500;
        int ValumeOfBottle = 20;
        int MeltingPoint = 50;


        Boiling classObject = new Boiling(VolumeLiters, MaxTemp, ValumeOfBottle, BoilingTime, MeltingPoint);

        double expected = 8;
        double actual = classObject.printcoolingdown();

        Assert.AreEqual(expected, actual);

    }





    [TestMethod]
    public void TestMethod12()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int PriceOfBottle = 20;
        int NumberOfEmployee = 300;
        int ValumeBottle = 50;


        Pour classObject = new Pour(NumberOfLiters, NumberOfBottle, PriceOfBottle, NumberOfEmployee, ValumeBottle);

        double expected = 2;
        double actual = classObject.printnumberbottle();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod13()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int PriceOfBottle = 20;
        int NumberOfEmployee = 300;
        int ValumeBottle = 50;


        Pour classObject = new Pour(NumberOfLiters, NumberOfBottle, PriceOfBottle, NumberOfEmployee, ValumeBottle);

        double expected = 98;
        double actual = classObject.printdidntused();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod14()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int PriceOfBottle = 20;
        int NumberOfEmployee = 300;
        int ValumeBottle = 50;


        Pour classObject = new Pour(NumberOfLiters, NumberOfBottle, PriceOfBottle, NumberOfEmployee, ValumeBottle);

        double expected = 10;
        double actual = classObject.printdefective();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod15()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int PriceOfBottle = 20;
        int NumberOfEmployee = 300;
        int ValumeBottle = 50;


        Pour classObject = new Pour(NumberOfLiters, NumberOfBottle, PriceOfBottle, NumberOfEmployee, ValumeBottle);

        double expected = 290;
        double actual = classObject.printdrinked();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod16()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int PriceOfBottle = 20;
        int NumberOfEmployee = 300;
        int ValumeBottle = 50;


        Pour classObject = new Pour(NumberOfLiters, NumberOfBottle, PriceOfBottle, NumberOfEmployee, ValumeBottle);

        double expected = 40;
        double actual = classObject.printtimeforpour();

        Assert.AreEqual(expected, actual);
        4
    }

    [TestMethod]
    public void TestMethod17()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int Price = 20;
        int NumberOfEmployee = 300;
        int Volumeone = 10;


        Sale classObject = new Sale(NumberOfLiters, NumberOfBottle, Price, NumberOfEmployee, Volumeone);

        double expected = 200;
        double actual = classObject.printprice();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod18()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int Price = 20;
        int NumberOfEmployee = 300;
        int Volumeone = 10;


        Sale classObject = new Sale(NumberOfLiters, NumberOfBottle, Price, NumberOfEmployee, Volumeone);

        double expected = 90;
        double actual = classObject.salesontheday();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod19()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int Price = 20;
        int NumberOfEmployee = 300;
        int Volumeone = 10;


        Sale classObject = new Sale(NumberOfLiters, NumberOfBottle, Price, NumberOfEmployee, Volumeone);

        double expected = 10;
        double actual = classObject.printvolume();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod20()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int Price = 20;
        int NumberOfEmployee = 300;
        int Volumeone = 10;


        Sale classObject = new Sale(NumberOfLiters, NumberOfBottle, Price, NumberOfEmployee, Volumeone);

        double expected = 280;
        double actual = classObject.printnumberofpeople();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void TestMethod21()
    {
        int NumberOfLiters = 100;
        int NumberOfBottle = 10;
        int Price = 20;
        int NumberOfEmployee = 300;
        int Volumeone = 10;


        Sale classObject = new Sale(NumberOfLiters, NumberOfBottle, Price, NumberOfEmployee, Volumeone);

        double expected = 320;
        double actual = classObject.printprofit();

        Assert.AreEqual(expected, actual);

    }



}
