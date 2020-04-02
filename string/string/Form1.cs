using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @string
{
    public partial class Form1 : Form
    {
        const int INDEX_FIRST = 0;
        const int COLLECTION_TO_INDEX = 1;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox1.Text;//abcg
            string s2 =this.textBox2.Text;//c

            bool b = false;

            int n = s.Length - s2.Length;

            int n2 = s2.Length - COLLECTION_TO_INDEX;

            
                int i;
            for (i = Form1.INDEX_FIRST; i <= n; i += 1)
            {
                
                    
                    if (s2[Form1.INDEX_FIRST] == s[i] && !b)

                    {
                        int k = 0;
                        while (s2[Form1.INDEX_FIRST + k] == s[i + k] && !b && k <= n2)
                        {


                            if (k == n2)
                            {
                                MessageBox.Show(i.ToString());
                                b = true;
                                break;//無くすとエラーになってしまう

                            }




                            k += 1;
                        }
                    }






                }

                if (!b)
                {

                    MessageBox.Show("含まれません");

                }
                else
                {
                    MessageBox.Show(i.ToString());//iの数値がおかしくなってしまう

                }
            

        }


    }
}
/*namespace @string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;//abcg4
            string s2 =textBox2.Text;//ab
            int k = 0;
            bool b = false;

           
                for (int j = 0; j < s.Length - s2.Length; j++)
                {
                
                    if (s2[0] == s[j])

                    {
                  
                        while (s2[0 + k] == s[j + k])
                        {

                            if (k == s2.Length-1)
                            {
                                MessageBox.Show(j.ToString());
                                b = true;
                                
                            }

                            k++;
                        }
                    }
                }
              
                      


            if (!b)
            {

                MessageBox.Show("含まれません");
               
            }



        }

       
    }
}
*/
