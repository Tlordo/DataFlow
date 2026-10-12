var container = new Container<Dog>(new Dog { Name = "Шарик" });
IContainer<Animal> animal = container;
Console.WriteLine($"IContainer<Animal>.GetItem() = {animal.GetItem()}");
