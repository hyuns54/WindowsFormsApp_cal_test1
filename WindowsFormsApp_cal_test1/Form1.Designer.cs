namespace WindowsFormsApp_cal_test1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.display = new System.Windows.Forms.TextBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_ClearEntry = new System.Windows.Forms.Button();
            this.Btn_devide = new System.Windows.Forms.Button();
            this.Btn_Multiply = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_Subtrack = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_Result = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.Btn_Point = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp_cal_test1.Properties.Resources.image__2_;
            this.pictureBox1.Location = new System.Drawing.Point(72, -112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(150, 27);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(309, 68);
            this.display.TabIndex = 23;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(150, 113);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(65, 56);
            this.Btn_Clear.TabIndex = 24;
            this.Btn_Clear.Text = "C";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_ClearEntry
            // 
            this.Btn_ClearEntry.Location = new System.Drawing.Point(234, 113);
            this.Btn_ClearEntry.Name = "Btn_ClearEntry";
            this.Btn_ClearEntry.Size = new System.Drawing.Size(65, 56);
            this.Btn_ClearEntry.TabIndex = 25;
            this.Btn_ClearEntry.Text = "CE";
            this.Btn_ClearEntry.UseVisualStyleBackColor = true;
            this.Btn_ClearEntry.Click += new System.EventHandler(this.Btn_ClearEntry_Click);
            // 
            // Btn_devide
            // 
            this.Btn_devide.Location = new System.Drawing.Point(314, 113);
            this.Btn_devide.Name = "Btn_devide";
            this.Btn_devide.Size = new System.Drawing.Size(65, 56);
            this.Btn_devide.TabIndex = 26;
            this.Btn_devide.Text = "/";
            this.Btn_devide.UseVisualStyleBackColor = true;
            this.Btn_devide.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Btn_Multiply
            // 
            this.Btn_Multiply.Location = new System.Drawing.Point(394, 113);
            this.Btn_Multiply.Name = "Btn_Multiply";
            this.Btn_Multiply.Size = new System.Drawing.Size(65, 56);
            this.Btn_Multiply.TabIndex = 27;
            this.Btn_Multiply.Text = "*";
            this.Btn_Multiply.UseVisualStyleBackColor = true;
            this.Btn_Multiply.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.Location = new System.Drawing.Point(150, 193);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(65, 56);
            this.Btn_7.TabIndex = 28;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = true;
            this.Btn_7.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.Location = new System.Drawing.Point(234, 193);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(65, 56);
            this.Btn_8.TabIndex = 29;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = true;
            this.Btn_8.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.Location = new System.Drawing.Point(314, 193);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(65, 56);
            this.Btn_9.TabIndex = 30;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = true;
            this.Btn_9.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Subtrack
            // 
            this.Btn_Subtrack.Location = new System.Drawing.Point(394, 193);
            this.Btn_Subtrack.Name = "Btn_Subtrack";
            this.Btn_Subtrack.Size = new System.Drawing.Size(65, 56);
            this.Btn_Subtrack.TabIndex = 31;
            this.Btn_Subtrack.Text = "-";
            this.Btn_Subtrack.UseVisualStyleBackColor = true;
            this.Btn_Subtrack.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.Location = new System.Drawing.Point(150, 271);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(65, 56);
            this.Btn_4.TabIndex = 32;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.Location = new System.Drawing.Point(234, 271);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(65, 56);
            this.Btn_5.TabIndex = 33;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = true;
            this.Btn_5.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.Location = new System.Drawing.Point(314, 271);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(65, 56);
            this.Btn_6.TabIndex = 34;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = true;
            this.Btn_6.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(394, 271);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(65, 56);
            this.Btn_Add.TabIndex = 35;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.Location = new System.Drawing.Point(150, 348);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(65, 56);
            this.Btn_1.TabIndex = 36;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.Location = new System.Drawing.Point(234, 348);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(65, 56);
            this.Btn_2.TabIndex = 37;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.Location = new System.Drawing.Point(314, 348);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(65, 56);
            this.Btn_3.TabIndex = 38;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Result
            // 
            this.Btn_Result.Location = new System.Drawing.Point(394, 348);
            this.Btn_Result.Name = "Btn_Result";
            this.Btn_Result.Size = new System.Drawing.Size(65, 138);
            this.Btn_Result.TabIndex = 39;
            this.Btn_Result.Text = "=";
            this.Btn_Result.UseVisualStyleBackColor = true;
            this.Btn_Result.Click += new System.EventHandler(this.Btn_Result_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.Location = new System.Drawing.Point(150, 430);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(149, 56);
            this.Btn_0.TabIndex = 40;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = true;
            this.Btn_0.Click += new System.EventHandler(this.Number_Click);
            // 
            // Btn_Point
            // 
            this.Btn_Point.Location = new System.Drawing.Point(314, 430);
            this.Btn_Point.Name = "Btn_Point";
            this.Btn_Point.Size = new System.Drawing.Size(65, 56);
            this.Btn_Point.TabIndex = 41;
            this.Btn_Point.Text = ".";
            this.Btn_Point.UseVisualStyleBackColor = true;
            this.Btn_Point.Click += new System.EventHandler(this.Btn_Point_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 696);
            this.Controls.Add(this.Btn_Point);
            this.Controls.Add(this.Btn_0);
            this.Controls.Add(this.Btn_Result);
            this.Controls.Add(this.Btn_3);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Btn_1);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_6);
            this.Controls.Add(this.Btn_5);
            this.Controls.Add(this.Btn_4);
            this.Controls.Add(this.Btn_Subtrack);
            this.Controls.Add(this.Btn_9);
            this.Controls.Add(this.Btn_8);
            this.Controls.Add(this.Btn_7);
            this.Controls.Add(this.Btn_Multiply);
            this.Controls.Add(this.Btn_devide);
            this.Controls.Add(this.Btn_ClearEntry);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.display);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_ClearEntry;
        private System.Windows.Forms.Button Btn_devide;
        private System.Windows.Forms.Button Btn_Multiply;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_Subtrack;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_Result;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Button Btn_Point;
    }
}

