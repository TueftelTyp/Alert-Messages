using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Alert(string msgTitle, string msgText, AlertForm.enmType type)
        {
            AlertForm frm = new AlertForm();
            frm.showAlert(msgTitle,msgText,type);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Alert("Success","it's done.", AlertForm.enmType.Success);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Alert("Warning","Don't do that!", AlertForm.enmType.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Alert("Error","an error okurett.", AlertForm.enmType.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Alert("Info","I'm blue..dabedidabedei", AlertForm.enmType.Info);
        }
    }
}
