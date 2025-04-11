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
        DatabaseHelper _dbHelper = new DatabaseHelper();
        private User _currentUser;
        public HistoryForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            historyGridView.DataSource = _dbHelper.GetActivityHistory(_currentUser);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchInput.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (_dbHelper.GetHistoryByActivity(_currentUser, searchText) == null)
                {
                    MessageBox.Show("No results found.", "Search result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    historyGridView.DataSource = _dbHelper.GetActivityHistory(_currentUser);
                    searchInput.Text = string.Empty;
                    searchInput.Focus();
                } else
                {
                    historyGridView.DataSource = _dbHelper.GetHistoryByActivity(_currentUser, searchText);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            historyGridView.DataSource = _dbHelper.GetActivityHistory(_currentUser);
            searchInput.Text = string.Empty;
            searchInput.Focus();
        }
    }
}
