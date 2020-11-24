using NUnit.Framework;
using System;

public class DatabaseTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void StoreArrayCapacity()
    {
        int[] nums = new int[16];
        Database database = new Database(nums);

        int target = 16;
        int actual = nums.Length;

        Assert.AreEqual(target, actual, "Invalid capacity");
    }

    [Test]
    public void AddElementOnNextFreeCell()
    {
        int[] nums = new int[15];
        Database database = new Database(nums);

        database.Add(3);
        int count = database.Count;
        int target = 16;

        Assert.AreEqual(target, count, $"{new InvalidOperationException("Array's capacity must be exactly 16 integers!")}");
    }

    [Test]
    public void RemoveElementOnlyAtLastIndex()
    {
        int[] nums = new int[16];
        Database database = new Database(nums);

        database.Remove();

        int count = database.Count;
        Assert.AreEqual(count, nums.Length - 1);
    }

    [Test]
    public void RemoveElementFromEmptyDatabase()
    {
        Assert.Throws<InvalidOperationException>(() =>
        {
            int[] nums = new int[0];
            Database database = new Database(nums);
            database.Remove();
        });

    }

    ////TODO: constructor test
    [Test]
    public void ConstructorShouldTakeIntsOnlyAndStoreThemInArray()
    {
        Database database = new Database();
        
        
    }

    [Test]
    public void FetchShouldReturnAnArray()
    {
        Database database = new Database();
        var type = database.Fetch().GetType();
        Assert.IsTrue(type.IsArray, "Fetch method does not return an array.");
    }
}
