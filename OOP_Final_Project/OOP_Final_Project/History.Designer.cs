namespace OOP_Final_Project
{
    partial class History
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
            buttonDelete = new Button();
            dataGridView1 = new DataGridView();
            Ok = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightCoral;
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(Ok);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(55, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(537, 343);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Crimson;
            buttonDelete.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(70, 250);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 65);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 83);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(491, 162);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Ok
            // 
            Ok.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ok.Location = new Point(321, 250);
            Ok.Name = "Ok";
            Ok.Size = new Size(136, 65);
            Ok.TabIndex = 1;
            Ok.Text = "Okay";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 10);
            label1.Name = "label1";
            label1.Size = new Size(236, 60);
            label1.TabIndex = 1;
            label1.Text = "History";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.Location = new Point(44, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 371);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "History";
            Text = "History";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button Ok;
        private DataGridView dataGridView1;
        private Button buttonDelete;
        private PictureBox pictureBox1;
    }
}