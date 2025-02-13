using Fitness_Tracker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker.Forms
{
    public partial class frmHistory : Form
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();
        clsUser currentUser;
        public frmHistory(clsUser user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            dgvHistory.DataSource = databaseHelper.GetActivityHistory(currentUser);
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
