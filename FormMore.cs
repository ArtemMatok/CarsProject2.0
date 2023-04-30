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
    public partial class FormMore : Form
    {
        private readonly Car _car;
        private AppDbContext _context = new AppDbContext();
        public FormMore(Car car)
        {
            InitializeComponent();
            _car = car;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void FormMore_Load(object sender, EventArgs e)
        {
            var sumAdditional = _context.Additionals.Where(a => a.NameCar == _car.Name).Sum(c => c.Price);
            var res = _car.Price + sumAdditional;
            labSum.Text = res.ToString() + "$";
            lbCars.DataSource = _context.Additionals.Where(a => a.NameCar == _car.Name).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMoreAdd(_car).Show();
        }
    }
}
