using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSBasic8_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label label = new Label() { 
                Text="글자", Location = new Point(10,10)
            };
            //label.Text = "글자";
            //label.Location = new Point(10, 10);
            Controls.Add(label);

            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "글자",
                Location = new Point(10, 50)
            };
            Controls.Add(linkLabel);
            linkLabel.Click += LabelClick;

            CheckBox checkBox1 = new CheckBox(){ 
                Text="감자", Location = new Point(130,10)
            };
            CheckBox checkBox2 = new CheckBox(){
                Text = "고구마", Location = new Point(130, 40)
            };
            CheckBox checkBox3 = new CheckBox(){
                Text = "옥수수", Location = new Point(130, 70)
            };
            Button button = new Button(){
                Text = "체크박스", Location = new Point(130, 100)
            };
            Controls.Add(checkBox1); Controls.Add(checkBox2);
            Controls.Add(checkBox3); Controls.Add(button);
            button.Click += CheckBoxClick;
        }

        private void CheckBoxClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach( var control in Controls)
            {
                if( control is CheckBox)
                {
                    CheckBox cb = control as CheckBox;
                    if (cb.Checked)
                    {
                        list.Add(cb.Text);
                    }
                }
            }
            MessageBox.Show(string.Join(",", list));
        }

        private void LabelClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.naver.com");
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
