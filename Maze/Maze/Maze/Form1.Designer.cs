namespace Maze
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Maze_Panel = new System.Windows.Forms.Panel();
            this.MazeGenerete = new System.Windows.Forms.Button();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.size3 = new System.Windows.Forms.RadioButton();
            this.size2 = new System.Windows.Forms.RadioButton();
            this.size1 = new System.Windows.Forms.RadioButton();
            this.isRandom = new System.Windows.Forms.CheckBox();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Maze_Panel
            // 
            this.Maze_Panel.BackColor = System.Drawing.Color.LightCyan;
            this.Maze_Panel.Location = new System.Drawing.Point(50, 100);
            this.Maze_Panel.Name = "Maze_Panel";
            this.Maze_Panel.Size = new System.Drawing.Size(504, 504);
            this.Maze_Panel.TabIndex = 0;
            // 
            // MazeGenerete
            // 
            this.MazeGenerete.Location = new System.Drawing.Point(270, 29);
            this.MazeGenerete.Name = "MazeGenerete";
            this.MazeGenerete.Size = new System.Drawing.Size(149, 58);
            this.MazeGenerete.TabIndex = 1;
            this.MazeGenerete.Text = "Generete";
            this.MazeGenerete.UseVisualStyleBackColor = true;
            this.MazeGenerete.Click += new System.EventHandler(this.MazeGenereteButton_Click);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.size3);
            this.sizeGroupBox.Controls.Add(this.size2);
            this.sizeGroupBox.Controls.Add(this.size1);
            this.sizeGroupBox.Location = new System.Drawing.Point(50, 12);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(194, 75);
            this.sizeGroupBox.TabIndex = 2;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // size3
            // 
            this.size3.AutoSize = true;
            this.size3.Location = new System.Drawing.Point(130, 32);
            this.size3.Name = "size3";
            this.size3.Size = new System.Drawing.Size(100, 28);
            this.size3.TabIndex = 5;
            this.size3.TabStop = true;
            this.size3.Text = "50x50";
            this.size3.UseVisualStyleBackColor = true;
            // 
            // size2
            // 
            this.size2.AutoSize = true;
            this.size2.Checked = true;
            this.size2.Location = new System.Drawing.Point(70, 32);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(100, 28);
            this.size2.TabIndex = 4;
            this.size2.TabStop = true;
            this.size2.Text = "20x20";
            this.size2.UseVisualStyleBackColor = true;
            // 
            // size1
            // 
            this.size1.AutoSize = true;
            this.size1.Location = new System.Drawing.Point(10, 32);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(100, 28);
            this.size1.TabIndex = 3;
            this.size1.TabStop = true;
            this.size1.Text = "10x10";
            this.size1.UseVisualStyleBackColor = true;
            // 
            // isRandom
            // 
            this.isRandom.AutoSize = true;
            this.isRandom.Checked = true;
            this.isRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isRandom.Location = new System.Drawing.Point(270, 10);
            this.isRandom.Name = "isRandom";
            this.isRandom.Size = new System.Drawing.Size(139, 28);
            this.isRandom.TabIndex = 3;
            this.isRandom.Text = "IsRandom";
            this.isRandom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(609, 661);
            this.Controls.Add(this.isRandom);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.MazeGenerete);
            this.Controls.Add(this.Maze_Panel);
            this.MinimumSize = new System.Drawing.Size(625, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Maze";
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Maze_Panel;
        private System.Windows.Forms.Button MazeGenerete;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.RadioButton size1;
        private System.Windows.Forms.RadioButton size2;
        private System.Windows.Forms.RadioButton size3;
        private System.Windows.Forms.CheckBox isRandom;
    }
}

