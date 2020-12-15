using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChatApp.Models
{
    public class Participant:BaseModel
    {
        public string Name { get; set; }

        private bool _isLoggedIn = true;
        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; OnPropertyChanged(); }
        }

        public ObservableCollection<ChatMessage> Chatter { get; set; }
    }
}
