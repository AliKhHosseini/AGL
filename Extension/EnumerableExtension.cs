using agl.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace agl
{
    public static class EnumerableExtension
    {

        public static IEnumerable<Pet> GetCatsByOwnerGender(this People people, Gender gender)
        {
            return people.Gender(gender).SelectMany(c => c.Pets.Where(p=> p.Type == PetType.Cat)).OrderBy(c => c.Name);
        }



        //private static IEnumerable<Pet> GetPetByKind(this IEnumerable<Pet> pets, PetType petType)
        //{
        //    return pets.Where(p => p.Type == petType);
        //}

        //public static void ShowUnderGender(this People people)
        //{

        //    Console.WriteLine($"Female:");
        //    foreach (var item in people.IsMale().GetPets())
        //    {
        //        Console.WriteLine($"    * {item.Name} ");
        //    }


        //    Console.WriteLine($"Male:");
        //    foreach (var item in people.IsFemale().GetPets())
        //    {
        //        Console.WriteLine($"    * {item.Name} ");
        //    }

        //}





        public static void ShowCatsBasedOnOwnerGender(this People people, Gender gender)
        {
            Console.WriteLine(gender);
            foreach (var item in people.GetCatsByOwnerGender(gender))
            {
                Console.WriteLine($"    * {item.Name} ");
            }
        }







    }
}
