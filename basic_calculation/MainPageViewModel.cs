﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMLUI.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            EraseCommand = new Command(() =>
            {
                TheNote = string.Empty;
            });

            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);

                TheNote = string.Empty;
            });



        }

        public ObservableCollection<string> AllNotes { get; set; }
        
        public event PropertyChangedEventHandler PropertyChanged;

        string theNote;

        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;

                var args = new PropertyChangedEventArgs(nameof(TheNote));

                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command SaveCommand { get; }
        public Command EraseCommand { get; }
    }
}
