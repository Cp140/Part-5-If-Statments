namespace Part_5__If_Statments
{
    partial class IfStatments
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
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblStage = new System.Windows.Forms.Label();
            this.btnSubmitAge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(12, 12);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(249, 26);
            this.txtAge.TabIndex = 0;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStage.Location = new System.Drawing.Point(12, 41);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(342, 20);
            this.lblStage.TabIndex = 2;
            this.lblStage.Text = "Life Stage                                                                 ";
            // 
            // btnSubmitAge
            // 
            this.btnSubmitAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAge.Location = new System.Drawing.Point(96, 64);
            this.btnSubmitAge.Name = "btnSubmitAge";
            this.btnSubmitAge.Size = new System.Drawing.Size(82, 36);
            this.btnSubmitAge.TabIndex = 3;
            this.btnSubmitAge.Text = "Submit";
            this.btnSubmitAge.UseVisualStyleBackColor = true;
            this.btnSubmitAge.Click += new System.EventHandler(this.btnSubmitAge_Click);
            // 
            // IfStatments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 117);
            this.Controls.Add(this.btnSubmitAge);
            this.Controls.Add(this.lblStage);
            this.Controls.Add(this.txtAge);
            this.Name = "IfStatments";
            this.Text = "Part 5, If Statments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Button btnSubmitAge;
    }
}

