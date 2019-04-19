using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InterfaceTable
{
    public partial class SignaturesFrom : Form
    {
        public SignaturesFrom()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.Owner;

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker(textBox1.Text, "Заведующий цехом"));
            workers.Add(new Worker(textBox2.Text, (String)comboBox2.SelectedValue));
            workers.Add(new Worker(textBox3.Text, "Бухгалтер"));

            parent.setSignatures(workers);
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
