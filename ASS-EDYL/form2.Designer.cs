namespace ASS_EDYL
{
    partial class form2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(33, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(207, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.Text = "Integer Only";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.Click += new System.EventHandler(this.textBox1_Click);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            this.txtNum.MouseLeave += new System.EventHandler(this.txtNum_MouseLeave);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(30, 167);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(13, 13);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "0";
            this.lbResult.Visible = false;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 99);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Name = "form2";
            this.Text = "form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lbResult;
    }
}