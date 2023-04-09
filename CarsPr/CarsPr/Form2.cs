using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsPr
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        delegate void Qanak();
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> cars_List = new List<string>() { "Car1", "Car2" };
            foreach (var print in cars_List)
            {
                MessageBox.Show(print);
            }

            int count = cars_List.Count();
            Qanak qanak = () => MessageBox.Show(count + " cars under the red light");
            qanak();

            MessageBox.Show("Their models are");
            var cars_link = new List<Car>()
            {
                new Car("","BMW"),
                new Car("","TESLA"),
            };
            var cars_link_print = from c in cars_link where c.model == "TESLA" || c.model == "BMW" orderby c.model select c;
            foreach (var p in cars_link_print) { MessageBox.Show(p.model); }
        }
    }
}
