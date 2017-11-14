using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;

namespace agl.Model
{

    public class Pet //: IComparer
    {
        public PetType Type
        {
            get;
            set;

        }
        public String Name { get; set; }

     //   public Person Person { get; set; }

        //public int Compare(object x, object y)
        //{
        //    throw new NotImplementedException();
        //}
    }



    public enum PetType
    {
        Cat = 1,
        Dog = 2,
        Fish = 3

    }
}