namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.commentsValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pValue = new System.Windows.Forms.TextBox();
            this.rSquaredValue = new System.Windows.Forms.TextBox();
            this.adjustedRSquaredValue = new System.Windows.Forms.TextBox();
            this.maeValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(54, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Лайки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(90, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(722, 59);
            this.label5.TabIndex = 4;
            this.label5.Text = "Продвижение в социальных сетях";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Результат прогнозирования";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(675, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // commentsValue
            // 
            this.commentsValue.Location = new System.Drawing.Point(262, 180);
            this.commentsValue.Name = "commentsValue";
            this.commentsValue.ReadOnly = true;
            this.commentsValue.Size = new System.Drawing.Size(100, 20);
            this.commentsValue.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "p-value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(54, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "R-squared";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(54, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adjusted R-squared";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(54, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "MAE";
            // 
            // pValue
            // 
            this.pValue.Location = new System.Drawing.Point(262, 215);
            this.pValue.Name = "pValue";
            this.pValue.ReadOnly = true;
            this.pValue.Size = new System.Drawing.Size(100, 20);
            this.pValue.TabIndex = 17;
            // 
            // rSquaredValue
            // 
            this.rSquaredValue.Location = new System.Drawing.Point(262, 253);
            this.rSquaredValue.Name = "rSquaredValue";
            this.rSquaredValue.ReadOnly = true;
            this.rSquaredValue.Size = new System.Drawing.Size(100, 20);
            this.rSquaredValue.TabIndex = 18;
            // 
            // adjustedRSquaredValue
            // 
            this.adjustedRSquaredValue.Location = new System.Drawing.Point(262, 296);
            this.adjustedRSquaredValue.Name = "adjustedRSquaredValue";
            this.adjustedRSquaredValue.ReadOnly = true;
            this.adjustedRSquaredValue.Size = new System.Drawing.Size(100, 20);
            this.adjustedRSquaredValue.TabIndex = 19;
            // 
            // maeValue
            // 
            this.maeValue.Location = new System.Drawing.Point(262, 337);
            this.maeValue.Name = "maeValue";
            this.maeValue.ReadOnly = true;
            this.maeValue.Size = new System.Drawing.Size(100, 20);
            this.maeValue.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 391);
            this.Controls.Add(this.maeValue);
            this.Controls.Add(this.adjustedRSquaredValue);
            this.Controls.Add(this.rSquaredValue);
            this.Controls.Add(this.pValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentsValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox commentsValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pValue;
        private System.Windows.Forms.TextBox rSquaredValue;
        private System.Windows.Forms.TextBox adjustedRSquaredValue;
        private System.Windows.Forms.TextBox maeValue;
    }
}