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
    public partial class Form2 : Form
    {
        private readonly Form1 _parent;
        private readonly person _person;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(person person,Form1 parent) 
        {
            _parent = parent;
            _person = person;
            InitializeComponent();
        }
        private void fn_TextChanged(object sender, EventArgs e)
        {
            _person.fn=fn.Text;

        }
        private void mn_TextChanged(object sender, EventArgs e)
        {
            _person.mn = mn.Text;

        }
        private void ln_TextChanged(object sender, EventArgs e)
        {
            _person.ln = ln.Text;

        }

        private void prsnSave_Click(object sender, EventArgs e)
        {
            _parent.btnSave_Click(sender,e);
            this.Close();
        }
    }
}
