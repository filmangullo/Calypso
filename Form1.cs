using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class Form1 : Form
    {
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private String[] questions = {"Apa faktor yang menyebabkan seseorang ingin menikah?","Pertanyaan 2","Pertanyaan 3" };
        private String[,] answers = { { "Umur", "Anak-Anak", "Remaja", "Dewasa" }, { "2a", "2b", "2c", "2d" }, { "3a", "3b", "3c", "3d" } };
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (indexOfMe(answers, txtAnswer.Text) > -1)
            {
                this.Text =  answers[index, 0];
            }
            else
            {
                this.Text = "Salah";
            }
        }
         

        private void Form1_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = questions[index]; 
        }
        private int indexOfMe(String[,] obj,String kata)
        {
            for (int i = 0; i < obj.GetUpperBound(1)+1; i++)
            {
                if (obj[index, i].Equals(kata))
                {
                    return i;
                }
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            lblQuestion.Text = questions[index];
        }
    }
}
