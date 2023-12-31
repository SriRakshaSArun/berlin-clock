﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BerlinClock.Commands
{
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// The Action Reference variable.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// The Predicate Reference variable.
        /// </summary>
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The Action to be executed.</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The Action to be executed.</param>
        /// <param name="canExecute">The can execute predicate.</param>
        /// <exception cref="System.ArgumentNullException">The ArgumentNull Exception.</exception>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this._execute = execute ?? throw new ArgumentNullException("execute");
            this._canExecute = canExecute;
        }

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public bool CanExecute(object parameter) => this._canExecute == null ? true : this._canExecute(parameter);

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
    }
}
