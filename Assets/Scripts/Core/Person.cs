using UnityEngine;
using System;

namespace Core
{
    public class Person : MonoBehaviour
    {
        public Sprite PersonImage { get; private set; }
        public Gender Gender { get; private set; }
        public Age Age { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Id { get; private set; }

        public Person(Gender gender, Age age, string name, string lastName)
        {
            Gender = gender;
            Age = age;
            Name = name;
            LastName = lastName;

            CreateId();
        }

        public Person(Person settings)
        {
            PersonImage = settings.PersonImage;
            Gender = settings.Gender;
            Age = settings.Age;
            Name = settings.Name;
            LastName = settings.LastName;

            CreateId();
        }

        private void CreateId()
        {
            Id = new Guid().ToString();
        }
    }
}
