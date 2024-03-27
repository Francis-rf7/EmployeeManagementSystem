namespace EmployeeManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lg_btn = new Button();
            label2 = new Label();
            Ad_tb = new TextBox();
            label3 = new Label();
            pswd_tb = new TextBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(731, 81);
            label1.TabIndex = 0;
            label1.Text = "Employee Management";
            // 
            // lg_btn
            // 
            lg_btn.Image = (Image)resources.GetObject("lg_btn.Image");
            lg_btn.ImageAlign = ContentAlignment.MiddleLeft;
            lg_btn.Location = new Point(138, 203);
            lg_btn.Name = "lg_btn";
            lg_btn.Size = new Size(112, 34);
            lg_btn.TabIndex = 1;
            lg_btn.Text = "Login";
            lg_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Admin";
            // 
            // Ad_tb
            // 
            Ad_tb.Location = new Point(208, 68);
            Ad_tb.Name = "Ad_tb";
            Ad_tb.Size = new Size(150, 31);
            Ad_tb.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 124);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // pswd_tb
            // 
            pswd_tb.Location = new Point(208, 124);
            pswd_tb.Name = "pswd_tb";
            pswd_tb.Size = new Size(150, 31);
            pswd_tb.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pswd_tb);
            groupBox1.Controls.Add(lg_btn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Ad_tb);
            groupBox1.Location = new Point(395, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 290);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button lg_btn;
        private Label label2;
        private TextBox Ad_tb;
        private Label label3;
        private TextBox pswd_tb;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}
