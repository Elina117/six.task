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

    //
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


}
