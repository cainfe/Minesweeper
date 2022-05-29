
namespace Minesweeper
{
    partial class MinesweeperInitiationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinesweeperInitiationForm));
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumBombs = new System.Windows.Forms.NumericUpDown();
            this.nudGridWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGridHeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBombs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(103, 178);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Bombs:";
            // 
            // nudNumBombs
            // 
            this.nudNumBombs.Location = new System.Drawing.Point(16, 29);
            this.nudNumBombs.Name = "nudNumBombs";
            this.nudNumBombs.Size = new System.Drawing.Size(120, 20);
            this.nudNumBombs.TabIndex = 4;
            this.nudNumBombs.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nudGridWidth
            // 
            this.nudGridWidth.Location = new System.Drawing.Point(272, 29);
            this.nudGridWidth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudGridWidth.Name = "nudGridWidth";
            this.nudGridWidth.Size = new System.Drawing.Size(120, 20);
            this.nudGridWidth.TabIndex = 6;
            this.nudGridWidth.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size of Field:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height:";
            // 
            // nudGridHeight
            // 
            this.nudGridHeight.Location = new System.Drawing.Point(272, 55);
            this.nudGridHeight.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudGridHeight.Name = "nudGridHeight";
            this.nudGridHeight.Size = new System.Drawing.Size(120, 20);
            this.nudGridHeight.TabIndex = 8;
            this.nudGridHeight.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // MinesweeperInitiationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudGridHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudGridWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudNumBombs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MinesweeperInitiationForm";
            this.Text = "Minesweeper Initiation";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBombs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumBombs;
        private System.Windows.Forms.NumericUpDown nudGridWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudGridHeight;
    }
}