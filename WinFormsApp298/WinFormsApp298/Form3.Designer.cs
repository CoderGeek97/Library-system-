namespace WinFormsApp298
{
    partial class Form3
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
            TXT_TYPE = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // TXT_TYPE
            // 
            TXT_TYPE.Font = new Font("Acumin Pro", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            TXT_TYPE.Location = new Point(27, 113);
            TXT_TYPE.Name = "TXT_TYPE";
            TXT_TYPE.Size = new Size(310, 35);
            TXT_TYPE.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Acumin Pro", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(93, 22);
            label1.Name = "label1";
            label1.Size = new Size(185, 44);
            label1.TabIndex = 2;
            label1.Text = "Book Type";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Acumin Pro", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(93, 257);
            button1.Name = "button1";
            button1.Size = new Size(175, 42);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(375, 331);
            Controls.Add(button1);
            Controls.Add(TXT_TYPE);
            Controls.Add(label1);
            Font = new Font("Acumin Pro", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_TYPE;
        private Label label1;
        private Button button1;
    }
}