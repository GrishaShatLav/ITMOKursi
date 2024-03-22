using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_13_Lesson_14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {

            Console.WriteLine(Name);
            Say();

        }

    }

    class Cat:Animal
    {
        private string name;
        private string sound;

        public override string Name
        {
            get => name;
            set => name = value;

        }

        public Cat(string name="Кошка", string sound = "Мяу")
            :base(name) 
        {
            this.Name = name;
            this.sound = sound;
            
        }
        public override void Say() 
        {
            Console.WriteLine(sound);
        
        }
    }
    class Dog : Animal
    {
        private string name;
        private string sound;

        public override string Name
        {
            get => name;
            set => name = value;

        }

        public Dog(string name="Собака", string sound = "Гав")
            : base(name)
        {
            this.Name = name;
            this.sound = sound;

        }
        public override void Say()
        {
            Console.WriteLine(sound);

        }
    }
}
