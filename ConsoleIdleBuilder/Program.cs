using ConsoleIdleBuilder;
using System.Data.SQLite;

Console.WriteLine("Welcome to Idle Builder!");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("version: 0.0.1");
Console.ForegroundColor= ConsoleColor.White;
Console.WriteLine("\n\nPlease wait while the database initializes...");
//DatabaseHelper.InitializeDatabase();
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("\nDatabase Created!");
Console.ForegroundColor= ConsoleColor.White;
Console.WriteLine("Press any key to begin game!");
Console.ReadLine();