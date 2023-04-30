using ProjectCarsTheLast.Data;
using ProjectCarsTheLast.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCarsTheLast
{
    public partial class FormMoreAdd : Form
    {
        private readonly Car _car;
        private AppDbContext _context = new AppDbContext();
        public FormMoreAdd(Car car)
        {
            InitializeComponent();
            _car = car;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(tbPrice.Text, out number))
            {
                _context.Additionals.Add(new Additional() {Name=tbName.Text, Price=number, NameCar=tbCarName.Text });
                _context.SaveChanges();
                this.Hide();
                new FormMore(_car).Show();
            }
            else
            {
                MessageBox.Show("Ви ввели щось не то. Спробуйте знову");
            }
        }

        private void FormMoreAdd_Load(object sender, EventArgs e)
        {
            labNameCar.Text = _car.Name;
        }
    }
}
