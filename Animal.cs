using System;

namespace ZooProject
{
    public abstract class Creature
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        protected Creature(string name, int age, string habitat, string diet)
        {
            Name = name;
            Age = age;
            Habitat = habitat;
            Diet = diet;
        }

        // Polymorphic method to display creature info
        public virtual string GetDescription()
        {
            return $"Name: {Name}, Age: {Age}, Habitat: {Habitat}, Diet: {Diet}";
        }
    }

    // Mammal class with fur flag
    public class Mammal : Creature
    {
        public bool HasFur { get; set; }

        public Mammal(string name, int age, string habitat, string diet, bool hasFur)
            : base(name, age, habitat, diet)
        {
            HasFur = hasFur;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", Type: Mammal, Fur: {(HasFur ? "Yes" : "No")}";
        }
    }

    // Bird class with wing span
    public class Bird : Creature
    {
        public double WingSpan { get; set; }

        public Bird(string name, int age, string habitat, string diet, double wingSpan)
            : base(name, age, habitat, diet)
        {
            WingSpan = wingSpan;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $", Type: Bird, Wing Span: {WingSpan}m";
        }
    }
}