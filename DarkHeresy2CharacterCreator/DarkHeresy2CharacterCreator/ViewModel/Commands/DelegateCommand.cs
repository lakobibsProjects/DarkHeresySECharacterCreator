﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel.Commands
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> executeAction;

        public DelegateCommand(Action<object> executeAction)
        {
            this.executeAction = executeAction;
        }

        public void Execute(object parameter) => executeAction(parameter);

        public bool CanExecute(object parameter) => true;

        public event EventHandler CanExecuteChanged;
    }
}
