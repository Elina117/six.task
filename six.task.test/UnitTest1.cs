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
        int OccupiedPlace = 20;
        int VolumeLiters = 50;
        

        DeliveryProcess classObject = new DeliveryProcess(OccupiedPlace, VolumeLiters);

        double expected = 30;
        double actual = classObject.printplace();

        Assert.AreEqual(expected, actual);

    }

    //[TestMethod]
    //public void TestMethod3()
    //{
    //    int OccupiedPlace = 20;
    //    int VolumeLiters = 50;
    //    int TimeOfWork = 24;
    //    int BoilingTime = 100;

    //    DeliveryProcess classObject = new DeliveryProcess(OccupiedPlace, VolumeLiters, TimeOfWork, BoilingTime);

    //    double expected = 120;
    //    double actual = classObject.printtime();

    //    Assert.AreEqual(expected, actual);

    //}


}
