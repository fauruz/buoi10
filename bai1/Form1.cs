using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        List<Question> lq = new List<Question>();
        public Form1()
        {
            InitializeComponent();
        }
        private void FormClear()
        {
            txtQuestion.Text = string.Empty;
            rdbA.Text = string.Empty;
            rdbB.Text = string.Empty;
            rdbC.Text = string.Empty;
            rdbD.Text = string.Empty;
        }
        private Question getQuestion()
        {
            if (txtQuestion.Text != string.Empty && txtA.Text != string.Empty && txtB.Text != string.Empty && txtC.Text != string.Empty && txtD.Text != string.Empty && cbbAnswer.SelectedIndex != -1)
            {
                Question qt = new Question();
                qt.Content = txtQuestion.Text;
                qt.A = txtA.Text;
                qt.B = txtB.Text;
                qt.C = txtC.Text;
                qt.D = txtD.Text;
                if (cbbAnswer.SelectedIndex.ToString() == "A")
                    qt.Answer = txtA.Text;
                else if(cbbAnswer.SelectedIndex.ToString() == "B")
                    qt.Answer = txtB.Text;
                else if(cbbAnswer.SelectedIndex.ToString().Equals("C"))
                    qt.Answer = txtC.Text;
                else
                    qt.Answer = txtD.Text;
                return qt;
            }
            else
            {
                MessageBox.Show("Nhập dữ liệu!");
                return null;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            Question qt = getQuestion();
            lq.Add(qt);
            qt.Id = lq.Count();
            textChange(qt);
            comboBoxUpdate();
        }
        private void textChange(Question qt)
        {
            lblQuestion.Text = qt.Content;
            rdbA.Visible = true;
            rdbB.Visible = true;
            rdbC.Visible = true;
            rdbD.Visible = true;
            btnSubmit.Visible = true;
            rdbA.Text = qt.A;
            rdbB.Text = qt.B;
            rdbC.Text = qt.C;
            rdbD.Text = qt.D;
        }
        private void comboBoxUpdate()
        {
            cbbQuestion.Items.Add("Câu hỏi " + lq.Count.ToString());
            cbbQuestion.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Question qt1 = new Question(1,"You like me?","A. Yes","B. Of course!","C. No","D. Absolutely no!","B");
            Question qt2 = new Question(2, "Lương tháng con bao nhiêu?", "Dạ, 3 triệu", "Cô hỏi làm gì?", "Dạ, 20 triệu", "Đi mà hỏi con cô ấy", "A");
            Question qt3 = new Question(3, "Nào con cưới?", "Mai", "Con độc thân", "Con đi tu", "Liên quan gì cô?", "B");
            Question qt4 = new Question(4, "Con sửa giúp cô cái máy lạnh đi?", "How?", "Con học IT cô ơi", "Giải thích blah blah...", "Không", "D");
            lq.Add(qt1);
            comboBoxUpdate();
            lq.Add(qt2);
            comboBoxUpdate();
            lq.Add(qt3);
            comboBoxUpdate();
            lq.Add(qt4);
            comboBoxUpdate();
            rdbA.Visible = false;
            rdbB.Visible = false;
            rdbC.Visible = false;
            rdbD.Visible = false;
            btnSubmit.Visible = false;
            cbbAnswer.Items.Add("A");
            cbbAnswer.Items.Add("B");
            cbbAnswer.Items.Add("C");
            cbbAnswer.Items.Add("D");
        }

        private void cbbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var item in lq)
            {
                if(cbbQuestion.SelectedIndex == item.Id-1)
                {
                    textChange(item);
                }
            }
        }

        private void rdbB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (var item in lq)
            {
                if (cbbQuestion.SelectedIndex == item.Id - 1)
                {
                    if(rdbA.Checked && rdbA.Text == item.Answer)
                    {
                        MessageBox.Show("Đúng!");
                    }
                    else if (rdbB.Checked && rdbB.Text == item.Answer)
                    {
                        MessageBox.Show("Đúng!");
                    }
                    else if (rdbC.Checked && rdbC.Text == item.Answer)
                    {
                        MessageBox.Show("Đúng!");
                    }
                    else if (rdbD.Checked && rdbD.Text == item.Answer)
                    {
                        MessageBox.Show("Đúng!");
                    }
                    else
                    {
                        MessageBox.Show("Sai!");
                    }    
                }
            }
        }
    }
}
