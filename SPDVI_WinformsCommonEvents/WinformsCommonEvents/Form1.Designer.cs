namespace WinformsCommonEvents
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DoubleClickLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBoxSelectedIndex = new System.Windows.Forms.ListBox();
            this.textBoxFocus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.messagesTextBox.ForeColor = System.Drawing.Color.White;
            this.messagesTextBox.Location = new System.Drawing.Point(303, 32);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesTextBox.Size = new System.Drawing.Size(586, 408);
            this.messagesTextBox.TabIndex = 0;
            this.messagesTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DoubleClickLabel
            // 
            this.DoubleClickLabel.AutoSize = true;
            this.DoubleClickLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoubleClickLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DoubleClickLabel.Location = new System.Drawing.Point(26, 32);
            this.DoubleClickLabel.Name = "DoubleClickLabel";
            this.DoubleClickLabel.Size = new System.Drawing.Size(124, 22);
            this.DoubleClickLabel.TabIndex = 1;
            this.DoubleClickLabel.Text = "Double Click Me!";
            this.DoubleClickLabel.DoubleClick += new System.EventHandler(this.DoubleClickLabel_DoubleClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 89);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(123, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // listBoxSelectedIndex
            // 
            this.listBoxSelectedIndex.FormattingEnabled = true;
            this.listBoxSelectedIndex.ItemHeight = 20;
            this.listBoxSelectedIndex.Items.AddRange(new object[] {
            "First line",
            "Second line",
            "Third line"});
            this.listBoxSelectedIndex.Location = new System.Drawing.Point(26, 172);
            this.listBoxSelectedIndex.Name = "listBoxSelectedIndex";
            this.listBoxSelectedIndex.Size = new System.Drawing.Size(124, 64);
            this.listBoxSelectedIndex.TabIndex = 3;
            this.listBoxSelectedIndex.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxFocus
            // 
            this.textBoxFocus.BackColor = System.Drawing.Color.White;
            this.textBoxFocus.Location = new System.Drawing.Point(26, 292);
            this.textBoxFocus.Multiline = true;
            this.textBoxFocus.Name = "textBoxFocus";
            this.textBoxFocus.Size = new System.Drawing.Size(201, 33);
            this.textBoxFocus.TabIndex = 4;
            this.textBoxFocus.Enter += new System.EventHandler(this.textBoxFocus_Enter);
            this.textBoxFocus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFocus_KeyPress);
            this.textBoxFocus.Leave += new System.EventHandler(this.textBoxFocus_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 169);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxFocus);
            this.Controls.Add(this.listBoxSelectedIndex);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.DoubleClickLabel);
            this.Controls.Add(this.messagesTextBox);
            this.Name = "mainForm";
            this.Text = "Windows Forms Components - Common Events";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label DoubleClickLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBoxSelectedIndex;
        private System.Windows.Forms.TextBox textBoxFocus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

