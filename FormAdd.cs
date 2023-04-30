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
    public partial class FormAdd : Form
    {
        private AppDbContext _context = new AppDbContext();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(tbPrice.Text, out number))
            {
                _context.Cars.Add(new Car() { Name=tbName.Text, Price=number});
                _context.SaveChanges();
                this.Hide();
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("Ви ввели щось не то. Спробуйте знову.");
            }
        }
    }
}
