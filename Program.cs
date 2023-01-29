using MathGame;

Console.WriteLine("Please enter your name:");
string userName = Console.ReadLine();

MainMenu menu = new MainMenu();
menu.DisplayMenu(userName);