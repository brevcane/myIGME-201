using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    internal class Program
    {
        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }

        public abstract class Pet
        {
            public string name;
            public int age;

            public string Name
            {
                get { return name; }

                set { name = value; }
            }

            public abstract void Eat();
            public abstract void Play();
            public abstract void GotoVet();

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        public class Dog : Pet, IDog
        {
            public Dog(string license, string name, int age) : base(name, age) { }

            public string license;

            public void Bark()
            {
                Console.WriteLine(this.name + ": Woof!");
            }

            public override void Eat()
            {
                Console.WriteLine(this.name + ": *Chews on dog kibble*");
            }

            public override void GotoVet()
            {
                Console.WriteLine(this.name + ": *Whimper* Not the vet!");
            }

            public void NeedWalk()
            {
                Console.WriteLine(this.name + ": Take me for a walk!");
            }

            public override void Play()
            {
                Console.WriteLine(this.name + ": Let's play!");
            }
        }

        public class Cat : Pet, ICat
        {
            public Cat(string name, int age) : base(name, age) { }

            public override void Eat()
            {
                Console.WriteLine(this.name + ": *Nibbles on some tuna*");
            }

            public override void GotoVet()
            {
                Console.WriteLine(this.name + ": *Hiss* Not the vet!");
            }

            public override void Play()
            {
                Console.WriteLine(this.name + ": Let's play!");
            }

            public void Purr()
            {
                Console.WriteLine(this.name + ": *Purrs*");
            }

            public void Scratch()
            {
                Console.WriteLine(this.name + ": *Scratches*");
            }
        }

        public class Pets
        {
            public List<Pet> petList = new List<Pet>();

            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            public int Count { get { return petList.Count; } }

            public void Add(Pet pet) { petList.Add(pet); }

            public void Remove(Pet pet) { petList.Remove(pet); }

            public void RemoveAt(int petEl) { petList.RemoveAt(petEl); }


            static void Main(string[] args)
            {
                Pet thisPet = null;
                Dog dog = null;
                Cat cat = null;
                IDog iDog = null;
                ICat iCat = null;

                Pets pets = new Pets();
                Random rand = new Random();

                for (int i = 0; i < 50; i++)
                {
                    // 1 in 10 chance of adding an animal
                    if (rand.Next(1, 11) == 1)
                    {
                        if (rand.Next(0, 2) == 0)
                        {
                            Console.WriteLine("Congratulations on your new dog!");

                            Console.WriteLine("What is this dog's name? ");
                            string name = Console.ReadLine();

                            Console.WriteLine("What is this dog's license? ");
                            string license = Console.ReadLine();

                            Console.WriteLine("What is this dog's age? ");
                            int age = int.Parse(Console.ReadLine());

                            dog = new Dog(license, name, age);
                            pets.Add(dog);

                        }
                        else
                        {
                            Console.WriteLine("Congratulations on your new cat!");

                            Console.WriteLine("What is this cat's name? ");
                            string name = Console.ReadLine();

                            Console.WriteLine("What is this cat's age? ");
                            int age = int.Parse(Console.ReadLine());

                            cat = new Cat(name, age);
                            pets.Add(cat);
                        }
                    }
                    else
                    {
                        int r = rand.Next(0,pets.Count);
                        int r2 = rand.Next(1, 6);

                        Pet p = pets[r];

                        if (p != null)
                        {
                            if (p.GetType() == typeof(Dog))
                            {
                                Dog d = (Dog)p;

                                if (r2 == 1)
                                {
                                    d.Bark();
                                }
                                if (r2 == 2)
                                {
                                    d.Eat();
                                }
                                if (r2 == 3)
                                {
                                    d.GotoVet();
                                }
                                if (r2 == 4)
                                {
                                    d.NeedWalk();
                                }
                                if (r2 == 5)
                                {
                                    d.Play();
                                }
                            }
                            else
                            {
                                Cat c = (Cat)p;

                                if (r2 == 1)
                                {
                                    c.Purr();
                                }
                                if (r2 == 2)
                                {
                                    c.Eat();
                                }
                                if (r2 == 3)
                                {
                                    c.GotoVet();
                                }
                                if (r2 == 4)
                                {
                                    c.Scratch();
                                }
                                if (r2 == 5)
                                {
                                    c.Play();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
