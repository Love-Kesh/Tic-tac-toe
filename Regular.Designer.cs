﻿namespace Tic_tac_toe
{
    partial class Regular
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(36, 41);
            btn1.Name = "btn1";
            btn1.Size = new Size(160, 108);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(228, 41);
            btn2.Name = "btn2";
            btn2.Size = new Size(160, 108);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(420, 41);
            btn3.Name = "btn3";
            btn3.Size = new Size(160, 108);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(36, 192);
            btn4.Name = "btn4";
            btn4.Size = new Size(160, 108);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(228, 192);
            btn5.Name = "btn5";
            btn5.Size = new Size(160, 108);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(420, 192);
            btn6.Name = "btn6";
            btn6.Size = new Size(160, 108);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(36, 339);
            btn7.Name = "btn7";
            btn7.Size = new Size(160, 108);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(228, 339);
            btn8.Name = "btn8";
            btn8.Size = new Size(160, 108);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(420, 339);
            btn9.Name = "btn9";
            btn9.Size = new Size(160, 108);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_Click;
            // 
            // Regular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 487);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Regular";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Regular";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
    }
}