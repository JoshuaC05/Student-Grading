using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOP_Project___Joshua_Currie.Form1;

namespace OOP_Project___Joshua_Currie
{
    public partial class UpdateStudent : Form
    {
        public event EventHandler ChangesConfirmed;

        public UpdateStudent()
        {
            InitializeComponent();
        }

        public UpdateStudent(string studentName, List<int> scores) : this()
        {
            UpdateNametxt.Text = studentName;

            foreach (var score in scores)
            {
                UpdateScoreLB.Items.Add(score);
            }
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void UpdateAddBtn_Click(object sender, EventArgs e)
        {
            using (var addForm = new Add())
            {
                addForm.ScoreAdded += (s, score) =>
                {
                    UpdateScoreLB.Items.Add(score);
                };
                addForm.ShowDialog();
            }
        }

        private void UpdateUpdateBtn_Click(object sender, EventArgs e)
        {
            if (UpdateScoreLB.SelectedIndex != -1)
            {
                if (UpdateScoreLB.SelectedItem is int selectedScore)
                {
                    using (var addForm = new Add(selectedScore))
                    {
                        addForm.ScoreAdded += (s, score) =>
                        {
                            UpdateScoreLB.Items[UpdateScoreLB.SelectedIndex] = score;
                        };
                        addForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a score to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRemoveBtn_Click(object sender, EventArgs e)
        {
            if (UpdateScoreLB.SelectedIndex != -1)
            {
                UpdateScoreLB.Items.RemoveAt(UpdateScoreLB.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a score to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateClearBtn_Click(object sender, EventArgs e)
        {
            UpdateScoreLB.Items.Clear();
        }

        private void UPOKBtn_Click(object sender, EventArgs e)
        {
            // Raise event to notify changes confirmed
            ChangesConfirmed?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void UpCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
