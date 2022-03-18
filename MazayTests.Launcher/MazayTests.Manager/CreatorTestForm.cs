using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazayTests.Manager
{
    public partial class CreatorTestForm : Form
    {
        TestGenerator test = new();
        Question question = new();
       //для пулреквеста

        public CreatorTestForm()
        {
            InitializeComponent();    
        }
        private void CreatorTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new ManagerTestsForm().Show();
            Hide();
        }

        private void CreatorTestForm_Load(object sender, EventArgs e)
        {

        }

        private void questionTextBox_TextChanged(object sender, EventArgs e)
        {
            //questionTextBox.Text = question.Text;
        }

        private void rightAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addRightAnswer_Click(object sender, EventArgs e)
        {
            question.RightAnswers.Add(questionTextBox.Text);
            rightAnswerTextBox.Clear();
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            Answer answer = new();
            answer.Text = answerTextBox.Text;
            question.Answers.Add(answer);
            answerTextBox.Clear();
        }

        private void addQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
