namespace OOP_Project___Joshua_Currie
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
            this.label1 = new System.Windows.Forms.Label();
            this.StudentLB = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoreTotallbl = new System.Windows.Forms.Label();
            this.ScoreCountlbl = new System.Windows.Forms.Label();
            this.Averagelbl = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Students";
            // 
            // StudentLB
            // 
            this.StudentLB.FormattingEnabled = true;
            this.StudentLB.Location = new System.Drawing.Point(12, 36);
            this.StudentLB.Name = "StudentLB";
            this.StudentLB.Size = new System.Drawing.Size(229, 108);
            this.StudentLB.TabIndex = 5;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(264, 45);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add New";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.DelBtn.Location = new System.Drawing.Point(264, 103);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Calibri", 9F);
            this.UpdateBtn.Location = new System.Drawing.Point(264, 74);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Score Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Score Count :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average :";
            // 
            // ScoreTotallbl
            // 
            this.ScoreTotallbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreTotallbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTotallbl.Location = new System.Drawing.Point(167, 157);
            this.ScoreTotallbl.Name = "ScoreTotallbl";
            this.ScoreTotallbl.Size = new System.Drawing.Size(71, 19);
            this.ScoreTotallbl.TabIndex = 9;
            this.ScoreTotallbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreCountlbl
            // 
            this.ScoreCountlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreCountlbl.Location = new System.Drawing.Point(167, 182);
            this.ScoreCountlbl.Name = "ScoreCountlbl";
            this.ScoreCountlbl.Size = new System.Drawing.Size(71, 19);
            this.ScoreCountlbl.TabIndex = 10;
            this.ScoreCountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Averagelbl
            // 
            this.Averagelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Averagelbl.Location = new System.Drawing.Point(167, 206);
            this.Averagelbl.Name = "Averagelbl";
            this.Averagelbl.Size = new System.Drawing.Size(71, 19);
            this.Averagelbl.TabIndex = 11;
            this.Averagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(263, 204);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 243);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Averagelbl);
            this.Controls.Add(this.ScoreCountlbl);
            this.Controls.Add(this.ScoreTotallbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StudentLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox StudentLB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ScoreTotallbl;
        private System.Windows.Forms.Label ScoreCountlbl;
        private System.Windows.Forms.Label Averagelbl;
        private System.Windows.Forms.Button Exit;
    }
}

