namespace OOP_Final_Project
{
    partial class Selection
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
            groupBox1 = new GroupBox();
            Logout = new Button();
            History = new Button();
            Return = new Button();
            Borrow = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCoral;
            groupBox1.Controls.Add(Logout);
            groupBox1.Controls.Add(History);
            groupBox1.Controls.Add(Return);
            groupBox1.Controls.Add(Borrow);
            groupBox1.Location = new Point(85, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Crimson;
            Logout.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.Location = new Point(42, 274);
            Logout.Name = "Logout";
            Logout.Size = new Size(181, 66);
            Logout.TabIndex = 3;
            Logout.Text = "Log-out";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // History
            // 
            History.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            History.Location = new Point(42, 202);
            History.Name = "History";
            History.Size = new Size(181, 66);
            History.TabIndex = 2;
            History.Text = "History";
            History.UseVisualStyleBackColor = true;
            History.Click += History_Click;
            // 
            // Return
            // 
            Return.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Return.Location = new Point(42, 130);
            Return.Name = "Return";
            Return.Size = new Size(181, 66);
            Return.TabIndex = 1;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            Return.Click += button2_Click_1;
            // 
            // Borrow
            // 
            Borrow.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Borrow.Location = new Point(42, 58);
            Borrow.Name = "Borrow";
            Borrow.Size = new Size(181, 66);
            Borrow.TabIndex = 0;
            Borrow.Text = "Borrow";
            Borrow.UseVisualStyleBackColor = true;
            Borrow.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.Location = new Point(75, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 418);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Selection";
            Text = "Selection";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button History;
        private Button Return;
        private Button Borrow;
        private Button Logout;
        private PictureBox pictureBox1;
    }
}