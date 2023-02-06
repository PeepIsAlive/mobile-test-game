using UnityEngine;
using System;

namespace Core
{
    public class Person
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

        private void CreateId()
        {
            Id = Guid.NewGuid().ToString(); 
        }
    }
}
