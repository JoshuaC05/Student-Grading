namespace OOP_Project___Joshua_Currie
{
    partial class Add
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
            this.CancelCancelBtn = new System.Windows.Forms.Button();
            this.AddScoretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelCancelBtn
            // 
            this.CancelCancelBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCancelBtn.Location = new System.Drawing.Point(101, 50);
            this.CancelCancelBtn.Name = "CancelCancelBtn";
            this.CancelCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelCancelBtn.TabIndex = 16;
            this.CancelCancelBtn.Text = "Cancel";
            this.CancelCancelBtn.UseVisualStyleBackColor = true;
            this.CancelCancelBtn.Click += new System.EventHandler(this.CancelCancelBtn_Click);
            // 
            // AddScoretxt
            // 
            this.AddScoretxt.Font = new System.Drawing.Font("Calibri", 9F);
            this.AddScoretxt.Location = new System.Drawing.Point(70, 22);
            this.AddScoretxt.Name = "AddScoretxt";
            this.AddScoretxt.Size = new System.Drawing.Size(106, 22);
            this.AddScoretxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Score :";
            // 
            // AddAddBtn
            // 
            this.AddAddBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAddBtn.Location = new System.Drawing.Point(20, 50);
            this.AddAddBtn.Name = "AddAddBtn";
            this.AddAddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAddBtn.TabIndex = 13;
            this.AddAddBtn.Text = "Add";
            this.AddAddBtn.UseVisualStyleBackColor = true;
            this.AddAddBtn.Click += new System.EventHandler(this.AddAddBtn_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 95);
            this.Controls.Add(this.CancelCancelBtn);
            this.Controls.Add(this.AddScoretxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAddBtn);
            this.Name = "Add";
            this.Text = "Add Score";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelCancelBtn;
        private System.Windows.Forms.TextBox AddScoretxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAddBtn;
    }
}