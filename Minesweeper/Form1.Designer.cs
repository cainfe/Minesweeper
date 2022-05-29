
namespace Minesweeper
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
            this.btnPlayMinesweeper = new System.Windows.Forms.Button();
            this.btnPreviewMinesweeper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayMinesweeper
            // 
            this.btnPlayMinesweeper.Location = new System.Drawing.Point(76, 12);
            this.btnPlayMinesweeper.Name = "btnPlayMinesweeper";
            this.btnPlayMinesweeper.Size = new System.Drawing.Size(123, 23);
            this.btnPlayMinesweeper.TabIndex = 0;
            this.btnPlayMinesweeper.Text = "Play Minesweeper";
            this.btnPlayMinesweeper.UseVisualStyleBackColor = true;
            this.btnPlayMinesweeper.Click += new System.EventHandler(this.btnPlayMinesweeper_Click);
            // 
            // btnPreviewMinesweeper
            // 
            this.btnPreviewMinesweeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewMinesweeper.Location = new System.Drawing.Point(12, 41);
            this.btnPreviewMinesweeper.Name = "btnPreviewMinesweeper";
            this.btnPreviewMinesweeper.Size = new System.Drawing.Size(250, 250);
            this.btnPreviewMinesweeper.TabIndex = 1;
            this.btnPreviewMinesweeper.UseVisualStyleBackColor = true;
            this.btnPreviewMinesweeper.Click += new System.EventHandler(this.btnPreviewMinesweeper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 303);
            this.Controls.Add(this.btnPreviewMinesweeper);
            this.Controls.Add(this.btnPlayMinesweeper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayMinesweeper;
        private System.Windows.Forms.Button btnPreviewMinesweeper;
    }
}

