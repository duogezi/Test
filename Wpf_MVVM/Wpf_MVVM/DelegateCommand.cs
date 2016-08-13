using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_MVVM
{
    class DelegateCommand : ICommand
    {
        public Action<object> ExcuteCommand = null;
        public Func<object, bool> CanExcuteCommand = null;
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            if (CanExcuteCommand != null)
            {
                return CanExcuteCommand(parameter);
            }
            return true;
        }

        public void Execute(object parameter)
        {
            if (ExcuteCommand != null)
            {
                ExcuteCommand(parameter);
            }
        }
        public void RaiseCanExcuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this,EventArgs.Empty);
            }
        }
    }
}
