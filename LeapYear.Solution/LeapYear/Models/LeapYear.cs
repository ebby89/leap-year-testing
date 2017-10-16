using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LeapYear
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      //eventually my code goes here
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }
  }
}
