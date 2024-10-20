namespace Tic_tac_toe
{
    partial class Mode_Selection
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
            btnRegular = new Button();
            btnAdvanced = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegular
            // 
            btnRegular.Font = new Font("Calibri", 20.25F);
            btnRegular.Location = new Point(157, 196);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(171, 91);
            btnRegular.TabIndex = 0;
            btnRegular.Text = "Regular";
            btnRegular.UseVisualStyleBackColor = true;
            btnRegular.Click += btnRegular_Click;
            // 
            // btnAdvanced
            // 
            btnAdvanced.Font = new Font("Calibri", 20.25F);
            btnAdvanced.Location = new Point(465, 196);
            btnAdvanced.Name = "btnAdvanced";
            btnAdvanced.Size = new Size(171, 91);
            btnAdvanced.TabIndex = 1;
            btnAdvanced.Text = "Advanced";
            btnAdvanced.UseVisualStyleBackColor = true;
            btnAdvanced.Click += btnAdvanced_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 84);
            label1.Name = "label1";
            label1.Size = new Size(270, 33);
            label1.TabIndex = 2;
            label1.Text = "Choose Game Mode!!!";
            // 
            // Mode_Selection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAdvanced);
            Controls.Add(btnRegular);
            Name = "Mode_Selection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Selection";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegular;
        private Button btnAdvanced;
        private Label label1;
    }
}
