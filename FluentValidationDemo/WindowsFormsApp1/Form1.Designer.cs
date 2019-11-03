namespace WindowsFormsApp1
{
    partial class Form1
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
            this.fisrtNameInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.accountBalanceinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateOfBirthInput = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.errorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fisrtNameInput
            // 
            this.fisrtNameInput.Location = new System.Drawing.Point(171, 100);
            this.fisrtNameInput.Name = "fisrtNameInput";
            this.fisrtNameInput.Size = new System.Drawing.Size(135, 21);
            this.fisrtNameInput.TabIndex = 0;
            this.fisrtNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(171, 139);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(135, 21);
            this.lastNameInput.TabIndex = 1;
            // 
            // accountBalanceinput
            // 
            this.accountBalanceinput.Location = new System.Drawing.Point(171, 179);
            this.accountBalanceinput.Name = "accountBalanceinput";
            this.accountBalanceinput.Size = new System.Drawing.Size(135, 21);
            this.accountBalanceinput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "FirstName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "AccountBalance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "DateOfBirth";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateOfBirthInput
            // 
            this.dateOfBirthInput.Location = new System.Drawing.Point(171, 222);
            this.dateOfBirthInput.Name = "dateOfBirthInput";
            this.dateOfBirthInput.Size = new System.Drawing.Size(135, 21);
            this.dateOfBirthInput.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Errors";
            // 
            // errorListBox
            // 
            this.errorListBox.FormattingEnabled = true;
            this.errorListBox.ItemHeight = 12;
            this.errorListBox.Location = new System.Drawing.Point(365, 112);
            this.errorListBox.Name = "errorListBox";
            this.errorListBox.Size = new System.Drawing.Size(358, 124);
            this.errorListBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirthInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountBalanceinput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.fisrtNameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fisrtNameInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox accountBalanceinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateOfBirthInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox errorListBox;
    }
}

