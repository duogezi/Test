using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM
{
    class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                this.PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
