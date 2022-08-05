using NullGuard;

Person? person = Person.GetById(4);
Console.WriteLine($"{person!.Name}");
