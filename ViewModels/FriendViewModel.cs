using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sobrad.Models;
using sobrad.Views;

namespace sobrad.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        FriendsListViewModel lvm;
        public Friend Friend { get; private set; }

        public FriendViewModel()
        {
            Friend = new Friend();
        }
        
    }

}
