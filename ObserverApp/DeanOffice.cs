using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp
{
    public class DeanOffice
    {
        public delegate void EventHandler(string message);
        public event EventHandler OnSessionStart, OnNewMessage, OnNewShedule;
        public void SessionStart()
        {
            OnSessionStart("Session is started");
        }
        public void NewMessage()
        {
            OnNewMessage?.Invoke("You have a new message");
        }
        public void NewShedule()
        {
            OnNewShedule?.Invoke("Shedule is updated");
        }
    }
}
