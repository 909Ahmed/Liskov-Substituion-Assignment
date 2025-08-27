using Substitution.Birds;

namespace UnitTests;

[TestClass]
public sealed class SubstitutionUnitTests
{
    [TestMethod]
    public void AllBirds()
    {
        var birds = new List<Bird>
        {
            new Sparrow("Jack"),
            new Penguin("John"),
            new Ostrich("Usain"),
            new Eagle("Eddie")
        };

        ZooKeeper.BirdsMove(birds);
    }

    [TestMethod]
    public void CountBirds()
    {
        var birds = new List<Bird>
        {
            new Sparrow("Jack"),
            new Penguin("John"),
            new Ostrich("Usain"),
            new Eagle("Usadin")
        };

        var flyers = birds.OfType<IFlyable>().ToList();
        Assert.AreEqual(2, flyers.Count);
        Assert.AreEqual(2, birds.Count - flyers.Count);
    }

    [TestMethod]
    public void VerifyFlyers()
    {
        var sparrow = new Sparrow("Jack");
        Assert.IsTrue(sparrow is IFlyable);
        var eagle = new Eagle("John");
        Assert.IsTrue(eagle is IFlyable);
    }

    [TestMethod]
    public void VerifyNonFlyers()
    {
        var ostrich = new Ostrich("Usain");
        Assert.IsFalse(ostrich is IFlyable);
        var penguin = new Penguin("Usadin");
        Assert.IsFalse(penguin is IFlyable);
    }
}
