
namespace Hospital_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.checkBoxSP = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelReg = new System.Windows.Forms.Label();
            this.textBoxUN = new System.Windows.Forms.TextBox();
            this.comboBoxRoll = new System.Windows.Forms.ComboBox();
            this.labelUN = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSP
            // 
            this.checkBoxSP.AutoSize = true;
            this.checkBoxSP.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSP.Location = new System.Drawing.Point(405, 354);
            this.checkBoxSP.Name = "checkBoxSP";
            this.checkBoxSP.Size = new System.Drawing.Size(138, 21);
            this.checkBoxSP.TabIndex = 20;
            this.checkBoxSP.Text = "Show Password";
            this.checkBoxSP.UseVisualStyleBackColor = true;
            this.checkBoxSP.CheckedChanged += new System.EventHandler(this.checkBoxSP_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(34, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Blue;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(220, 434);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 48);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg.ForeColor = System.Drawing.Color.Black;
            this.labelReg.Location = new System.Drawing.Point(154, 25);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(249, 40);
            this.labelReg.TabIndex = 3;
            this.labelReg.Text = "Register Page";
            // 
            // textBoxUN
            // 
            this.textBoxUN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUN.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUN.ForeColor = System.Drawing.Color.Black;
            this.textBoxUN.Location = new System.Drawing.Point(220, 145);
            this.textBoxUN.Name = "textBoxUN";
            this.textBoxUN.Size = new System.Drawing.Size(300, 40);
            this.textBoxUN.TabIndex = 7;
            // 
            // comboBoxRoll
            // 
            this.comboBoxRoll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxRoll.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoll.ForeColor = System.Drawing.Color.Black;
            this.comboBoxRoll.FormattingEnabled = true;
            this.comboBoxRoll.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Patient",
            "Pharmacist"});
            this.comboBoxRoll.Location = new System.Drawing.Point(220, 270);
            this.comboBoxRoll.Name = "comboBoxRoll";
            this.comboBoxRoll.Size = new System.Drawing.Size(300, 40);
            this.comboBoxRoll.TabIndex = 14;
            this.comboBoxRoll.Text = "None";
            this.comboBoxRoll.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoll_SelectedIndexChanged);
            // 
            // labelUN
            // 
            this.labelUN.AutoSize = true;
            this.labelUN.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUN.ForeColor = System.Drawing.Color.Black;
            this.labelUN.Location = new System.Drawing.Point(26, 153);
            this.labelUN.Name = "labelUN";
            this.labelUN.Size = new System.Drawing.Size(171, 32);
            this.labelUN.TabIndex = 0;
            this.labelUN.Text = "UserName:";
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReg.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReg.ForeColor = System.Drawing.Color.Black;
            this.buttonReg.Location = new System.Drawing.Point(401, 434);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(119, 48);
            this.buttonReg.TabIndex = 5;
            this.buttonReg.Text = "Register";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPass.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.Location = new System.Drawing.Point(220, 208);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(300, 40);
            this.textBoxPass.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Role:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.Black;
            this.labelPass.Location = new System.Drawing.Point(26, 216);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(159, 32);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkBoxSP);
            this.panel2.Controls.Add(this.labelReg);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelPass);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxPass);
            this.panel2.Controls.Add(this.textBoxUN);
            this.panel2.Controls.Add(this.buttonReg);
            this.panel2.Controls.Add(this.comboBoxRoll);
            this.panel2.Controls.Add(this.labelUN);
            this.panel2.Location = new System.Drawing.Point(321, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 534);
            this.panel2.TabIndex = 19;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 603);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.TextBox textBoxUN;
        private System.Windows.Forms.ComboBox comboBoxRoll;
        private System.Windows.Forms.Label labelUN;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxSP;
        private System.Windows.Forms.Panel panel2;
    }
}