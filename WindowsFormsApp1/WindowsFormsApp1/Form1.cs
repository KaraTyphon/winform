using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //自适应窗体比例缩放
        //窗口加载时完成
        //

        private string _number1;

        public string Number1 
        { 
            get { return _number1; }
            set { _number1 = value;
                this.label1.Text = value; } }

        private string _number2;

        public string Number2
        {
            get { return _number2; }
            set { _number2 = value;
                this.label1.Text =Number1+ Operator + value;
            }
        }
        private string _operator;

        public string Operator
        {
            get { return _operator; }
            set { _operator = value;
                this.label1.Text = Number1 + Operator;

            }
        }



        public Form1()
        {
            InitializeComponent();
            //this.Load += Form1_Load;
            //this.SizeChanged += Form1_SizeChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取到触发这个事件的对象
            //拿到对象后获取对象的text
            Button button = (Button)sender;
            string nummber = button.Text;

            //当运算符为空时添加数字
            if (string.IsNullOrEmpty(Operator))
            {
                if (button.Text == ".")
                {
                    if (string.IsNullOrEmpty(Number1)) this.Number1 = "0";
                    if (this.Number1.IndexOf('.') <= 0)
                    {
                        this.Number1 += button.Text;
                    }
                }
                else this.Number1 += button.Text;
            }
            else
            {
                if (button.Text == ".")
                {
                    if(string.IsNullOrEmpty(Number2)) this.Number2 = "0";
                    if (this.Number2.IndexOf('.') <= 0)
                    {
                        this.Number2 += button.Text;
                    }
                }
                else this.Number2 += button.Text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String op=button.Text;
            
            if(!string.IsNullOrEmpty(Number2))
            {
                button14_Click(null, null);
            }
            this.Operator= op;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double n1=double.Parse(this.Number1);
            double n2=double.Parse(this.Number2);
            switch (Operator)
            {
                case "+":
                    this.Number1=(n1+n2).ToString();
                    break;
                case "-":
                    this.Number1 = (n1 - n2).ToString();

                    break;
                case "*":
                    this.Number1 = (n1* n2).ToString();

                    break;
                case "/":
                    this.Number1 = (n1 / n2).ToString();

                    break;
            }
            this.Operator = "";
            this.Number2 = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            this.Number1 = "";
            this.Number2 = "";
        }

        //窗体默认宽高
        //int normalWidth = 0;
        //int normalHeight = 0;
        //记录控件的位置和宽和高（X,Y,width,height）
        // Dictionary<String,Rect> normalControl = new Dictionary<String,Rect>();

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //记录相关对象以及原始尺寸
        //normalWidth=this.btnsPanel.Width;
        //normalHeight=this.btnsPanel.Height;

        //foreach (Control item in this.btnsPanel.Controls) {

        //normalControl.Add(item.Name, new Rect(item.Left,item.Top,item.Width,item.Height));
        //}
    }
    //private void Form1_SizeChanged(object sender, EventArgs e)
    //{
    //根据原始比例进行新尺寸的计算
    //int w = this.btnsPanel.Width;
    //int h = this.btnsPanel.Height;

    // foreach (Control item in this.btnsPanel.Controls)
    //{
    //int newX = (int)(w*1.0 / normalWidth * normalControl[item.Name].X);
    //int newY = (int)(h*1.0 / normalHeight * normalControl[item.Name].Y);
    //int newW = (int)(w * 1.0 / normalWidth * normalControl[item.Name].Width);
    //int newH = (int)(h * 1.0 / normalHeight * normalControl[item.Name].Height);
    //item.Left=newX;
    //item.Top = newY;
    //item.Width=newW;
    //item.Height =newH;
    //}
    //}


}

//class Rect {
//public Rect(int x, int y, int w, int h)
//{
//this.X = x;
////this.Y = y;
//this.Width = w;
//this.Height = h;
//        }

//public int X { get; set; }
//public int Y { get; set; }
//public int Width { get; set; }
//public int Height { get; set; }

//    }

//}
