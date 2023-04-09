using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsPr
{
    public abstract class Transport:IStop
    {
        public string model, transport;
        public Transport(string transport,string model) { }
        abstract public void Print();
        abstract public void print_model();
        public void Stop()
        {
            MessageBox.Show($"{transport} Stopped");
        }
    }
}
