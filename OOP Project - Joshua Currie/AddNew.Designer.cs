namespace OOP_Project___Joshua_Currie
{
    partial class AddNew
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
            this.Scoreslbl = new System.Windows.Forms.Label();
            this.Scoretxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddScoreBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNametxt = new System.Windows.Forms.TextBox();
            this.ClearScoresBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scoreslbl
            // 
            this.Scoreslbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Scoreslbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreslbl.Location = new System.Drawing.Point(70, 87);
            this.Scoreslbl.Name = "Scoreslbl";
            this.Scoreslbl.Size = new System.Drawing.Size(196, 22);
            this.Scoreslbl.TabIndex = 13;
            this.Scoreslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Scoretxt
            // 
            this.Scoretxt.Font = new System.Drawing.Font("Calibri", 9F);
            this.Scoretxt.Location = new System.Drawing.Point(70, 58);
            this.Scoretxt.Name = "Scoretxt";
            this.Scoretxt.Size = new System.Drawing.Size(115, 22);
            this.Scoretxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scores :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Score :";
            // 
            // AddScoreBtn
            // 
            this.AddScoreBtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.AddScoreBtn.Location = new System.Drawing.Point(191, 57);
            this.AddScoreBtn.Name = "AddScoreBtn";
            this.AddScoreBtn.Size = new System.Drawing.Size(75, 23);
            this.AddScoreBtn.TabIndex = 2;
            this.AddScoreBtn.Text = "Add Score";
            this.AddScoreBtn.UseVisualStyleBackColor = true;
            this.AddScoreBtn.Click += new System.EventHandler(this.AddScoreBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // AddNametxt
            // 
            this.AddNametxt.Font = new System.Drawing.Font("Calibri", 9F);
            this.AddNametxt.Location = new System.Drawing.Point(70, 25);
            this.AddNametxt.Name = "AddNametxt";
            this.AddNametxt.Size = new System.Drawing.Size(196, 22);
            this.AddNametxt.TabIndex = 0;
            // 
            // ClearScoresBtn
            // 
            this.ClearScoresBtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.ClearScoresBtn.Location = new System.Drawing.Point(181, 123);
            this.ClearScoresBtn.Name = "ClearScoresBtn";
            this.ClearScoresBtn.Size = new System.Drawing.Size(85, 28);
            this.ClearScoresBtn.TabIndex = 4;
            this.ClearScoresBtn.Text = "Clear Scores";
            this.ClearScoresBtn.UseVisualStyleBackColor = true;
            this.ClearScoresBtn.Click += new System.EventHandler(this.ClearScoresBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.CancelBtn.Location = new System.Drawing.Point(181, 157);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(85, 28);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OKbtn
            // 
            this.OKbtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.OKbtn.Location = new System.Drawing.Point(90, 157);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(85, 28);
            this.OKbtn.TabIndex = 3;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 198);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ClearScoresBtn);
            this.Controls.Add(this.Scoreslbl);
            this.Controls.Add(this.Scoretxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddScoreBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNametxt);
            this.Name = "AddNew";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Scoreslbl;
        private System.Windows.Forms.TextBox Scoretxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddScoreBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddNametxt;
        private System.Windows.Forms.Button ClearScoresBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKbtn;
    }
}