using System;
using System.Text;

    class Person
    {
        private string name;
        private int age;
        private string email;
        public Person(string name, int age, string email)
        {
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }
        public Person(string name, int age)
            : this(name, age, null)
        {

        }
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value.Length >0 && value.Length<=10)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Length of name must be in range 1-100 symbols");
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("My name is {0}, I am {1} years old", this.Name, this.Age));
            if(this.Email != null)
            {
                sb.Append(string.Format(", and my email is {0}",this.Email));
            }

            return sb.ToString();

        }
    }
