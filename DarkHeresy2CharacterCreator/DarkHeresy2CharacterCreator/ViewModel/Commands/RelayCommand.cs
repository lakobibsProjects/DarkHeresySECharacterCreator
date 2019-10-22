using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel.Commands
{
    /// <summary>
    /// code from different sources, and http://msdn.microsoft.com/en-us/magazine/dd419663.aspx among them 
    /// a command whose sole purpose is to
    /// relay its functionality to other
    /// objects by invoking delegates. The default return
    /// value for the CanExecute method is 'true'
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Fields
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;
        #endregion //Fields

        #region Constructors
        /// <summary>
        /// creates a new command
        /// </summary>
        /// <param name="execute">the delegate that provides execution routine</param>
        /// <param name="canExecute">the delegate that approves command execution</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                this.execute = (p) => { };
                this.canExecute = (p) => true;
            }

            this.execute = execute;
            this.canExecute = canExecute;
        }
        /// <summary>
        /// creates a new command
        /// </summary>
        /// <param name="execute">the delegate that provides execution routine</param>
        public RelayCommand(Action<object> execute)
        {
            if (execute == null)
            {
                this.execute = (p) => { };
                this.canExecute = (p) => true;
            }

            this.execute = execute;
            this.canExecute = (p) => true;
        }
        #endregion //Constructors

        #region ICommand members
        /// <summary>
        /// wrapper for null and not-null predicates
        /// </summary>
        /// <param name="parameter">the parameter is considered to be insignificant</param>
        /// <returns>true</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// non-parameter command caller 
        /// </summary>
        /// <param name="parameter">the parameter may be considered to be insignificant</param>
        public void Execute(object parameter)
        {
            if (execute != null)
                if (canExecute(parameter))
                    execute(parameter);
        }
        #endregion //ICommand members
    }
}
