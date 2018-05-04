﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace SchoolManagement.Desktop.Helpers
{
    public class RelayCommand : ICommand
    {
        private Action<object> ExecuteAction { get; set; }
        private Predicate<object> CanExecutePredicate { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public RelayCommand(Action<object> action)
        {
            this.ExecuteAction = action;
        }

        public RelayCommand(Action<object> executeAction, Predicate<object> canExecutePredicate)
        {
            this.ExecuteAction = executeAction;
            this.CanExecutePredicate = canExecutePredicate;
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return this.CanExecutePredicate == null || this.CanExecutePredicate(parameter);
        }

        [DebuggerStepThrough]
        public void Execute(object parameter)
        {
            if (this.ExecuteAction != null)
            {
                this.ExecuteAction(parameter);
            }
        }

        [DebuggerStepThrough]
        public void InvalidateRequerySuggested()
        {
            Dispatcher dispatcher = Application.Current.Dispatcher;
            if (dispatcher.CheckAccess())
            {
                CommandManager.InvalidateRequerySuggested();
            }
            else
            {
                dispatcher.BeginInvoke(new Action(CommandManager.InvalidateRequerySuggested));
            }
        }
    }
}
