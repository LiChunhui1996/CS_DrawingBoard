//开发人员：李纯辉   2016118162   软件工程（1）班
//开发目标：实现一个画图板。在此画图板中可以画直线、圆、矩形等各种图形，并可设置绘画图形的颜色、粗细，设置橡皮进行擦除，及对图形文件操作等。
//开发时间：2018年12月
//完成情况：基本实现项目需求，存在未知错误。
//联系方式：435298943@qq.com


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

       //定义全局变量
        private Bitmap oldBitmap;   //初始化画纸 
        private Graphics graphics;
        private static Color nowColor = Color.Black;  //初始化颜色
        string fileName;  //初始化图片名称
        Pen pen;  //初始化画笔

        Point pointA;   //定义点
        Point pointB;
        Point pointNow;
        Point pointStop;
        Size fontSize = new Size(2,2);   //定义字体大小
        bool printing;   //判断鼠标状态
        string function;        //功能选择

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            新建_Click(sender, e);
            label1.Text = "李纯辉设计\r\nROLLHOOP";
        }

        private void 新建_Click(object sender, EventArgs e)
        {
            oldBitmap = new Bitmap(Properties.Resources.Image1);
            pictureBox1.Size = new Size(oldBitmap.Height, oldBitmap.Width);
            pictureBox1.BackgroundImage = oldBitmap;
            graphics = Graphics.FromImage(oldBitmap);   //得到画布
            fileName = "";
        }

        private void 加载_Click(object sender, EventArgs e)
        {
//            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                Console.WriteLine(openFileDialog1.FileName);
                oldBitmap = new Bitmap(fileName);  //背景图片
                pictureBox1.Size = new Size(oldBitmap.Width, oldBitmap.Height);
                pictureBox1.BackgroundImage = oldBitmap;
                graphics = Graphics.FromImage(oldBitmap);   //得到画布
            }
            fileName = "";

        }

        private void 保存_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fileName = saveFileDialog1.FileName + "_edit.jpg";
            Console.WriteLine(fileName);
            oldBitmap.Save(fileName);
        }

        private void 写字_Click(object sender, EventArgs e)
        {
            function = "写字";
            label1.Text = "添加水印";
            string str = "Design By : LCH-2016118162"; //写什么字？ 
            Font font = new Font("宋体", 10); //字是什么样子的？ 
            Brush brush = Brushes.Red; //用红色涂上我的字吧； 
            Point point = new Point(2, 2); //从什么地方开始写字捏？ 
            graphics.DrawString(str, font, brush, point);  //在画布上面写字
            Refresh(sender, e);
        }

        private void Refresh(Object sender,EventArgs e)
        {
            pictureBox1.Image = oldBitmap;
        }

        //鼠标按下
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            printing = true;
            pointA = new Point(e.X, e.Y);
        }
        //鼠标收起
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            printing = false;
            pen = new Pen(nowColor);
            pointStop = new Point(e.X, e.Y);
            switch (function)
            {
                case "划线":
                    Console.WriteLine(nowColor.ToString());
                    graphics.DrawLine(pen, pointA, pointStop);
                    break;
                case "矩形":
                    Size size = new Size(pointStop.X-pointA.X, pointStop.Y-pointA.Y);
                    //Size size = new Size(Math.Abs(pointStop.X - pointA.X), Math.Abs(pointStop.Y - pointA.Y));
                    Rectangle rectangle = new Rectangle(pointA,size);
                    graphics.DrawRectangle(pen, rectangle);
                    break;
                case "圆形":
                    size = new Size(pointStop.X - pointA.X, pointStop.Y - pointA.Y);
                    //Size size = new Size(Math.Abs(pointStop.X - pointA.X), Math.Abs(pointStop.Y - pointA.Y));
                    rectangle = new Rectangle(pointA, size);
                    graphics.DrawEllipse(pen,rectangle);
                    
                    break;
            }

        }
        //鼠标移动
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Refresh(sender, e);
            pen = new Pen(nowColor);
            if (printing)
            {
                pointNow = new Point(e.X, e.Y);
                pointB = pointNow;
                Console.WriteLine(pointA.ToString()+"     "+pointB.ToString());

                switch (function)
                {
                    case "写字":
                        label1.Text = "添加水印";
                        break;
                    case "画点" :
                        label1.Text = "画点"; 
                        graphics.FillEllipse(new SolidBrush(nowColor), new Rectangle(pointB, fontSize));
                        break;
                    case "橡皮":
                        graphics.FillEllipse(new SolidBrush(nowColor), new Rectangle(pointB, fontSize));
                        break;
                    case "划线":
                        label1.Text = "划线"; break;
                    case "矩形":
                        label1.Text = "矩形，\r\n上滑取消操作";break;
                    case "圆形":
                        label1.Text = "画圆"; break;
                }
            }
        }

        private void 画点_Click(object sender, EventArgs e)
        {
            function = "画点";
            label1.Text = "画点";
            Console.WriteLine(function);
        }

        private void 划线_Click(object sender, EventArgs e)
        {
            function = "划线";
            label1.Text = "画线";
        }

        private void 矩形_Click(object sender, EventArgs e)
        {
            function = "矩形";
            label1.Text = "矩形";
        }

        private void 圆形_Click(object sender, EventArgs e)
        {
            function = "圆形";
            label1.Text = "圆形";
        }

        private void 红色_Click(object sender, EventArgs e)
        {
            nowColor = Color.Red;
            pen = new Pen(nowColor);
        }

        private void 灰色_Click(object sender, EventArgs e)
        {
            nowColor = Color.Gray;
            pen = new Pen(nowColor);
        }

        private void 黄色_Click(object sender, EventArgs e)
        {
            nowColor = Color.Yellow;
            pen = new Pen(nowColor);
        }

        private void 绿色_Click(object sender, EventArgs e)
        {
            nowColor = Color.Lime;
            pen = new Pen(nowColor);
        }

        private void 青色_Click(object sender, EventArgs e)
        {
            nowColor = Color.Aqua;
            pen = new Pen(nowColor);
        }

        private void 黑色_Click(object sender, EventArgs e)
        {
            nowColor = Color.Black ;
            pen = new Pen(nowColor);
        }

        private void 颜色_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Console.WriteLine(colorDialog1.Color.ToString());
            nowColor = colorDialog1.Color;
            pen = new Pen(nowColor);
        }


        private void 橡皮_Click(object sender, EventArgs e)
        {
            nowColor = Color.White;
            fontSize = new Size(7, 7); 
            pen = new Pen(nowColor);
        }

        private void 细_Click(object sender, EventArgs e)
        {
            fontSize = new Size(2, 2);
        }

        private void 中_Click(object sender, EventArgs e)
        {
            fontSize = new Size(3, 3);
        }

        private void 粗_Click(object sender, EventArgs e)
        {
            fontSize = new Size(5, 5);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine(fileName);
            if (fileName == "")
            {
                DialogResult dialogResult = MessageBox.Show("还没有保存图像，是否保存？", "Notice", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    保存_Click(sender, e);
                }
            }
        }
    }
}
