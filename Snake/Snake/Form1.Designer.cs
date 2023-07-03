namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Snake = new System.Windows.Forms.Button();
            this.Tail = new System.Windows.Forms.Button();
            this.Apple = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Score);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(73, 17);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(19, 20);
            this.lbl_Score.TabIndex = 2;
            this.lbl_Score.Text = "0";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(14, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(63, 20);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Score : ";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Exit.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Exit.Location = new System.Drawing.Point(405, 10);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(81, 32);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Snake);
            this.panel2.Controls.Add(this.Tail);
            this.panel2.Controls.Add(this.Apple);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 500);
            this.panel2.TabIndex = 1;
            // 
            // Snake
            // 
            this.Snake.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Snake.BackgroundImage = global::Snake.Properties.Resources.Right;
            this.Snake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Snake.Enabled = false;
            this.Snake.Location = new System.Drawing.Point(300, 25);
            this.Snake.Name = "Snake";
            this.Snake.Size = new System.Drawing.Size(25, 25);
            this.Snake.TabIndex = 4;
            this.Snake.UseVisualStyleBackColor = false;
            // 
            // Tail
            // 
            this.Tail.BackColor = System.Drawing.Color.LimeGreen;
            this.Tail.Enabled = false;
            this.Tail.Location = new System.Drawing.Point(274, 25);
            this.Tail.Name = "Tail";
            this.Tail.Size = new System.Drawing.Size(25, 25);
            this.Tail.TabIndex = 5;
            this.Tail.UseVisualStyleBackColor = false;
            // 
            // Apple
            // 
            this.Apple.Enabled = false;
            this.Apple.Image = global::Snake.Properties.Resources.Untitled3;
            this.Apple.Location = new System.Drawing.Point(52, 168);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(25, 25);
            this.Apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Apple.TabIndex = 3;
            this.Apple.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Snake;
        private System.Windows.Forms.Button Tail;
        private System.Windows.Forms.PictureBox Apple;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Score;
    }
}

