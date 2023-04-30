using ProjectCarsTheLast.Data;
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
    public partial class FormSalary : Form
    {
        private AppDbContext _context = new AppDbContext();
        public FormSalary()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void FormSalary_Load(object sender, EventArgs e)
        {
            lbSalary.DataSource = _context.Salaries.ToList();
        }
    }
}
