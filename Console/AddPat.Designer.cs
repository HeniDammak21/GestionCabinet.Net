
namespace Console
{
    partial class AddPat
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
            System.Windows.Forms.Label nomPatLabel;
            System.Windows.Forms.Label prenomPatLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label adrPatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPat));
            this.label1 = new System.Windows.Forms.Label();
            this.nomPatTextBox = new System.Windows.Forms.TextBox();
            this.prenomPatTextBox = new System.Windows.Forms.TextBox();
            this.sexeTextBox = new System.Windows.Forms.TextBox();
            this.adrPatTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            nomPatLabel = new System.Windows.Forms.Label();
            prenomPatLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            adrPatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(172, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 46);
            this.label1.TabIndex = 38;
            this.label1.Text = "Add Patient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomPatLabel
            // 
            nomPatLabel.AutoSize = true;
            nomPatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomPatLabel.Location = new System.Drawing.Point(94, 243);
            nomPatLabel.Name = "nomPatLabel";
            nomPatLabel.Size = new System.Drawing.Size(128, 29);
            nomPatLabel.TabIndex = 30;
            nomPatLabel.Text = "Last Name";
            nomPatLabel.Click += new System.EventHandler(this.nomPatLabel_Click);
            // 
            // nomPatTextBox
            // 
            this.nomPatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomPatTextBox.Location = new System.Drawing.Point(231, 240);
            this.nomPatTextBox.Name = "nomPatTextBox";
            this.nomPatTextBox.Size = new System.Drawing.Size(248, 34);
            this.nomPatTextBox.TabIndex = 31;
            this.nomPatTextBox.TextChanged += new System.EventHandler(this.nomPatTextBox_TextChanged);
            // 
            // prenomPatLabel
            // 
            prenomPatLabel.AutoSize = true;
            prenomPatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomPatLabel.Location = new System.Drawing.Point(94, 163);
            prenomPatLabel.Name = "prenomPatLabel";
            prenomPatLabel.Size = new System.Drawing.Size(131, 29);
            prenomPatLabel.TabIndex = 32;
            prenomPatLabel.Text = "First Name";
            prenomPatLabel.Click += new System.EventHandler(this.prenomPatLabel_Click);
            // 
            // prenomPatTextBox
            // 
            this.prenomPatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomPatTextBox.Location = new System.Drawing.Point(231, 160);
            this.prenomPatTextBox.Name = "prenomPatTextBox";
            this.prenomPatTextBox.Size = new System.Drawing.Size(248, 34);
            this.prenomPatTextBox.TabIndex = 33;
            this.prenomPatTextBox.TextChanged += new System.EventHandler(this.prenomPatTextBox_TextChanged);
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexeLabel.Location = new System.Drawing.Point(94, 322);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(64, 29);
            sexeLabel.TabIndex = 34;
            sexeLabel.Text = "sexe";
            sexeLabel.Click += new System.EventHandler(this.sexeLabel_Click);
            // 
            // sexeTextBox
            // 
            this.sexeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexeTextBox.Location = new System.Drawing.Point(231, 322);
            this.sexeTextBox.Name = "sexeTextBox";
            this.sexeTextBox.Size = new System.Drawing.Size(248, 34);
            this.sexeTextBox.TabIndex = 35;
            this.sexeTextBox.TextChanged += new System.EventHandler(this.sexeTextBox_TextChanged);
            // 
            // adrPatLabel
            // 
            adrPatLabel.AutoSize = true;
            adrPatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adrPatLabel.Location = new System.Drawing.Point(96, 401);
            adrPatLabel.Name = "adrPatLabel";
            adrPatLabel.Size = new System.Drawing.Size(102, 29);
            adrPatLabel.TabIndex = 36;
            adrPatLabel.Text = "Address";
            adrPatLabel.Click += new System.EventHandler(this.adrPatLabel_Click);
            // 
            // adrPatTextBox
            // 
            this.adrPatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adrPatTextBox.Location = new System.Drawing.Point(231, 401);
            this.adrPatTextBox.Name = "adrPatTextBox";
            this.adrPatTextBox.Size = new System.Drawing.Size(248, 34);
            this.adrPatTextBox.TabIndex = 37;
            this.adrPatTextBox.TextChanged += new System.EventHandler(this.adrPatTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(442, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(33, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Back";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(28, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 33);
            this.button2.TabIndex = 53;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(219)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(605, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomPatLabel);
            this.Controls.Add(this.nomPatTextBox);
            this.Controls.Add(prenomPatLabel);
            this.Controls.Add(this.prenomPatTextBox);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(this.sexeTextBox);
            this.Controls.Add(adrPatLabel);
            this.Controls.Add(this.adrPatTextBox);
            this.Name = "AddPat";
            this.Text = "p";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomPatTextBox;
        private System.Windows.Forms.TextBox prenomPatTextBox;
        private System.Windows.Forms.TextBox sexeTextBox;
        private System.Windows.Forms.TextBox adrPatTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}