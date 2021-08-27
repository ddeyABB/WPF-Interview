// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="MainWindowViewModel.cs" company="ABB">
//   Copyright © 2009 - 2018 ABB. All rights reserved.
// </copyright>
// <summary>
//   Defines the MainWindowViewModel class.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using TwoSum.Models;
using TwoSum.Utilities;

namespace TwoSum.ViewModels
{
   public class MainWindowViewModel : INotifyPropertyChanged
   {
      #region Fields
      private ICommand generatePairCommand;
      #endregion

      #region Constructors
      public MainWindowViewModel()
      {
         Pairs = new ObservableCollection<NumberPair>();
         NumberList = new List<int>();
         NumberList.AddRange(GetTestData());
         Total = 10;
      }
      #endregion

      #region Events

      #endregion

      #region Enums

      #endregion

      #region Properties
      public event PropertyChangedEventHandler PropertyChanged;
      public List<int> NumberList { get; set; }
      public int Total { get; set; }
      public ObservableCollection<NumberPair> Pairs { get; set; }
      public ICommand GeneratePairCommand
      {
         get
         {
            return generatePairCommand ?? (generatePairCommand = new Command(() => RunGeneratePairCommand(), true));
         }
      }
      public string NumberListString
      {
         get
         {
            return string.Join(" , ", NumberList);
         }
      }
      #endregion

      #region Public Methods

      #endregion

      #region Internal Methods

      #endregion

      #region Protected Methods

      #endregion

      #region Private Methods
      private void NotifyPropertyChanged(string propertyName)
      {
         if (PropertyChanged != null)
         {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
         }
      }
      private List<int> GetTestData()
      {
         return new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
      }

      private void RunGeneratePairCommand()
      {
         foreach(var number in NumberList)
         {
            //do something to generate the pairs
         }
      }
      #endregion

   }
}
