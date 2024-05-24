namespace EmployeeApplication1
{
    public partial class  ComputeSalary : Form
    {
        public ComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = textBox1.Text; 
            string lastname = textBox2.Text;   
            string department = textBox3.Text;
            string jobtitle = textBox4.Text;    
            double rateperhour = double.Parse(textBox5.Text);
            int totalhoursworked = int.Parse(textBox6.Text);

            PartTimeEmployee employee = new PartTimeEmployee(firstname, lastname, department, jobtitle);
            employee.ComputeSalary(totalhoursworked, rateperhour);

            lblFirstname.Text = employee.FirstName;
            lblLastname.Text = employee.LastName;
            lblBasicsalary.Text = employee.GetSalary().ToString("0.00");


        }
    }
}
