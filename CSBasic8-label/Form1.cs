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

            GroupBox gp1 = new GroupBox()
            {
                Text = "작물", Size = new Size(105, 100),
                Location = new Point(250, 10)
            };
            RadioButton radioButton1 = new RadioButton()
            {
                Text = "감자",
                Location = new Point(10, 10)
            };
            RadioButton radioButton2 = new RadioButton()
            {
                Text = "고구마",
                Location = new Point(10, 40)
            };
            RadioButton radioButton3 = new RadioButton()
            {
                Text = "옥수수",
                Location = new Point(10, 70)
            };
            gp1.Controls.Add(radioButton1);
            gp1.Controls.Add(radioButton2);
            gp1.Controls.Add(radioButton3);
            Controls.Add(gp1);

            GroupBox gp2 = new GroupBox()
            {
                Text = "물고기",
                Size = new Size(105, 100),
                Location = new Point(370, 10)
            };
            RadioButton radioButton4 = new RadioButton()
            {
                Text = "광어",
                Location = new Point(10, 10)
            };
            RadioButton radioButton5 = new RadioButton()
            {
                Text = "연어",
                Location = new Point(10, 40)
            };
            RadioButton radioButton6 = new RadioButton()
            {
                Text = "참치",
                Location = new Point(10, 70)
            };
            gp2.Controls.Add(radioButton4);
            gp2.Controls.Add(radioButton5);
            gp2.Controls.Add(radioButton6);
            Controls.Add(gp2);

            Button radioButton = new Button()
            {
                Text = "라디오버튼", Location = new Point(250,120),
                Size = new Size(230, 20)
            };
            Controls.Add(radioButton);
            radioButton.Click += radioButtonClick;

        }

        private void radioButtonClick(object sender, EventArgs e)
        {
            foreach( var outerItem in Controls)
            {
                if( outerItem is GroupBox)
                {
                    GroupBox gp = outerItem as GroupBox;
                    foreach( RadioButton item in gp.Controls)
                    {
                        if (item.Checked)
                        {
                            MessageBox.Show(item.Text);
                        }
                    }
                }
            }
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
