using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LeetTranslatorGrafica.Command
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action<object> executeMethod;
        private Predicate<object> canExecuteMethod;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.executeMethod = execute;
            this.canExecuteMethod = canExecute;
        }

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {

        }

        public bool CanExecute(object parameter)
        {
            return (canExecuteMethod == null) ? true : canExecuteMethod.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            executeMethod.Invoke(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
