using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project___Joshua_Currie
{
    public partial class Add : Form
    {
        public event EventHandler<int> ScoreAdded;

        private bool isUpdate = false;

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        public Add(int score)
        {
            InitializeComponent();
            AddAddBtn.Text = "Update"; // Change button text
            AddScoretxt.Text = score.ToString(); // Display the score in the textbox
            isUpdate = true;
        }

        private void AddAddBtn_Click(object sender, EventArgs e)
        {
            // Validate if the entered text is a valid integer
            if (int.TryParse(AddScoretxt.Text, out int score))
            {
                // Raise the ScoreAdded event to pass the score to the parent form
                ScoreAdded?.Invoke(this, score);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
