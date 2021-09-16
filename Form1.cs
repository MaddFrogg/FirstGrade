using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGrade
{
    public partial class Form1 : Form
    {
        firstgradeEntities objet = new firstgradeEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objet.people.ToList();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            objet.SaveChanges();
            MessageBox.Show("Data has saved/display successfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            person foo=objet.people.Add(new person());
            Form2 form= new Form2(foo,this);
            form.Show(this);
        }
    }
}
