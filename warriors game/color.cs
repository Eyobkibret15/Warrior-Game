using System;

static class color
{
  public static void make_color(string text , ConsoleColor color)
  {
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();

  }
}