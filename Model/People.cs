using agl.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agl
{
    public class People : IEnumerable<Person>
    {

        private IEnumerable<Person> ContainedPeople { get; }
        public People(IEnumerable<Person> persons)
        {
            this.ContainedPeople = persons;
        }

       // public People HaveCat() => new People(this.ContainedPeople.Where(p => p.Pets.Any(t => t.Type == PetType.Cat)));
        public People Gender(Gender gender) => new People(this.ContainedPeople.Where(p => p.Gender == gender));








        public IEnumerator<Person> GetEnumerator()
        {
            return this.ContainedPeople.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
