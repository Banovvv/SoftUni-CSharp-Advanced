using System;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private static string _errorMessage = "Invalid input!";

        private string _name;
        private int _age;
        private string _gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(_errorMessage);
                }

                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(_errorMessage);
                }

                _age = value;
            }
        }
        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || (value != "Male" && value != "Female"))
                {
                    throw new ArgumentException(_errorMessage);
                }

                _gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetType().Name);
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine(ProduceSound());

            return sb.ToString().Trim();
        }
    }
}
