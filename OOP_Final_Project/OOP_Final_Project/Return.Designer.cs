namespace OOP_Final_Project
{
    partial class Return
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
            buttonReturn = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            TextBoxQuantity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBoxUsername = new TextBox();
            button1 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(buttonReturn);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TextBoxQuantity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(81, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 282);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // buttonReturn
            // 
            buttonReturn.Location = new Point(297, 219);
            buttonReturn.Margin = new Padding(2);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(116, 44);
            buttonReturn.TabIndex = 19;
            buttonReturn.Text = "return";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 118);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(164, 8);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 15;
            label5.Text = "Return";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 94);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 13;
            label3.Text = "Quantity:";
            // 
            // TextBoxQuantity
            // 
            TextBoxQuantity.Location = new Point(116, 94);
            TextBoxQuantity.Name = "TextBoxQuantity";
            TextBoxQuantity.Size = new Size(211, 23);
            TextBoxQuantity.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 69);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 11;
            label2.Text = "Item:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Basket ball", "Soccer ball", "Volley ball", "Base ball", "Tennis ball" });
            comboBox1.Location = new Point(116, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(116, 44);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(211, 23);
            textBoxUsername.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(164, 219);
            button1.Name = "button1";
            button1.Size = new Size(116, 44);
            button1.TabIndex = 7;
            button1.Text = "Okay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(38, 220);
            button6.Name = "button6";
            button6.Size = new Size(116, 44);
            button6.TabIndex = 6;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Return
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 389);
            Controls.Add(groupBox1);
            Name = "Return";
            Text = "Return";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label3;
        private TextBox TextBoxQuantity;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBoxUsername;
        private Button button1;
        private Button button6;
        private Button buttonReturn;
        private DateTimePicker dateTimePicker1;
    }
}