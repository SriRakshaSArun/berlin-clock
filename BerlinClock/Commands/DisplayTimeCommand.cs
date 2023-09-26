﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BerlinClock.Commands
{
    public class DisplayTimeCommand : ICommand
    {
        private Action _execute;
        public event EventHandler? CanExecuteChanged;
        public DisplayTimeCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute.Invoke();
         }
    }
}
