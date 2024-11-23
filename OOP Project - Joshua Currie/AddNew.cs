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
    public partial class AddNew : Form
    {
        public event EventHandler<StudentAddedEventArgs> StudentAdded;

        private List<int> scores = new List<int>();
        public AddNew()
        {
            InitializeComponent();
        }

        private void AddScoreBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Scoretxt.Text))
            {
                if (int.TryParse(Scoretxt.Text, out int score))
                {
                    scores.Add(score);
                    UpdateScoresLabel();
                    Scoretxt.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a valid score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void UpdateScoresLabel()
        {
            Scoreslbl.Text = string.Join(", ", scores);
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            string name = AddNametxt.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a student name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StudentAdded?.Invoke(this, new StudentAddedEventArgs(name, scores));

            this.Close();

        }

        private void ClearScoresBtn_Click(object sender, EventArgs e)
        {
            scores.Clear();
            Scoreslbl.Text = "";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class StudentAddedEventArgs : EventArgs
    {
        public string StudentName { get; }
        public List<int> Scores { get; }

        public StudentAddedEventArgs(string name, List<int> scores)
        {
            StudentName = name;
            Scores = scores;
        }
    }
}

