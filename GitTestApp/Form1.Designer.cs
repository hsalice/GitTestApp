namespace GitTestApp
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
            this.tbxPart1 = new System.Windows.Forms.TextBox();
            this.tbxPart2 = new System.Windows.Forms.TextBox();
            this.tbxPart3 = new System.Windows.Forms.TextBox();
            this.lblPart1 = new System.Windows.Forms.Label();
            this.lblPart2 = new System.Windows.Forms.Label();
            this.lblPart3 = new System.Windows.Forms.Label();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPart1
            // 
            this.tbxPart1.Location = new System.Drawing.Point(411, 42);
            this.tbxPart1.Name = "tbxPart1";
            this.tbxPart1.Size = new System.Drawing.Size(150, 20);
            this.tbxPart1.TabIndex = 0;
            // 
            // tbxPart2
            // 
            this.tbxPart2.Location = new System.Drawing.Point(411, 85);
            this.tbxPart2.Name = "tbxPart2";
            this.tbxPart2.Size = new System.Drawing.Size(149, 20);
            this.tbxPart2.TabIndex = 1;
            // 
            // tbxPart3
            // 
            this.tbxPart3.Location = new System.Drawing.Point(411, 129);
            this.tbxPart3.Name = "tbxPart3";
            this.tbxPart3.Size = new System.Drawing.Size(149, 20);
            this.tbxPart3.TabIndex = 2;
            // 
            // lblPart1
            // 
            this.lblPart1.AutoSize = true;
            this.lblPart1.Location = new System.Drawing.Point(335, 45);
            this.lblPart1.Name = "lblPart1";
            this.lblPart1.Size = new System.Drawing.Size(52, 13);
            this.lblPart1.TabIndex = 3;
            this.lblPart1.Text = "Part One:";
            // 
            // lblPart2
            // 
            this.lblPart2.AutoSize = true;
            this.lblPart2.Location = new System.Drawing.Point(335, 88);
            this.lblPart2.Name = "lblPart2";
            this.lblPart2.Size = new System.Drawing.Size(53, 13);
            this.lblPart2.TabIndex = 4;
            this.lblPart2.Text = "Part Two:";
            // 
            // lblPart3
            // 
            this.lblPart3.AutoSize = true;
            this.lblPart3.Location = new System.Drawing.Point(335, 132);
            this.lblPart3.Name = "lblPart3";
            this.lblPart3.Size = new System.Drawing.Size(60, 13);
            this.lblPart3.TabIndex = 5;
            this.lblPart3.Text = "Part Three:";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(23, 30);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(275, 355);
            this.lbxList.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add to List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.lblPart3);
            this.Controls.Add(this.lblPart2);
            this.Controls.Add(this.lblPart1);
            this.Controls.Add(this.tbxPart3);
            this.Controls.Add(this.tbxPart2);
            this.Controls.Add(this.tbxPart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPart1;
        private System.Windows.Forms.TextBox tbxPart2;
        private System.Windows.Forms.TextBox tbxPart3;
        private System.Windows.Forms.Label lblPart1;
        private System.Windows.Forms.Label lblPart2;
        private System.Windows.Forms.Label lblPart3;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Button btnAdd;
    }
}

