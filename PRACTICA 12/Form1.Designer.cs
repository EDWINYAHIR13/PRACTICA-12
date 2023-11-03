namespace PRACTICA_12
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 128);
            label1.Name = "label1";
            label1.Size = new Size(183, 35);
            label1.TabIndex = 0;
            label1.Text = "Calificación";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(417, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 42);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(280, 249);
            button1.Name = "button1";
            button1.Size = new Size(190, 53);
            button1.TabIndex = 2;
            button1.Text = "DECISIÓN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}