// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="NumberPair.cs" company="ABB">
//   Copyright © 2009 - 2018 ABB. All rights reserved.
// </copyright>
// <summary>
//   Defines the NumberPair class.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------

namespace TwoSum.Models
{
   public class NumberPair
   {
      public NumberPair(int pair1,int pair2):base()
      {
         Pair1 = pair1;
         Pair2 = pair2;
      }
      
      public int Pair1 { get; set; }
      public int Pair2 { get; set; }
   }
}
