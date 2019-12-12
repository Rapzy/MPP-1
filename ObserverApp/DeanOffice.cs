using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp
{
    public class DeanOffice
    {
        public delegate string EventHandler(string message);
        public event EventHandler OnSessionStart, OnNewMessage, OnNewShedule;
        public string SessionStart()
        {
            return OnSessionStart?.Invoke("Session is started"); 
        }
        public string NewMessage()
        {
            return OnNewMessage?.Invoke("You have a new message");
        }
        public string NewShedule()
        {
            return OnNewShedule?.Invoke("Shedule is updated");
        }
    }
}
