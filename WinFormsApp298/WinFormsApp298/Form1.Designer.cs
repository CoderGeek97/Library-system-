namespace WinFormsApp298
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            colorDialog1 = new ColorDialog();
            panel3 = new Panel();
            button4 = new Button();
            button3 = new Button();
            Btn_add = new Button();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.IndianRed;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(Btn_add);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 513);
            panel3.Name = "panel3";
            panel3.Size = new Size(993, 67);
            panel3.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(121, 14);
            button4.Name = "button4";
            button4.Size = new Size(138, 39);
            button4.TabIndex = 32;
            button4.Text = "Delete Book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(422, 14);
            button3.Name = "button3";
            button3.Size = new Size(138, 39);
            button3.TabIndex = 31;
            button3.Text = "Update Book";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Btn_add
            // 
            Btn_add.Anchor = AnchorStyles.None;
            Btn_add.Font = new Font("Acumin Pro", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_add.ForeColor = Color.Red;
            Btn_add.Location = new Point(733, 14);
            Btn_add.Name = "Btn_add";
            Btn_add.Size = new Size(138, 39);
            Btn_add.TabIndex = 30;
            Btn_add.Text = "Add Book";
            Btn_add.UseVisualStyleBackColor = true;
            Btn_add.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(994, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(0, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(994, 450);
            panel4.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 67);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Acumin Pro", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(374, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 35);
            label1.TabIndex = 1;
            label1.Text = "Library Mangment";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(993, 580);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel1;
        private Label label1;
        public Button Btn_add;
    }
}