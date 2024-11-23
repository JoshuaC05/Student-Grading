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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListBox();
            StudentLB.SelectedIndexChanged += StudentLB_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentLB.SelectedIndex = 0;
        }

        private void InitializeListBox()
        {
            foreach (var student in StudentData.StudentScores)
            {
                string gradeString = string.Join(" | ", student.Value);
                StudentLB.Items.Add($"{student.Key} | {gradeString}");
            }
        }

        public void AddStudentToListBox(string name, List<int> scores)
        {
            string scoresString = string.Join(" | ", scores);
            StudentLB.Items.Add($"{name} | {scoresString}");
            StudentData.StudentScores.Add(name, scores);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (var addNewForm = new AddNew())
            {
                addNewForm.StudentAdded += AddNewForm_StudentAdded;
                addNewForm.ShowDialog();
            }
        }

        private void AddNewForm_StudentAdded(object sender, StudentAddedEventArgs e)
        {
            AddStudentToListBox(e.StudentName, e.Scores);
        }

        private void StudentLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentLB.SelectedIndex != -1)
            {
                string selectedStudent = StudentLB.SelectedItem.ToString();
                string[] parts = selectedStudent.Split('|');
                string studentName = parts[0].Trim();
                List<int> scores = parts.Skip(1).Select(part => int.Parse(part.Trim())).ToList();

                int sumOfGrades = scores.Sum();
                int numberOfGrades = scores.Count;
                double averageGrade = Math.Round((double)sumOfGrades / numberOfGrades, 2);

                ScoreTotallbl.Text = sumOfGrades.ToString();
                ScoreCountlbl.Text = numberOfGrades.ToString();
                Averagelbl.Text = averageGrade.ToString("0.00");
            }
            else
            {
                ScoreTotallbl.Text = "";
                ScoreCountlbl.Text = "";
                Averagelbl.Text = "";
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (StudentLB.SelectedItem != null)
            {
                string selectedItem = StudentLB.SelectedItem.ToString();
                string studentName = selectedItem.Split('|')[0].Trim();
                List<int> scores = selectedItem.Split('|').Skip(1).Select(part => int.Parse(part.Trim())).ToList();

                using (var updateForm = new UpdateStudent(studentName, scores))
                {
                    updateForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (StudentLB.SelectedItem != null)
            {
                string selectedItem = StudentLB.SelectedItem.ToString();
                if (selectedItem.Contains("|"))
                {
                    StudentLB.Items.Remove(StudentLB.SelectedItem);
                    string studentName = selectedItem.Split('|')[0].Trim();
                    StudentData.StudentScores.Remove(studentName);
                }
                else
                {
                    MessageBox.Show("Selected item format is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static class StudentData
        {
            public static Dictionary<string, List<int>> StudentScores = new Dictionary<string, List<int>>()
            {
                {"Alan Turing", new List<int>(){97, 91, 83}},
                {"Grace Hopper", new List<int>(){99, 93, 97}},
                {"Ada Lovelace", new List<int>(){100, 100, 100}}
            };
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}