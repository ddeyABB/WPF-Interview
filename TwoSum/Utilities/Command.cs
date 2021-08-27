// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="Command.cs" company="ABB">
//   Copyright © 2009 - 2018 ABB. All rights reserved.
// </copyright>
// <summary>
//   Defines the Command class.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------

using System;
using System.Windows.Input;

namespace TwoSum.Utilities
{
   public class Command : ICommand
   {
      private Action action;
      private bool canExecute;
      public Command(Action ac, bool canExe)
      {
         action = ac;
         canExecute = canExe;
      }

      public bool CanExecute(object parameter)
      {
         return canExecute;
      }

      public event EventHandler CanExecuteChanged;

      public void Execute(object parameter)
      {
         action();
      }
   }
}
