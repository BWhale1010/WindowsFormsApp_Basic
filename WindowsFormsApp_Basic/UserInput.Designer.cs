namespace WindowsFormsApp_Basic
{
    partial class UserInput
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.radioButton_true = new System.Windows.Forms.RadioButton();
            this.radioButton_false = new System.Windows.Forms.RadioButton();
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(26, 27);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(359, 25);
            this.textBox_input.TabIndex = 0;
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("Gulim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_input.Location = new System.Drawing.Point(419, 27);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 25);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // radioButton_true
            // 
            this.radioButton_true.AutoSize = true;
            this.radioButton_true.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_true.Location = new System.Drawing.Point(26, 77);
            this.radioButton_true.Name = "radioButton_true";
            this.radioButton_true.Size = new System.Drawing.Size(60, 22);
            this.radioButton_true.TabIndex = 2;
            this.radioButton_true.TabStop = true;
            this.radioButton_true.Text = "true";
            this.radioButton_true.UseVisualStyleBackColor = true;
            this.radioButton_true.Click += new System.EventHandler(this.radioButton_true_Click);
            // 
            // radioButton_false
            // 
            this.radioButton_false.AutoSize = true;
            this.radioButton_false.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_false.Location = new System.Drawing.Point(134, 77);
            this.radioButton_false.Name = "radioButton_false";
            this.radioButton_false.Size = new System.Drawing.Size(67, 22);
            this.radioButton_false.TabIndex = 3;
            this.radioButton_false.TabStop = true;
            this.radioButton_false.Text = "false";
            this.radioButton_false.UseVisualStyleBackColor = true;
            this.radioButton_false.Click += new System.EventHandler(this.radioButton_false_Click);
            // 
            // textBox_print
            // 
            this.textBox_print.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_print.Location = new System.Drawing.Point(28, 128);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.ReadOnly = true;
            this.textBox_print.Size = new System.Drawing.Size(465, 302);
            this.textBox_print.TabIndex = 4;
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.textBox_print);
            this.Controls.Add(this.radioButton_false);
            this.Controls.Add(this.radioButton_true);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_input);
            this.Name = "UserInput";
            this.Text = "UserInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.RadioButton radioButton_true;
        private System.Windows.Forms.RadioButton radioButton_false;
        private System.Windows.Forms.TextBox textBox_print;
    }
}