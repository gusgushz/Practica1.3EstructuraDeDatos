namespace Practica1._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(450, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(724, 324);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(79, 127);
            button1.Name = "button1";
            button1.Size = new Size(289, 29);
            button1.TabIndex = 2;
            button1.Text = "Agregar libro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(243, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(243, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 6;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 24);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 77);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 8;
            label3.Text = "Año de Publicación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 77);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 9;
            label4.Text = "ISBN";
            // 
            // button2
            // 
            button2.Location = new Point(79, 214);
            button2.Name = "button2";
            button2.Size = new Size(289, 29);
            button2.TabIndex = 10;
            button2.Text = "Preorden";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(79, 249);
            button3.Name = "button3";
            button3.Size = new Size(289, 29);
            button3.TabIndex = 11;
            button3.Text = "Inorden";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(79, 284);
            button4.Name = "button4";
            button4.Size = new Size(289, 29);
            button4.TabIndex = 12;
            button4.Text = "Postorden";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(79, 388);
            button5.Name = "button5";
            button5.Size = new Size(289, 29);
            button5.TabIndex = 13;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 334);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 14;
            label5.Text = "ISBN";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(79, 355);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 54);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 16;
            label6.Text = "Listado de libros";
            // 
            // button6
            // 
            button6.Location = new Point(79, 179);
            button6.Name = "button6";
            button6.Size = new Size(289, 29);
            button6.TabIndex = 17;
            button6.Text = "Por Anchura";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 450);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private Button button6;
    }
}