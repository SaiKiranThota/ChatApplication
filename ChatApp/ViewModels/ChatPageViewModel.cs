using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChatApp.ViewModels
{
    public class ChatPageViewModel:BaseModel
    {
        private ObservableCollection<Participant> _participants = new ObservableCollection<Participant>();
        public ObservableCollection<Participant> Participants
        {
            get { return _participants; }
            set
            {
                _participants = value;
                OnPropertyChanged();
            }
        }
        private Participant _selectedParticipant;
        public Participant SelectedParticipant
        {
            get { return _selectedParticipant; }
            set
            {
                _selectedParticipant = value;
                OnPropertyChanged();
            }
        }

        public ChatPageViewModel()
        {
            Participants = new ObservableCollection<Participant>
            {
                new Participant
                {
                    Name="Sai",
                    IsLoggedIn=true,
                    Chatter=new ObservableCollection<ChatMessage>
                    {
                        new ChatMessage
                        {
                            Message="M1",
                            Author="Sai",
                            Time=DateTime.UtcNow.AddHours(-1)
                        },
                        new ChatMessage
                        {
                            Message="M2",
                            Author="D",
                            Time=DateTime.UtcNow.AddDays(-1)
                        }
                    }
                },
                new Participant
                {
                    Name="D",
                    IsLoggedIn=true,
                    Chatter=new ObservableCollection<ChatMessage>
                    {
                        new ChatMessage
                        {
                            Message="M1",
                            Author="Sai",
                            Time=DateTime.UtcNow.AddHours(-1)
                        },
                        new ChatMessage
                        {
                            Message="M2",
                            Author="D",
                            Time=DateTime.UtcNow.AddDays(1)
                        }
                    }
                }
            };
        }
    }
}
