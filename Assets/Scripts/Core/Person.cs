using System;
using UnityEngine;

namespace Core
{
    public class Person : MonoBehaviour
    {
        private Gender _gender;
        private Age _age;
        private string _id;

        public Gender Gender => _gender;
        public Age Age => _age;
        public string Id => _id;

        public Person(Gender gender, Age age)
        {
            _gender = gender;
            _age = age;

            CreateId();
        }

        public Person(Person settings)
        {
            _gender = settings._gender;
            _age = settings._age;

            CreateId();
        }

        private void CreateId()
        {
            _id = new Guid().ToString();
        }
    }
}
