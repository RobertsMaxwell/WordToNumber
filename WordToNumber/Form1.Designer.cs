namespace WordToNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.convertLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.wordButton = new System.Windows.Forms.RadioButton();
            this.numberButton = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.lightMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertLabel
            // 
            this.convertLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convertLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertLabel.Location = new System.Drawing.Point(12, 46);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(360, 23);
            this.convertLabel.TabIndex = 0;
            this.convertLabel.Text = "Convert:";
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.input.Location = new System.Drawing.Point(12, 72);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(360, 20);
            this.input.TabIndex = 1;
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(139, 143);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(106, 23);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "To:";
            // 
            // wordButton
            // 
            this.wordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordButton.Location = new System.Drawing.Point(144, 169);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(86, 17);
            this.wordButton.TabIndex = 4;
            this.wordButton.TabStop = true;
            this.wordButton.Text = "Word";
            this.wordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wordButton.UseVisualStyleBackColor = true;
            // 
            // numberButton
            // 
            this.numberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberButton.Location = new System.Drawing.Point(144, 192);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(86, 17);
            this.numberButton.TabIndex = 5;
            this.numberButton.TabStop = true;
            this.numberButton.Text = "Number";
            this.numberButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numberButton.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(64)))), ((int)(((byte)(104)))));
            this.result.Location = new System.Drawing.Point(12, 395);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(360, 20);
            this.result.TabIndex = 7;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 369);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(360, 23);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result:";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(47)))));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(139, 253);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(106, 35);
            this.start.TabIndex = 8;
            this.start.Text = "Go";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkMode,
            this.lightMode});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // darkMode
            // 
            this.darkMode.AutoSize = false;
            this.darkMode.CheckOnClick = true;
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(180, 22);
            this.darkMode.Text = "Dark Mode";
            this.darkMode.Click += new System.EventHandler(this.darkMode_Click);
            // 
            // lightMode
            // 
            this.lightMode.AutoSize = false;
            this.lightMode.CheckOnClick = true;
            this.lightMode.Name = "lightMode";
            this.lightMode.Size = new System.Drawing.Size(180, 22);
            this.lightMode.Text = "Light Mode";
            this.lightMode.Click += new System.EventHandler(this.lightMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.start);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Word Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.RadioButton wordButton;
        private System.Windows.Forms.RadioButton numberButton;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkMode;
        private System.Windows.Forms.ToolStripMenuItem lightMode;
    }
}

