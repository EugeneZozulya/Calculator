namespace MyCulculator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.history = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Div = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Notch = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.OneDivX = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.history);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Div);
            this.panel1.Controls.Add(this.Equal);
            this.panel1.Controls.Add(this.Mul);
            this.panel1.Controls.Add(this.button_0);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.Point);
            this.panel1.Controls.Add(this.Notch);
            this.panel1.Controls.Add(this.Cos);
            this.panel1.Controls.Add(this.OneDivX);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Sub);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.BackSpace);
            this.panel1.Controls.Add(this.button_6);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.Sum);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 350);
            this.panel1.TabIndex = 1;
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Location = new System.Drawing.Point(5, 10);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(0, 13);
            this.history.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 34);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Div.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Div.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Div.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div.ForeColor = System.Drawing.Color.White;
            this.Div.Location = new System.Drawing.Point(194, 304);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(62, 44);
            this.Div.TabIndex = 25;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Equal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equal.ForeColor = System.Drawing.Color.White;
            this.Equal.Location = new System.Drawing.Point(130, 304);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(62, 44);
            this.Equal.TabIndex = 21;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Mul
            // 
            this.Mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Mul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Mul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Mul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mul.ForeColor = System.Drawing.Color.White;
            this.Mul.Location = new System.Drawing.Point(194, 258);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(62, 44);
            this.Mul.TabIndex = 24;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = false;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.White;
            this.button_0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_0.Location = new System.Drawing.Point(66, 304);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(62, 44);
            this.button_0.TabIndex = 20;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.White;
            this.button_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_9.Location = new System.Drawing.Point(130, 258);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(62, 44);
            this.button_9.TabIndex = 18;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.Color.White;
            this.Point.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Point.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Point.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Point.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Point.Location = new System.Drawing.Point(2, 304);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(62, 44);
            this.Point.TabIndex = 19;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Notch
            // 
            this.Notch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Notch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Notch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Notch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Notch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notch.ForeColor = System.Drawing.Color.White;
            this.Notch.Location = new System.Drawing.Point(3, 121);
            this.Notch.Name = "Notch";
            this.Notch.Size = new System.Drawing.Size(82, 44);
            this.Notch.TabIndex = 26;
            this.Notch.Text = "x^1/2";
            this.Notch.UseVisualStyleBackColor = false;
            this.Notch.Click += new System.EventHandler(this.Notch_Click);
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Cos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Cos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cos.ForeColor = System.Drawing.Color.White;
            this.Cos.Location = new System.Drawing.Point(174, 121);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(82, 44);
            this.Cos.TabIndex = 27;
            this.Cos.Text = "cos(x)";
            this.Cos.UseVisualStyleBackColor = false;
            this.Cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // OneDivX
            // 
            this.OneDivX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OneDivX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.OneDivX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.OneDivX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OneDivX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneDivX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneDivX.ForeColor = System.Drawing.Color.White;
            this.OneDivX.Location = new System.Drawing.Point(89, 121);
            this.OneDivX.Name = "OneDivX";
            this.OneDivX.Size = new System.Drawing.Size(82, 44);
            this.OneDivX.TabIndex = 28;
            this.OneDivX.Text = "1/x";
            this.OneDivX.UseVisualStyleBackColor = false;
            this.OneDivX.Click += new System.EventHandler(this.OneDivX_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(3, 75);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(125, 44);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Sub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Sub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sub.ForeColor = System.Drawing.Color.White;
            this.Sub.Location = new System.Drawing.Point(194, 212);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(62, 44);
            this.Sub.TabIndex = 23;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.White;
            this.button_8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_8.Location = new System.Drawing.Point(66, 258);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(62, 44);
            this.button_8.TabIndex = 17;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.White;
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_7.Location = new System.Drawing.Point(2, 258);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(62, 44);
            this.button_7.TabIndex = 16;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackSpace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BackSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BackSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackSpace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackSpace.ForeColor = System.Drawing.Color.White;
            this.BackSpace.Location = new System.Drawing.Point(131, 75);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(125, 44);
            this.BackSpace.TabIndex = 30;
            this.BackSpace.Text = "BackSpace";
            this.BackSpace.UseVisualStyleBackColor = false;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.White;
            this.button_6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_6.Location = new System.Drawing.Point(130, 212);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(62, 44);
            this.button_6.TabIndex = 15;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.White;
            this.button_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.Location = new System.Drawing.Point(66, 212);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(62, 44);
            this.button_5.TabIndex = 14;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Sum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Sum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.ForeColor = System.Drawing.Color.White;
            this.Sum.Location = new System.Drawing.Point(194, 167);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(62, 44);
            this.Sum.TabIndex = 22;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.White;
            this.button_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_1.Location = new System.Drawing.Point(2, 167);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(62, 44);
            this.button_1.TabIndex = 1;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.White;
            this.button_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4.Location = new System.Drawing.Point(2, 212);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(62, 44);
            this.button_4.TabIndex = 13;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.White;
            this.button_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_2.Location = new System.Drawing.Point(66, 167);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(62, 44);
            this.button_2.TabIndex = 11;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.White;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3.Location = new System.Drawing.Point(130, 167);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(62, 44);
            this.button_3.TabIndex = 12;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(258, 350);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(274, 389);
            this.MinimumSize = new System.Drawing.Size(274, 389);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button OneDivX;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Notch;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label history;
    }
}

