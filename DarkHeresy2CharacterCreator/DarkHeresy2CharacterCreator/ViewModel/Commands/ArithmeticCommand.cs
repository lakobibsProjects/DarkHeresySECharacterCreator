using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel.Commands
{
    public class ArithmeticCommand : ICommand
    {
        private readonly Action<int?> executeAction;

        public ArithmeticCommand(Action<int?> executeAction)
        {
            this.executeAction = executeAction;
        }

        public void Execute(object parameter) => executeAction(parameter as Int32?);

        public bool CanExecute(object parameter) => true;

        public event EventHandler CanExecuteChanged;
    }
}
