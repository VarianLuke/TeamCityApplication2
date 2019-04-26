using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamCityApplication
{
    public partial class TeamCityApplication : Form
    {
        public TeamCityApplication()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var bl = new BusinessLogic();

            bl.DoTheThing();
        }
    }
}
