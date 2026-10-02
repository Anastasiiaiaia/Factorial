namespace Factorial19._09
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
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            resolveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 0;
            label1.Text = "Enter number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 116);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 1;
            label2.Text = "Result";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(24, 67);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(318, 34);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 225);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(318, 39);
            progressBar1.TabIndex = 4;
            // 
            // resolveButton
            // 
            resolveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resolveButton.Location = new Point(108, 299);
            resolveButton.Name = "resolveButton";
            resolveButton.Size = new Size(122, 41);
            resolveButton.TabIndex = 5;
            resolveButton.Text = "Resolve";
            resolveButton.UseVisualStyleBackColor = true;
            resolveButton.Click += resolveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 375);
            Controls.Add(resolveButton);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Button resolveButton;
    }
}
