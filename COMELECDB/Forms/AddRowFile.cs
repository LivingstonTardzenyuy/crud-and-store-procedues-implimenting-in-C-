using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMELECDB.General;
namespace COMELECDB.Forms
{
    public partial class AddRowFile : Template
    {
        public AddRowFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppConnection.GetConnectionString());
        }
    }
}
