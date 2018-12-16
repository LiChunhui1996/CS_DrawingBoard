namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.新建 = new System.Windows.Forms.Button();
            this.加载 = new System.Windows.Forms.Button();
            this.保存 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.写字 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.画点 = new System.Windows.Forms.Button();
            this.直线 = new System.Windows.Forms.Button();
            this.矩形 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.圆形 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.红色 = new System.Windows.Forms.Button();
            this.灰色 = new System.Windows.Forms.Button();
            this.黄色 = new System.Windows.Forms.Button();
            this.绿色 = new System.Windows.Forms.Button();
            this.青色 = new System.Windows.Forms.Button();
            this.黑色 = new System.Windows.Forms.Button();
            this.橡皮 = new System.Windows.Forms.Button();
            this.细 = new System.Windows.Forms.Button();
            this.中 = new System.Windows.Forms.Button();
            this.粗 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 新建
            // 
            this.新建.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.新建.Location = new System.Drawing.Point(620, 10);
            this.新建.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.新建.Name = "新建";
            this.新建.Size = new System.Drawing.Size(68, 24);
            this.新建.TabIndex = 0;
            this.新建.Text = "新建(&N)";
            this.新建.UseVisualStyleBackColor = true;
            this.新建.Click += new System.EventHandler(this.新建_Click);
            // 
            // 加载
            // 
            this.加载.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.加载.Location = new System.Drawing.Point(620, 34);
            this.加载.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.加载.Name = "加载";
            this.加载.Size = new System.Drawing.Size(68, 24);
            this.加载.TabIndex = 1;
            this.加载.Text = "加载(&F)";
            this.加载.UseVisualStyleBackColor = true;
            this.加载.Click += new System.EventHandler(this.加载_Click);
            // 
            // 保存
            // 
            this.保存.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.保存.Location = new System.Drawing.Point(620, 57);
            this.保存.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.保存.Name = "保存";
            this.保存.Size = new System.Drawing.Size(68, 24);
            this.保存.TabIndex = 3;
            this.保存.Text = "保存(&S)";
            this.保存.UseVisualStyleBackColor = true;
            this.保存.Click += new System.EventHandler(this.保存_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 写字
            // 
            this.写字.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.写字.Location = new System.Drawing.Point(620, 93);
            this.写字.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.写字.Name = "写字";
            this.写字.Size = new System.Drawing.Size(68, 24);
            this.写字.TabIndex = 4;
            this.写字.Text = "水印(&I)";
            this.写字.UseVisualStyleBackColor = true;
            this.写字.Click += new System.EventHandler(this.写字_Click);
            // 
            // 画点
            // 
            this.画点.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.画点.Location = new System.Drawing.Point(620, 116);
            this.画点.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.画点.Name = "画点";
            this.画点.Size = new System.Drawing.Size(68, 24);
            this.画点.TabIndex = 5;
            this.画点.Text = "画点(&P)";
            this.画点.UseVisualStyleBackColor = true;
            this.画点.Click += new System.EventHandler(this.画点_Click);
            // 
            // 直线
            // 
            this.直线.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.直线.Cursor = System.Windows.Forms.Cursors.Default;
            this.直线.Location = new System.Drawing.Point(620, 139);
            this.直线.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.直线.Name = "直线";
            this.直线.Size = new System.Drawing.Size(68, 24);
            this.直线.TabIndex = 6;
            this.直线.Text = "直线(&L)";
            this.直线.UseVisualStyleBackColor = true;
            this.直线.Click += new System.EventHandler(this.划线_Click);
            // 
            // 矩形
            // 
            this.矩形.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.矩形.Cursor = System.Windows.Forms.Cursors.Default;
            this.矩形.Location = new System.Drawing.Point(620, 162);
            this.矩形.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.矩形.Name = "矩形";
            this.矩形.Size = new System.Drawing.Size(68, 24);
            this.矩形.TabIndex = 7;
            this.矩形.Text = "矩形(&R)";
            this.矩形.UseVisualStyleBackColor = true;
            this.矩形.Click += new System.EventHandler(this.矩形_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 8;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 圆形
            // 
            this.圆形.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.圆形.Cursor = System.Windows.Forms.Cursors.Default;
            this.圆形.Location = new System.Drawing.Point(620, 186);
            this.圆形.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.圆形.Name = "圆形";
            this.圆形.Size = new System.Drawing.Size(68, 24);
            this.圆形.TabIndex = 9;
            this.圆形.Text = "圆形(&C)";
            this.圆形.UseVisualStyleBackColor = true;
            this.圆形.Click += new System.EventHandler(this.圆形_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(620, 283);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "更多(M)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.颜色_Click);
            // 
            // 红色
            // 
            this.红色.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.红色.BackColor = System.Drawing.Color.Red;
            this.红色.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.红色.FlatAppearance.BorderSize = 0;
            this.红色.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.红色.Location = new System.Drawing.Point(620, 234);
            this.红色.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.红色.Name = "红色";
            this.红色.Size = new System.Drawing.Size(19, 20);
            this.红色.TabIndex = 11;
            this.红色.UseVisualStyleBackColor = false;
            this.红色.Click += new System.EventHandler(this.红色_Click);
            // 
            // 灰色
            // 
            this.灰色.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.灰色.BackColor = System.Drawing.Color.Gray;
            this.灰色.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.灰色.FlatAppearance.BorderSize = 0;
            this.灰色.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.灰色.Location = new System.Drawing.Point(644, 258);
            this.灰色.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.灰色.Name = "灰色";
            this.灰色.Size = new System.Drawing.Size(19, 20);
            this.灰色.TabIndex = 12;
            this.灰色.UseVisualStyleBackColor = false;
            this.灰色.Click += new System.EventHandler(this.灰色_Click);
            // 
            // 黄色
            // 
            this.黄色.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.黄色.BackColor = System.Drawing.Color.Yellow;
            this.黄色.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.黄色.FlatAppearance.BorderSize = 0;
            this.黄色.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.黄色.Location = new System.Drawing.Point(667, 234);
            this.黄色.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.黄色.Name = "黄色";
            this.黄色.Size = new System.Drawing.Size(19, 20);
            this.黄色.TabIndex = 13;
            this.黄色.UseVisualStyleBackColor = false;
            this.黄色.Click += new System.EventHandler(this.黄色_Click);
            // 
            // 绿色
            // 
            this.绿色.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.绿色.BackColor = System.Drawing.Color.Lime;
            this.绿色.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.绿色.FlatAppearance.BorderSize = 0;
            this.绿色.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.绿色.Location = new System.Drawing.Point(644, 234);
            this.绿色.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.绿色.Name = "绿色";
            this.绿色.Size = new System.Drawing.Size(19, 20);
            this.绿色.TabIndex = 14;
            this.绿色.UseVisualStyleBackColor = false;
            this.绿色.Click += new System.EventHandler(this.绿色_Click);
            // 
            // 青色
            // 
            this.青色.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.青色.BackColor = System.Drawing.Color.Aqua;
            this.青色.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.青色.FlatAppearance.BorderSize = 0;
            this.青色.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.青色.Location = new System.Drawing.Point(620, 258);
            this.青色.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.青色.Name = "青色";
            this.青色.Size = new System.Drawing.Size(19, 20);
            this.青色.TabIndex = 15;
            this.青色.UseVisualStyleBackColor = false;
            this.青色.Click += new System.EventHandler(this.青色_Click);
            // 
            // 黑色
            // 
            this.黑色.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.黑色.BackColor = System.Drawing.Color.Black;
            this.黑色.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.黑色.FlatAppearance.BorderSize = 0;
            this.黑色.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.黑色.Location = new System.Drawing.Point(667, 258);
            this.黑色.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.黑色.Name = "黑色";
            this.黑色.Size = new System.Drawing.Size(19, 20);
            this.黑色.TabIndex = 16;
            this.黑色.UseVisualStyleBackColor = false;
            this.黑色.Click += new System.EventHandler(this.黑色_Click);
            // 
            // 橡皮
            // 
            this.橡皮.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.橡皮.Location = new System.Drawing.Point(620, 306);
            this.橡皮.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.橡皮.Name = "橡皮";
            this.橡皮.Size = new System.Drawing.Size(68, 24);
            this.橡皮.TabIndex = 17;
            this.橡皮.Text = "橡皮(&E)";
            this.橡皮.UseVisualStyleBackColor = true;
            this.橡皮.Click += new System.EventHandler(this.橡皮_Click);
            // 
            // 细
            // 
            this.细.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.细.BackColor = System.Drawing.Color.Black;
            this.细.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.细.FlatAppearance.BorderSize = 0;
            this.细.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.细.Location = new System.Drawing.Point(620, 344);
            this.细.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.细.Name = "细";
            this.细.Size = new System.Drawing.Size(68, 1);
            this.细.TabIndex = 18;
            this.细.UseVisualStyleBackColor = false;
            this.细.Click += new System.EventHandler(this.细_Click);
            // 
            // 中
            // 
            this.中.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.中.BackColor = System.Drawing.Color.Black;
            this.中.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.中.FlatAppearance.BorderSize = 0;
            this.中.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.中.Location = new System.Drawing.Point(620, 358);
            this.中.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.中.Name = "中";
            this.中.Size = new System.Drawing.Size(68, 2);
            this.中.TabIndex = 19;
            this.中.UseVisualStyleBackColor = false;
            this.中.Click += new System.EventHandler(this.中_Click);
            // 
            // 粗
            // 
            this.粗.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.粗.BackColor = System.Drawing.Color.Black;
            this.粗.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.粗.FlatAppearance.BorderSize = 0;
            this.粗.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.粗.Location = new System.Drawing.Point(620, 372);
            this.粗.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.粗.Name = "粗";
            this.粗.Size = new System.Drawing.Size(68, 4);
            this.粗.TabIndex = 20;
            this.粗.UseVisualStyleBackColor = false;
            this.粗.Click += new System.EventHandler(this.粗_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 480);
            this.Controls.Add(this.粗);
            this.Controls.Add(this.中);
            this.Controls.Add(this.细);
            this.Controls.Add(this.橡皮);
            this.Controls.Add(this.黑色);
            this.Controls.Add(this.青色);
            this.Controls.Add(this.绿色);
            this.Controls.Add(this.黄色);
            this.Controls.Add(this.灰色);
            this.Controls.Add(this.红色);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.圆形);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.矩形);
            this.Controls.Add(this.直线);
            this.Controls.Add(this.画点);
            this.Controls.Add(this.写字);
            this.Controls.Add(this.保存);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.加载);
            this.Controls.Add(this.新建);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "绘画板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button 加载;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button 新建;
        private System.Windows.Forms.Button 保存;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button 写字;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button 画点;
        private System.Windows.Forms.Button 直线;
        private System.Windows.Forms.Button 矩形;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 圆形;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button 红色;
        private System.Windows.Forms.Button 灰色;
        private System.Windows.Forms.Button 黄色;
        private System.Windows.Forms.Button 绿色;
        private System.Windows.Forms.Button 青色;
        private System.Windows.Forms.Button 黑色;
        private System.Windows.Forms.Button 橡皮;
        private System.Windows.Forms.Button 细;
        private System.Windows.Forms.Button 中;
        private System.Windows.Forms.Button 粗;
    }
}

