namespace CarsPr
{
    public partial class Form1 : Form
    {
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Transport car = new Car("Car", "TESLA");
            car.Print();

            Task task1 = new Task(() =>
            {
                Task task2 = new Task(() => car.print_model());
                task2.Start();
                task2.Wait();
            });
            task1.Start();
            task1.Wait();

            car.Stop();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
            var imgSize = pictureBox1.Image.Size;
            void changeSize()
            {
                if (imgSize != pictureBox1.Size)
                {
                    imgSize = pictureBox1.Size;
                }
            }
            changeSize();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.ShowDialog();
        }
    }
}