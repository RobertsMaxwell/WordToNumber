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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wordButton = new System.Windows.Forms.RadioButton();
            this.numberButton = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 72);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(360, 20);
            this.input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // wordButton
            // 
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
            this.result.Location = new System.Drawing.Point(12, 395);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(360, 20);
            this.result.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result:";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(139, 253);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(106, 35);
            this.start.TabIndex = 8;
            this.start.Text = "Go";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.start);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Word Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton wordButton;
        private System.Windows.Forms.RadioButton numberButton;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
    }
}

