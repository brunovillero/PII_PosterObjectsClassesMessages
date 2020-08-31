using System;

namespace Library
{
    public class Person 
    { 
        private string name; 

        private string id; 

        public Person(string name, string id) 
        { 
            this.Name = name; 
            this.Id = id; 
        } 

        public void IntroduceYourself() 
        { 
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.Id}"); 
        }

        public string Id
        {
            get 
            {
                return this.id;
            }

            set
            {
                if(IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
                else
                {
                    Console.WriteLine("Ingrese un Id válido");
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value != ""){
                    this.name = value;
                }
            }
        }
    }
}
