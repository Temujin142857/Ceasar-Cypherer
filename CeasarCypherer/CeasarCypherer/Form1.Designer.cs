namespace CeasarCypherer
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
            this.Input_Textbox = new System.Windows.Forms.TextBox();
            this.Key_Textbox = new System.Windows.Forms.TextBox();
            this.Encode = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Result_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input_Textbox
            // 
            this.Input_Textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Input_Textbox.Location = new System.Drawing.Point(26, 129);
            this.Input_Textbox.Name = "Input_Textbox";
            this.Input_Textbox.Size = new System.Drawing.Size(738, 27);
            this.Input_Textbox.TabIndex = 0;
            this.Input_Textbox.Text = "Put text here";
            this.Input_Textbox.TextChanged += new System.EventHandler(this.Input_Textbox_TextChanged);
            // 
            // Key_Textbox
            // 
            this.Key_Textbox.BackColor = System.Drawing.SystemColors.Window;
            this.Key_Textbox.Location = new System.Drawing.Point(26, 26);
            this.Key_Textbox.Name = "Key_Textbox";
            this.Key_Textbox.Size = new System.Drawing.Size(142, 27);
            this.Key_Textbox.TabIndex = 1;
            this.Key_Textbox.Text = "Put key here";
            this.Key_Textbox.TextChanged += new System.EventHandler(this.Key_Textbox_TextChanged);
            // 
            // Encode
            // 
            this.Encode.AutoSize = true;
            this.Encode.Checked = true;
            this.Encode.Location = new System.Drawing.Point(26, 59);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(79, 24);
            this.Encode.TabIndex = 3;
            this.Encode.TabStop = true;
            this.Encode.Text = "Encode";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.CheckedChanged += new System.EventHandler(this.Encode_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Decode";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Decode_CheckedChanged);
            // 
            // Result_Textbox
            // 
            this.Result_Textbox.Location = new System.Drawing.Point(26, 275);
            this.Result_Textbox.Name = "Result_Textbox";
            this.Result_Textbox.Size = new System.Drawing.Size(738, 27);
            this.Result_Textbox.TabIndex = 4;
            this.Result_Textbox.Text = "Result will be displayed here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result_Textbox);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Key_Textbox);
            this.Controls.Add(this.Input_Textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Input_Textbox;
        private TextBox Key_Textbox;
        private RadioButton Encode;
        private RadioButton radioButton1;
        private TextBox Result_Textbox;
    }
}