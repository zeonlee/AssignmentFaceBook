namespace AssignmentFaceBook
{
    partial class mainboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainboard));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "3.3.The CRUD data cycle (Read)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "MainBoard Queries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 136);
            this.label3.TabIndex = 15;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "3.2.Querying the database ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Run Query";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Location = new System.Drawing.Point(494, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back to Login\r\n(Warning: server connection will reset)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "3.3.The CRUD data cycle (Create)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Create User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "3.3.The CRUD data cycle (Update)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(323, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Update User";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(323, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Delete User";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "3.3.The CRUD data cycle (Delete)";
            // 
            // mainboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "mainboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainBoard";
            this.Load += new System.EventHandler(this.mainboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
    }
}