using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marktsimulator_2024
{
    public partial class Form2 : Form
    {
        private List<int> _attributes;
        public Form2(List<int> attributes)
        {
            _attributes = attributes;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
