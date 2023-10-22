using System;
//20231022_AndrewHorton_Exercise5.2

class Program {
  public static void Main (string[] args) {
    int x = 0;
    int[] tempetures = {0, 0, 0, 0, 0};
    int warmCheck = 0;
    int coldCheck = 0;
    decimal average;

    Console.WriteLine ("Please enter 5 daily Fahrenheit tempetures from a range of -30 to 130");
    while (x < 5)
    {
      Console.WriteLine ("INPUT Temperature");
      var inputValue = Console.ReadLine();

      if (int.TryParse(inputValue, out tempetures[x]))
      {
        if ((tempetures[x] < -30)||(tempetures[x] > 130))
        {
          Console.WriteLine("Temperature {0} is invalid, Please enter a valid temperature between -30 and 130", tempetures[x]);
        }
        else 
        {
          x++;
        }
      }
      else {
        Console.WriteLine("Please only put the number" );
      }
    }
    
    for (x = 1; x < 5; x++)
    {
        if (tempetures[x-1] < tempetures[x])
        {
          warmCheck = 1;
        }
        else if (tempetures[x-1] > tempetures[x])
        {
          coldCheck = 1;
        }
    }
    if ((warmCheck == 1) && (coldCheck == 0))
    {
      Console.WriteLine ("Getting warmer");
    }
    else if ((warmCheck == 0) && (coldCheck == 1))
    {
      Console.WriteLine ("Getting colder");
    }
    else if ((warmCheck == 1) && (coldCheck == 1))
    {
      Console.WriteLine ("It’s a mixed bag");
    }
    else if ((warmCheck == 0) && (coldCheck == 0))
    {
      Console.WriteLine ("It’s a mixed bag");
    }

    average = (tempetures[0] + tempetures[1] + tempetures[2] + tempetures[3] + tempetures[4]);
    average = average/ 5;
    Console.WriteLine ("5-day Temperature [{0}, {1}, {2}, {3}, {4}]", tempetures[0], tempetures[1], tempetures[2], tempetures[3], tempetures[4]);
    Console.WriteLine ("Average Temperature is {0} degrees", average);
  }
}