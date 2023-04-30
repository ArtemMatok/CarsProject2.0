using ProjectCarsTheLast.Data;
using ProjectCarsTheLast.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCarsTheLast
{
    public partial class FormSell : Form
    {
        private readonly Car _car;
        private AppDbContext _context = new AppDbContext();
        public FormSell(Car car)
        {
            InitializeComponent();
           _car = car;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(tbPrice.Text, out number))
            {
                var car=_context.Cars.Find(_car.Id);
                car.PriceSell = number;
                _context.SaveChanges();
                _car.PriceSell = number;
                this.Close();
                new Form1().Show();
            }
        }

        private void FormSell_Load(object sender, EventArgs e)
        {

        }
    }
}
