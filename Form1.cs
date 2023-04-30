using ProjectCarsTheLast.Data;
using ProjectCarsTheLast.Models;

namespace ProjectCarsTheLast
{
    public partial class Form1 : Form
    {
        private AppDbContext _context = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lbCars.DataSource = _context.Cars.ToList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAdd().Show();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMore((Car)lbCars.SelectedItem).Show();
        }

        static int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if(count==1)
            {

                this.Hide();
                new FormSell((Car)lbCars.SelectedItem).Show();
                
            }
            else
            {
                var name = ((Car)lbCars.SelectedItem).Name;
                var res = _context.Cars.Where(c => c.Name == name).Sum(c=>c.PriceSell) ;
                var res2 = _context.Cars.Where(c => c.Name == name).Sum(c => c.Price) + _context.Additionals.Where(c=>c.NameCar==name).Sum(c=>c.Price);

                var res3 = res - res2;
                MessageBox.Show($"Ціна заробітку:{res3}");

                _context.Salaries.Add(new Salary() { Name=name, Price=res3});
                _context.SaveChanges();


                _context.Cars.Remove((Car)lbCars.SelectedItem);
                _context.SaveChanges();


                count = 0;
                this.Hide();
                new Form1().Show();
            }

        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormSalary().Show();
        }
    }
}