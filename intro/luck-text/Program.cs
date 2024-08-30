string name;
string colour; 
string music;



Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear(); 

Console.WriteLine("Skriv dit namn");
name= Console.ReadLine(); 

// Console.WriteLine("Hello " + name +"!");
Console.WriteLine($"Hello{name}!");

Console.WriteLine("Skriv din favorit färg");
colour= Console.ReadLine();

Console.WriteLine("favorit låt");
music= Console.ReadLine();




Console.WriteLine($"Hej{name}! jag ser att du gillar {colour} Jag ser att du gillar {music}");

Console.ReadLine(); 