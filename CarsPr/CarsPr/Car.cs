using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace CarsPr
{
    public class Car:Transport
    {
            public string model, transport;
            public Car(string transport, string model) : base(transport,model) { this.transport = transport;this.model = model; }
            public override void Print()
            {
                MessageBox.Show($"{transport} is moving");
            }
            public override void print_model()
            {
                MessageBox.Show($"The model is {model}");
            }
    }
}
