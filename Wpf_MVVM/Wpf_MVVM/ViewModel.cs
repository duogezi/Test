using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM
{
    class ViewModel
    {
        public DelegateCommand CopyCommand { get; set; }
        public Model model { get; set; }
        public ViewModel()
        {
            this.model = new Model();
            this.CopyCommand = new DelegateCommand();
            this.CopyCommand.ExcuteCommand = new Action<object>(this.model.Copy);
        }
    }
}
