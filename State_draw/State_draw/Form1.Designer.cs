namespace State_draw
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
            this.LineButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PensilButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(30, 41);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(209, 45);
            this.LineButton.TabIndex = 1;
            this.LineButton.Text = "Линия";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.UseWaitCursor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(30, 103);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(209, 45);
            this.RectangleButton.TabIndex = 2;
            this.RectangleButton.Text = "Квадрат";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.UseWaitCursor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(30, 165);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(209, 45);
            this.CircleButton.TabIndex = 3;
            this.CircleButton.Text = "Круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.UseWaitCursor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите инструмент";
            this.label1.UseWaitCursor = true;
            // 
            // PensilButton
            // 
            this.PensilButton.Location = new System.Drawing.Point(30, 226);
            this.PensilButton.Name = "PensilButton";
            this.PensilButton.Size = new System.Drawing.Size(209, 45);
            this.PensilButton.TabIndex = 5;
            this.PensilButton.Text = "Карандаш";
            this.PensilButton.UseVisualStyleBackColor = true;
            this.PensilButton.UseWaitCursor = true;
            this.PensilButton.Click += new System.EventHandler(this.PensilButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 360);
            this.Controls.Add(this.PensilButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PensilButton;
    }
}

