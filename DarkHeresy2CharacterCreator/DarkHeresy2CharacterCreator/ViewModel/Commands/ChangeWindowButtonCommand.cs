using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DarkHeresy2CharacterCreator.ViewModel.Commands
{
    /// <summary>
    /// Command to switch between windows on button click
    /// </summary>
    public class ChangeWindowButtonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Window nextWindow;
        public Window thisWindow;

        /// <summary>
        /// General constructor to change window command
        /// </summary>
        /// <param name="thisWindow">Window that have button</param>
        /// <param name="nextWindow">Window that must being opened</param>
        public ChangeWindowButtonCommand(Window thisWindow, Window nextWindow)
        {
            this.thisWindow = thisWindow;
            this.nextWindow = nextWindow;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (thisWindow != null)            
                thisWindow.Close();
            if (nextWindow != null)                       
                nextWindow.Show();
        }
    }
}
