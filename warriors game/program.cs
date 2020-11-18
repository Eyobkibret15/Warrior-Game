using System;
class program
{
 int miki_health = 10;
 int eyob_health = 10;
 string name;
 
soldier  obj1 = new soldier("miki","111");
archer  obj2 = new archer("eyob","000");

string[] weapons = {"weapon", "second_weapon"};
string[] warriors = {"soldier", "archer"};
Random rand = new Random();
Random rand2 = new Random();

public  void game()
{
 while (eyob_health > 0 && miki_health > 0 )
 {
  int index = rand.Next(warriors.Length);
  int index2 = rand2.Next(weapons.Length);
 switch (  warriors[index] )
 {
   case "soldier" :
   Console.Write(obj1.User_name + " attack " + obj2.User_name + " with  ");
   if (weapons[index2] == "weapon")
   {
   Console.WriteLine(obj1.weapon());
   eyob_health -= 2;
   }
   else
   {
   Console.WriteLine(obj1.second_weapon);
   eyob_health -= 1;
   }
   break;
  case "archer" :
  Console.Write(obj2.User_name + " attack " + obj1.User_name + " with ");
  if (weapons[index2] == "weapon")
   {
   Console.WriteLine(obj2.weapon());
   miki_health-= 2;
   }
   else
   {
   Console.WriteLine(obj2.second_weapon);
   miki_health -= 1;
   }
   break;
 }
if (eyob_health < 0 || miki_health < 0)
{
return;
}
Console.WriteLine(obj1.User_name + "'s health = " + miki_health);
Console.WriteLine(obj2.User_name + "'s health = " + eyob_health);   
}
}


public void game_result()
{
game();
if (name == obj1.User_name)
{
  obj1.User_name = "you";
}
else{
  obj2.User_name = "you";
}
Console.WriteLine();

if (eyob_health <= 0)
{
  color.make_color($"{obj1.User_name + "  win the battle"}",ConsoleColor.Green);
  color.make_color($"{obj2.User_name + "  die"}",ConsoleColor.Red);
}

else if (miki_health <= 0)
{ 
  color.make_color($"{ obj2.User_name + "  win the battle"}",ConsoleColor.Green);
   color.make_color($"{obj1.User_name + "  die"}",ConsoleColor.Red);
} 
}


public void log_in()
{
 Console.WriteLine("please enter your user name : ");
 string name = Console.ReadLine();
 Console.WriteLine("please enter your password : ");
 string password = Console.ReadLine();

 if (name == obj1.User_name && password == obj1.Password)
 {
color.make_color($"{"welcome to the battle fild "+ name}",ConsoleColor.Blue);
   game_result();
 }

 else if (name == obj2.User_name && password == obj2.Password)
 {
  color.make_color($"{"welcome to the battle fild "+ name}",ConsoleColor.Blue);
   Console.WriteLine();
   game_result();
 }
}}