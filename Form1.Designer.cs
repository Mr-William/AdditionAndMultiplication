namespace AdditionAndMultiplication
{
    partial class frmAddMultiply
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
            this.valueATextBox = new System.Windows.Forms.TextBox();
            this.valueBTextBox = new System.Windows.Forms.TextBox();
            this.valueCTextBox = new System.Windows.Forms.TextBox();
            this.lblValueA = new System.Windows.Forms.Label();
            this.lblValueB = new System.Windows.Forms.Label();
            this.lblValueC = new System.Windows.Forms.Label();
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btnResult2 = new System.Windows.Forms.Button();
            this.result1TextBox = new System.Windows.Forms.TextBox();
            this.result2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valueATextBox
            // 
            this.valueATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueATextBox.Location = new System.Drawing.Point(79, 79);
            this.valueATextBox.Name = "valueATextBox";
            this.valueATextBox.Size = new System.Drawing.Size(100, 30);
            this.valueATextBox.TabIndex = 0;
            // 
            // valueBTextBox
            // 
            this.valueBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBTextBox.Location = new System.Drawing.Point(283, 79);
            this.valueBTextBox.Name = "valueBTextBox";
            this.valueBTextBox.Size = new System.Drawing.Size(100, 30);
            this.valueBTextBox.TabIndex = 1;
            // 
            // valueCTextBox
            // 
            this.valueCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueCTextBox.Location = new System.Drawing.Point(487, 79);
            this.valueCTextBox.Name = "valueCTextBox";
            this.valueCTextBox.Size = new System.Drawing.Size(100, 30);
            this.valueCTextBox.TabIndex = 2;
            // 
            // lblValueA
            // 
            this.lblValueA.AutoSize = true;
            this.lblValueA.Location = new System.Drawing.Point(12, 79);
            this.lblValueA.Name = "lblValueA";
            this.lblValueA.Size = new System.Drawing.Size(61, 17);
            this.lblValueA.TabIndex = 3;
            this.lblValueA.Text = "Value A:";
            // 
            // lblValueB
            // 
            this.lblValueB.AutoSize = true;
            this.lblValueB.Location = new System.Drawing.Point(216, 79);
            this.lblValueB.Name = "lblValueB";
            this.lblValueB.Size = new System.Drawing.Size(61, 17);
            this.lblValueB.TabIndex = 4;
            this.lblValueB.Text = "Value B:";
            // 
            // lblValueC
            // 
            this.lblValueC.AutoSize = true;
            this.lblValueC.Location = new System.Drawing.Point(420, 79);
            this.lblValueC.Name = "lblValueC";
            this.lblValueC.Size = new System.Drawing.Size(61, 17);
            this.lblValueC.TabIndex = 5;
            this.lblValueC.Text = "Value C:";
            // 
            // btnResult1
            // 
            this.btnResult1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult1.Location = new System.Drawing.Point(103, 192);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(89, 32);
            this.btnResult1.TabIndex = 6;
            this.btnResult1.Text = "A + (B * C)";
            this.btnResult1.UseVisualStyleBackColor = false;
            this.btnResult1.Click += new System.EventHandler(this.btnResult1_Click);
            // 
            // btnResult2
            // 
            this.btnResult2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnResult2.Location = new System.Drawing.Point(103, 245);
            this.btnResult2.Name = "btnResult2";
            this.btnResult2.Size = new System.Drawing.Size(89, 32);
            this.btnResult2.TabIndex = 7;
            this.btnResult2.Text = "(A + B) * C";
            this.btnResult2.UseVisualStyleBackColor = false;
            this.btnResult2.Click += new System.EventHandler(this.btnResult2_Click);
            // 
            // result1TextBox
            // 
            this.result1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1TextBox.Location = new System.Drawing.Point(199, 192);
            this.result1TextBox.Name = "result1TextBox";
            this.result1TextBox.Size = new System.Drawing.Size(151, 38);
            this.result1TextBox.TabIndex = 8;
            // 
            // result2TextBox
            // 
            this.result2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2TextBox.Location = new System.Drawing.Point(199, 245);
            this.result2TextBox.Name = "result2TextBox";
            this.result2TextBox.Size = new System.Drawing.Size(151, 38);
            this.result2TextBox.TabIndex = 9;
            // 
            // frmAddMultiply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.result2TextBox);
            this.Controls.Add(this.result1TextBox);
            this.Controls.Add(this.btnResult2);
            this.Controls.Add(this.btnResult1);
            this.Controls.Add(this.lblValueC);
            this.Controls.Add(this.lblValueB);
            this.Controls.Add(this.lblValueA);
            this.Controls.Add(this.valueCTextBox);
            this.Controls.Add(this.valueBTextBox);
            this.Controls.Add(this.valueATextBox);
            this.Name = "frmAddMultiply";
            this.Text = "Addition and Multiplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueATextBox;
        private System.Windows.Forms.TextBox valueBTextBox;
        private System.Windows.Forms.TextBox valueCTextBox;
        private System.Windows.Forms.Label lblValueA;
        private System.Windows.Forms.Label lblValueB;
        private System.Windows.Forms.Label lblValueC;
        private System.Windows.Forms.Button btnResult1;
        private System.Windows.Forms.Button btnResult2;
        private System.Windows.Forms.TextBox result1TextBox;
        private System.Windows.Forms.TextBox result2TextBox;
    }
}

