using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataObjs
{
    public class MyDataObject: INotifyPropertyChanged 
    {
        private string mMessage;
        private int mMessageLength;

        public string Message
        {
            get
            {
                return mMessage;
            }
            set
            {
                mMessage = value;
                OnPropertyChanged();
            }
        }

        public int MessageLength
        {
            get
            {
                return mMessageLength;
            }
            set
            {
                mMessageLength = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
