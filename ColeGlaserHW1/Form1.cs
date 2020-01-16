using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColeGlaserHW1
{
	public partial class fmOrder : Form
	{
		public fmOrder()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("button1 was clicked");
        }
    }
}
