namespace WindowsFormsApp1
{
    partial class Calc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Mclear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.Mrecall = new System.Windows.Forms.Button();
            this.itog = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.siax = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Msave = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.half = new System.Windows.Forms.Button();
            this.umn = new System.Windows.Forms.Button();
            this.SF = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(566, 73);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.Clear.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(10, 513);
            this.Clear.Margin = new System.Windows.Forms.Padding(10);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(125, 100);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.one.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(10, 393);
            this.one.Margin = new System.Windows.Forms.Padding(10);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(125, 100);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.Button_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.four.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(10, 273);
            this.four.Margin = new System.Windows.Forms.Padding(10);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(125, 100);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Button_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.seven.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(10, 153);
            this.seven.Margin = new System.Windows.Forms.Padding(10);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(125, 100);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Clear);
            this.flowLayoutPanel1.Controls.Add(this.one);
            this.flowLayoutPanel1.Controls.Add(this.four);
            this.flowLayoutPanel1.Controls.Add(this.seven);
            this.flowLayoutPanel1.Controls.Add(this.Mclear);
            this.flowLayoutPanel1.Controls.Add(this.zero);
            this.flowLayoutPanel1.Controls.Add(this.two);
            this.flowLayoutPanel1.Controls.Add(this.five);
            this.flowLayoutPanel1.Controls.Add(this.eight);
            this.flowLayoutPanel1.Controls.Add(this.Mrecall);
            this.flowLayoutPanel1.Controls.Add(this.itog);
            this.flowLayoutPanel1.Controls.Add(this.three);
            this.flowLayoutPanel1.Controls.Add(this.siax);
            this.flowLayoutPanel1.Controls.Add(this.nine);
            this.flowLayoutPanel1.Controls.Add(this.Msave);
            this.flowLayoutPanel1.Controls.Add(this.sum);
            this.flowLayoutPanel1.Controls.Add(this.minus);
            this.flowLayoutPanel1.Controls.Add(this.half);
            this.flowLayoutPanel1.Controls.Add(this.umn);
            this.flowLayoutPanel1.Controls.Add(this.SF);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 623);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Mclear
            // 
            this.Mclear.BackColor = System.Drawing.SystemColors.Highlight;
            this.Mclear.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mclear.Location = new System.Drawing.Point(10, 33);
            this.Mclear.Margin = new System.Windows.Forms.Padding(10);
            this.Mclear.Name = "Mclear";
            this.Mclear.Size = new System.Drawing.Size(125, 100);
            this.Mclear.TabIndex = 5;
            this.Mclear.Text = "MC";
            this.Mclear.UseVisualStyleBackColor = false;
            this.Mclear.Click += new System.EventHandler(this.Mclear_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(155, 513);
            this.zero.Margin = new System.Windows.Forms.Padding(10);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(125, 100);
            this.zero.TabIndex = 6;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Button_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.two.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(155, 393);
            this.two.Margin = new System.Windows.Forms.Padding(10);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(125, 100);
            this.two.TabIndex = 7;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Button_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.five.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(155, 273);
            this.five.Margin = new System.Windows.Forms.Padding(10);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(125, 100);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Button_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eight.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(155, 153);
            this.eight.Margin = new System.Windows.Forms.Padding(10);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(125, 100);
            this.eight.TabIndex = 9;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Button_Click);
            // 
            // Mrecall
            // 
            this.Mrecall.BackColor = System.Drawing.SystemColors.Highlight;
            this.Mrecall.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mrecall.Location = new System.Drawing.Point(155, 33);
            this.Mrecall.Margin = new System.Windows.Forms.Padding(10);
            this.Mrecall.Name = "Mrecall";
            this.Mrecall.Size = new System.Drawing.Size(125, 100);
            this.Mrecall.TabIndex = 10;
            this.Mrecall.Text = "MR";
            this.Mrecall.UseVisualStyleBackColor = false;
            this.Mrecall.Click += new System.EventHandler(this.Mrecall_Click);
            // 
            // itog
            // 
            this.itog.BackColor = System.Drawing.SystemColors.Info;
            this.itog.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itog.Location = new System.Drawing.Point(300, 513);
            this.itog.Margin = new System.Windows.Forms.Padding(10);
            this.itog.Name = "itog";
            this.itog.Size = new System.Drawing.Size(125, 100);
            this.itog.TabIndex = 11;
            this.itog.Text = "=";
            this.itog.UseVisualStyleBackColor = false;
            this.itog.Click += new System.EventHandler(this.itog_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.three.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(300, 393);
            this.three.Margin = new System.Windows.Forms.Padding(10);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(125, 100);
            this.three.TabIndex = 12;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Button_Click);
            // 
            // siax
            // 
            this.siax.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.siax.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siax.Location = new System.Drawing.Point(300, 273);
            this.siax.Margin = new System.Windows.Forms.Padding(10);
            this.siax.Name = "siax";
            this.siax.Size = new System.Drawing.Size(125, 100);
            this.siax.TabIndex = 13;
            this.siax.Text = "6";
            this.siax.UseVisualStyleBackColor = false;
            this.siax.Click += new System.EventHandler(this.Button_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nine.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(300, 153);
            this.nine.Margin = new System.Windows.Forms.Padding(10);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(125, 100);
            this.nine.TabIndex = 14;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Button_Click);
            // 
            // Msave
            // 
            this.Msave.BackColor = System.Drawing.SystemColors.Highlight;
            this.Msave.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Msave.Location = new System.Drawing.Point(300, 33);
            this.Msave.Margin = new System.Windows.Forms.Padding(10);
            this.Msave.Name = "Msave";
            this.Msave.Size = new System.Drawing.Size(125, 100);
            this.Msave.TabIndex = 15;
            this.Msave.Text = "MS";
            this.Msave.UseVisualStyleBackColor = false;
            this.Msave.Click += new System.EventHandler(this.Msave_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.Highlight;
            this.sum.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(445, 513);
            this.sum.Margin = new System.Windows.Forms.Padding(10);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(125, 100);
            this.sum.TabIndex = 16;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.Operator_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.Highlight;
            this.minus.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(445, 393);
            this.minus.Margin = new System.Windows.Forms.Padding(10);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(125, 100);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // half
            // 
            this.half.BackColor = System.Drawing.SystemColors.Highlight;
            this.half.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.half.Location = new System.Drawing.Point(445, 273);
            this.half.Margin = new System.Windows.Forms.Padding(10);
            this.half.Name = "half";
            this.half.Size = new System.Drawing.Size(125, 100);
            this.half.TabIndex = 18;
            this.half.Text = "/";
            this.half.UseVisualStyleBackColor = false;
            this.half.Click += new System.EventHandler(this.Operator_Click);
            // 
            // umn
            // 
            this.umn.BackColor = System.Drawing.SystemColors.Highlight;
            this.umn.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umn.Location = new System.Drawing.Point(445, 153);
            this.umn.Margin = new System.Windows.Forms.Padding(10);
            this.umn.Name = "umn";
            this.umn.Size = new System.Drawing.Size(125, 100);
            this.umn.TabIndex = 19;
            this.umn.Text = "*";
            this.umn.UseVisualStyleBackColor = false;
            this.umn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // SF
            // 
            this.SF.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SF.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SF.Location = new System.Drawing.Point(445, 33);
            this.SF.Margin = new System.Windows.Forms.Padding(10);
            this.SF.Name = "SF";
            this.SF.Size = new System.Drawing.Size(125, 100);
            this.SF.TabIndex = 20;
            this.SF.Text = "Поменять шрифт";
            this.SF.UseVisualStyleBackColor = false;
            this.SF.Click += new System.EventHandler(this.SF_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Mclear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button Mrecall;
        private System.Windows.Forms.Button itog;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button siax;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button Msave;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button half;
        private System.Windows.Forms.Button umn;
        private System.Windows.Forms.Button SF;
    }
}

