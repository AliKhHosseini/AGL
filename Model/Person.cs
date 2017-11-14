using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace agl.Model
{
    public class Person
    {
        public Person()
        {
            Pets = new Collection<Pet>();
        }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

      
        private Collection<Pet> _pets;
        public Collection<Pet> Pets
        {
            get { return _pets; }
            set
            {
                if (_pets == null)
                {
                    _pets = new Collection<Pet>();
                }

            }
        }

        //public Collection<Pet> GetCats()
        //{
        //    return Pets.w
            
        //}


    }




    public enum Gender
    {
        Female = 1,
        Male = 2
    }


}
