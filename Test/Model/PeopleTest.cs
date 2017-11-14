using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using agl.Model;
using System.Collections.Generic;
using agl;
using System.Linq;
using System.Collections.ObjectModel;

namespace AglTest.Model
{
    [TestClass]
    public class PeopleTest
    {
        [TestMethod]
        public void Male_Have_NoPets()
        {
            var Persons = new Collection<Person>();
            Persons.Add(new Person { Gender = Gender.Male, Name = "Ali" });

            var People = new People(Persons).GetCatsByOwnerGender(Gender.Male);

            Assert.AreEqual(People.Count(), 0);

        }

        [TestMethod]
        public void Male_Have_Pets_NoCat()
        {
            var Persons = new Collection<Person>();

          
            var p = new Person
            {
                Gender = Gender.Male,
                Name = "Ali",

            };
            p.Pets.Add(new Pet { Type = PetType.Dog, Name = "DogTest1" });

            Persons.Add(p);

            var People = new People(Persons).GetCatsByOwnerGender(Gender.Male);


            Assert.AreEqual(People.Count(), 0);

        }

        [TestMethod]
        public void Male_Have_Pets_Cat()
        {
            var Persons = new Collection<Person>();

            
            var p = new Person
            {
                Gender = Gender.Male,
                Name = "Ali",

            };
            p.Pets.Add(new Pet { Type = PetType.Cat, Name = "DogTest1" });

            Persons.Add(p);

            var People = new People(Persons).GetCatsByOwnerGender(Gender.Male);


            Assert.AreEqual(People.Count(), 1);

        }


        [TestMethod]
        public void Female_Have_NoPets()
        {
            var Persons = new Collection<Person>();
            Persons.Add(new Person { Gender = Gender.Female, Name = "Sara" });

            var People = new People(Persons).GetCatsByOwnerGender(Gender.Female);

            Assert.AreEqual(People.Count(), 0);

        }

        [TestMethod]
        public void Female_Have_Pets_NoCat()
        {
            var Persons = new Collection<Person>();

          
            var p = new Person
            {
                Gender = Gender.Female,
                Name = "Sara",

            };
            p.Pets.Add(new Pet { Type = PetType.Dog, Name = "DogTest1" });

            Persons.Add(p);

            var People = new People(Persons).GetCatsByOwnerGender(Gender.Female);


            Assert.AreEqual(People.Count(), 0);

        }

        [TestMethod]
        public void Female_Have_Pets_Cat()
        {
            var Persons = new Collection<Person>();

            var p = new Person
            {
                Gender = Gender.Female,
                Name = "Sara",

            };
            p.Pets.Add(new Pet { Type = PetType.Cat, Name = "DogTest1" });

            Persons.Add(p);

            var People = new People(Persons).GetCatsByOwnerGender(Gender.Female);


            Assert.AreEqual(People.Count(), 1);

        }


         [TestMethod]
        public void Calculate_For_Female_Among_People_HavePets_IncludeMultipleCat()
        {
            var Persons = new Collection<Person>();
             

            var p1 = new Person
            {
                Gender = Gender.Female,
                Name = "Sara",

            };
            p1.Pets.Add(new Pet { Type = PetType.Dog, Name = "DogTest1" });
            p1.Pets.Add(new Pet { Type = PetType.Cat, Name = "CatTest1" });
            p1.Pets.Add(new Pet { Type = PetType.Cat, Name = "CatTest2" });

            Persons.Add(p1);


            var p2 = new Person
            {
                Gender = Gender.Male,
                Name = "Ali",

            };
            p2.Pets.Add(new Pet { Type = PetType.Dog, Name = "DogTest1" });
            p2.Pets.Add(new Pet { Type = PetType.Cat, Name = "CatTest1" });
            p2.Pets.Add(new Pet { Type = PetType.Cat, Name = "CatTest2" });

            Persons.Add(p2);


            var People = new People(Persons).GetCatsByOwnerGender(Gender.Female);


            Assert.AreEqual(People.Count(), 2);

        }





    }
}
