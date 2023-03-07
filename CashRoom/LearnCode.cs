using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRoom
{
    public partial class LearnCode : Form
    {
        public LearnCode()
        {
            InitializeComponent();
        }

        private void LearnCode_Load(object sender, EventArgs e)
        {
            int? a1;
            byte a2;
            //string strByte =$"a1={a1},a2={a2}";
            MessageBox.Show(a1.ToString());
        }
    }
}
