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
    public partial class HistoryForm : Form
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();
        private User _currentUser;
        public HistoryForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            historyGridView.DataSource = databaseHelper.GetActivityHistory(_currentUser);
        }
    }
}
