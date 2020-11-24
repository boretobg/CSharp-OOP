using NUnit.Framework;
using System;

    public class ExtendedDatabaseTests
    {
        private Person person;
        private ExtendedDatabase database;
        private readonly Person[] people = new[]
                {new Person(1, "Pesho"),
                new Person(2, "Ivan"),
                new Person(3, "Dimitrichko")};

        [SetUp]
        public void Setup()
        {
            person = new Person(111, "Pesho");
            var data = new[]
            {
                new Person(1,"Pesho1"),
                new Person(2,"Pesho2"),
                new Person(3,"Pesho3"),
                new Person(4,"Pesho4"),
                new Person(5,"Pesho5"),
                new Person(6,"Pesho6"),
                new Person(7,"Pesho7"),
                new Person(8,"Pesho8"),
                new Person(9,"Pesho9"),
                new Person(10,"Pesho10"),
                new Person(11,"Pesho11"),
                new Person(12,"Pesho12"),
                new Person(13,"Pesho13"),
                new Person(14,"Pesho14"),
                new Person(15,"Pesho15")
                };
            this.database = new ExtendedDatabase(data);
        }

        [Test]
        public void TestIfPersonConstructorWorksCorrectly()
        {
            var expectedName = "Pesho";
            var expectedId = (long)1;

            person = new Person(1, "Pesho");

            Assert.AreEqual(expectedName, person.UserName);
            Assert.AreEqual(expectedId, person.Id);
        }

        [Test]
        public void TestIfDatabaseCtorWorksCorrectly()
        {
            var expectedCount = 3;

            this.database = new ExtendedDatabase(people);

            Assert.AreEqual(expectedCount, database.Count);
        }

        [Test]
        public void TestIfExceptionIsThrownWhenUsernameAlreadyExists()
        {
            var duplicateUsername = new Person(12, "Bobby");

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(duplicateUsername);
            });
        }
        
        [Test]
        public void TestIfExceptionIsThrownWhenIDAlreadyExists()
        {
            var duplicateID = new Person(12, "Bobby");

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(duplicateID);
            });
        }

        [Test]
        public void TestIfCapacityIsMoreThan16()
        {
            this.database.Add(person);

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(new Person(123, "asd"));
            });
        }

        [Test]
        public void TestIfAddRangeThrowsExceptionWhenDatabaseIsFull()
        {
            var data = new Person[17];

            Assert.Throws<ArgumentException>(() =>
            {
                this.database = new global::ExtendedDatabase(data);
            });
        }

        [Test]
        public void TestIfCountDeacreaseAfterRemove()
        {
            var expected = 14;
            database.Remove();
            Assert.AreEqual(expected, database.Count);
        }

        [Test]
        public void TestIfRemoveThrowsExceptionWhenCountIs0()
        {
            this.database = new ExtendedDatabase(people);

            database.Remove();
            database.Remove();
            database.Remove();

            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }

        [TestCase(null)]
        [TestCase("")]
        public void TestIfFindByUsernameThrowsExceptionWhenNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentNullException>(() => 
            { 
                this.database.FindByUsername(name); 
            });
        }

        [TestCase("Dimitrichko")]
        [TestCase("Asen")]
        public void TestIfFindByUsernameThrowsExceptionWhenNameDoesntExist(string name)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.FindByUsername(name);
            });
        }

        [Test]
        public void TestIfFindByUsernameReturnsCorrectly()
        {
            this.database.Add(person);

            var expectedPerson = this.database.FindByUsername("Pesho");

            Assert.AreEqual(expectedPerson, person);
        }

        [Test]
        public void TestIfFindByIdThrowsExceptionWhenNegativeId()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 
            {
                this.database.FindById(-1);
            });
        }

        [Test]
        public void TestIfFindByIdThrowsExceptionWhenIdDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => 
            {
                this.database.FindById(11122); 
            });
        }

        [Test]
        public void TestIfFindByIdReturnsCorrectly()
        {
            this.database.Add(person);

            var expectedPerson = this.database.FindById(111);

            Assert.AreEqual(expectedPerson, person);
        }
    }