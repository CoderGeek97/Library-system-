namespace WinFormsApp298
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btn_ADD = new Button();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 439);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(270, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 439);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " Additional Info";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(3, 225);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(115, 29);
            numericUpDown1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Acumin Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(0, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(269, 28);
            dateTimePicker1.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(3, 359);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(269, 29);
            textBox7.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(0, 165);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 6;
            label6.Text = "Rate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(-6, 299);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 6;
            label7.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(0, 56);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 4;
            label5.Text = "Publish Date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 439);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Basic Info";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Acumin Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(225, 359);
            button2.Name = "button2";
            button2.Size = new Size(44, 30);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Acumin Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 360);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 30);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(0, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 29);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(0, 165);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 4;
            label3.Text = "Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(0, 299);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 29);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(0, 56);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(btn_ADD);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 88);
            panel3.TabIndex = 0;
            // 
            // btn_ADD
            // 
            btn_ADD.BackColor = Color.White;
            btn_ADD.ForeColor = Color.Red;
            btn_ADD.Location = new Point(169, 17);
            btn_ADD.Name = "btn_ADD";
            btn_ADD.Size = new Size(197, 59);
            btn_ADD.TabIndex = 0;
            btn_ADD.Text = "Add New Book";
            btn_ADD.UseVisualStyleBackColor = false;
            btn_ADD.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 527);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("Acumin Pro", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label3;
        private Label label2;
        private Button button2;
        public Button btn_ADD;
        public DateTimePicker dateTimePicker1;
        public TextBox textBox7;
        public TextBox textBox3;
        public TextBox textBox1;
        public NumericUpDown numericUpDown1;
        public ComboBox comboBox1;
    }
}