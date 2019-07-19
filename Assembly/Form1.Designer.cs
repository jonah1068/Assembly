namespace WindowsFormsApp1
{
    partial class Assembly
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.memoryNameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.memoryList = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outBox = new System.Windows.Forms.TextBox();
            this.program = new System.Windows.Forms.ListBox();
            this.lineBox = new System.Windows.Forms.TextBox();
            this.insertLineButton = new System.Windows.Forms.Button();
            this.removeLineButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.inClearButton = new System.Windows.Forms.Button();
            this.outClearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Memory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(315, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // memoryNameBox
            // 
            this.memoryNameBox.Location = new System.Drawing.Point(359, 56);
            this.memoryNameBox.Name = "memoryNameBox";
            this.memoryNameBox.Size = new System.Drawing.Size(143, 20);
            this.memoryNameBox.TabIndex = 2;
            this.memoryNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memoryNameBox_KeyDown);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(508, 54);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(35, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // memoryList
            // 
            this.memoryList.FormattingEnabled = true;
            this.memoryList.Items.AddRange(new object[] {
            "ACC"});
            this.memoryList.Location = new System.Drawing.Point(319, 82);
            this.memoryList.Name = "memoryList";
            this.memoryList.Size = new System.Drawing.Size(263, 108);
            this.memoryList.TabIndex = 5;
            this.memoryList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.memoryList_KeyDown);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(546, 54);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(35, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input";
            // 
            // inBox
            // 
            this.inBox.Location = new System.Drawing.Point(319, 220);
            this.inBox.Multiline = true;
            this.inBox.Name = "inBox";
            this.inBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inBox.Size = new System.Drawing.Size(263, 105);
            this.inBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output";
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(319, 353);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outBox.Size = new System.Drawing.Size(263, 97);
            this.outBox.TabIndex = 7;
            // 
            // program
            // 
            this.program.FormattingEnabled = true;
            this.program.Location = new System.Drawing.Point(12, 82);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(301, 368);
            this.program.TabIndex = 11;
            this.program.KeyDown += new System.Windows.Forms.KeyEventHandler(this.program_KeyDown);
            // 
            // lineBox
            // 
            this.lineBox.Location = new System.Drawing.Point(12, 28);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(301, 20);
            this.lineBox.TabIndex = 1;
            this.lineBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lineBox_KeyDown);
            // 
            // insertLineButton
            // 
            this.insertLineButton.Location = new System.Drawing.Point(12, 54);
            this.insertLineButton.Name = "insertLineButton";
            this.insertLineButton.Size = new System.Drawing.Size(65, 23);
            this.insertLineButton.TabIndex = 13;
            this.insertLineButton.Text = "Insert";
            this.insertLineButton.UseVisualStyleBackColor = true;
            this.insertLineButton.Click += new System.EventHandler(this.insertLineButton_Click);
            // 
            // removeLineButton
            // 
            this.removeLineButton.Location = new System.Drawing.Point(89, 54);
            this.removeLineButton.Name = "removeLineButton";
            this.removeLineButton.Size = new System.Drawing.Size(65, 23);
            this.removeLineButton.TabIndex = 14;
            this.removeLineButton.Text = "Remove";
            this.removeLineButton.UseVisualStyleBackColor = true;
            this.removeLineButton.Click += new System.EventHandler(this.removeLineButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(166, 54);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(65, 23);
            this.upButton.TabIndex = 15;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(243, 54);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(65, 23);
            this.downButton.TabIndex = 16;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // inClearButton
            // 
            this.inClearButton.Location = new System.Drawing.Point(508, 194);
            this.inClearButton.Name = "inClearButton";
            this.inClearButton.Size = new System.Drawing.Size(75, 23);
            this.inClearButton.TabIndex = 17;
            this.inClearButton.Text = "Clear Input";
            this.inClearButton.UseVisualStyleBackColor = true;
            this.inClearButton.Click += new System.EventHandler(this.inClearButton_Click);
            // 
            // outClearButton
            // 
            this.outClearButton.Location = new System.Drawing.Point(507, 327);
            this.outClearButton.Name = "outClearButton";
            this.outClearButton.Size = new System.Drawing.Size(75, 23);
            this.outClearButton.TabIndex = 18;
            this.outClearButton.Text = "Clear Output";
            this.outClearButton.UseVisualStyleBackColor = true;
            this.outClearButton.Click += new System.EventHandler(this.outClearButton_Click);
            // 
            // Assembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 462);
            this.Controls.Add(this.outClearButton);
            this.Controls.Add(this.inClearButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.removeLineButton);
            this.Controls.Add(this.insertLineButton);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.program);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.memoryList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.memoryNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Assembly";
            this.Text = "Assembly";
            this.Load += new System.EventHandler(this.Assembly_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memoryNameBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox memoryList;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.ListBox program;
        private System.Windows.Forms.TextBox lineBox;
        private System.Windows.Forms.Button insertLineButton;
        private System.Windows.Forms.Button removeLineButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.Button inClearButton;
        private System.Windows.Forms.Button outClearButton;
    }
}

