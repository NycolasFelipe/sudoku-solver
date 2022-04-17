namespace SudokuSolver
{
    partial class SudokuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuForm));
            this.sudokuGridPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.CheckInputButton = new System.Windows.Forms.Button();
            this.ClearInputButton = new System.Windows.Forms.Button();
            this.BeginnerLevel = new System.Windows.Forms.RadioButton();
            this.IntermediateLevel = new System.Windows.Forms.RadioButton();
            this.AdvancedLevel = new System.Windows.Forms.RadioButton();
            this.authorLabel = new System.Windows.Forms.Label();
            this.DifficultiesGroupBox = new System.Windows.Forms.GroupBox();
            this.SolveButton = new System.Windows.Forms.Button();
            this.DifficultiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sudokuGridPanel
            // 
            this.sudokuGridPanel.ForeColor = System.Drawing.Color.Black;
            this.sudokuGridPanel.Location = new System.Drawing.Point(2, 1);
            this.sudokuGridPanel.Name = "sudokuGridPanel";
            this.sudokuGridPanel.Size = new System.Drawing.Size(361, 366);
            this.sudokuGridPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(9, 457);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(94, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "SUDOKU SOLVER";
            // 
            // NewGameButton
            // 
            this.NewGameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.NewGameButton.Location = new System.Drawing.Point(108, 373);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(153, 37);
            this.NewGameButton.TabIndex = 2;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // CheckInputButton
            // 
            this.CheckInputButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.CheckInputButton.Location = new System.Drawing.Point(262, 373);
            this.CheckInputButton.Name = "CheckInputButton";
            this.CheckInputButton.Size = new System.Drawing.Size(96, 37);
            this.CheckInputButton.TabIndex = 3;
            this.CheckInputButton.Text = "Check Input";
            this.CheckInputButton.UseVisualStyleBackColor = true;
            this.CheckInputButton.Click += new System.EventHandler(this.CheckInputButton_Click);
            // 
            // ClearInputButton
            // 
            this.ClearInputButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.ClearInputButton.Location = new System.Drawing.Point(262, 411);
            this.ClearInputButton.Name = "ClearInputButton";
            this.ClearInputButton.Size = new System.Drawing.Size(96, 36);
            this.ClearInputButton.TabIndex = 4;
            this.ClearInputButton.Text = "Clear Input";
            this.ClearInputButton.UseVisualStyleBackColor = true;
            this.ClearInputButton.Click += new System.EventHandler(this.ClearInputButton_Click);
            // 
            // BeginnerLevel
            // 
            this.BeginnerLevel.AutoSize = true;
            this.BeginnerLevel.Checked = true;
            this.BeginnerLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BeginnerLevel.Location = new System.Drawing.Point(7, 18);
            this.BeginnerLevel.Name = "BeginnerLevel";
            this.BeginnerLevel.Size = new System.Drawing.Size(72, 19);
            this.BeginnerLevel.TabIndex = 6;
            this.BeginnerLevel.TabStop = true;
            this.BeginnerLevel.Text = "Beginner";
            this.BeginnerLevel.UseVisualStyleBackColor = true;
            // 
            // IntermediateLevel
            // 
            this.IntermediateLevel.AutoSize = true;
            this.IntermediateLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IntermediateLevel.Location = new System.Drawing.Point(7, 39);
            this.IntermediateLevel.Name = "IntermediateLevel";
            this.IntermediateLevel.Size = new System.Drawing.Size(92, 19);
            this.IntermediateLevel.TabIndex = 7;
            this.IntermediateLevel.Text = "Intermediate";
            this.IntermediateLevel.UseVisualStyleBackColor = true;
            // 
            // AdvancedLevel
            // 
            this.AdvancedLevel.AutoSize = true;
            this.AdvancedLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AdvancedLevel.Location = new System.Drawing.Point(7, 60);
            this.AdvancedLevel.Name = "AdvancedLevel";
            this.AdvancedLevel.Size = new System.Drawing.Size(78, 19);
            this.AdvancedLevel.TabIndex = 8;
            this.AdvancedLevel.Text = "Advanced";
            this.AdvancedLevel.UseVisualStyleBackColor = true;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.authorLabel.Location = new System.Drawing.Point(218, 457);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(137, 13);
            this.authorLabel.TabIndex = 9;
            this.authorLabel.Text = "@NYCOLASFELIPE - 2022";
            // 
            // DifficultiesGroupBox
            // 
            this.DifficultiesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.DifficultiesGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DifficultiesGroupBox.Controls.Add(this.IntermediateLevel);
            this.DifficultiesGroupBox.Controls.Add(this.BeginnerLevel);
            this.DifficultiesGroupBox.Controls.Add(this.AdvancedLevel);
            this.DifficultiesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DifficultiesGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultiesGroupBox.Location = new System.Drawing.Point(6, 365);
            this.DifficultiesGroupBox.Name = "DifficultiesGroupBox";
            this.DifficultiesGroupBox.Size = new System.Drawing.Size(100, 82);
            this.DifficultiesGroupBox.TabIndex = 1;
            this.DifficultiesGroupBox.TabStop = false;
            this.DifficultiesGroupBox.Text = "Level";
            // 
            // SolveButton
            // 
            this.SolveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.SolveButton.Location = new System.Drawing.Point(108, 411);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(153, 36);
            this.SolveButton.TabIndex = 10;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 479);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.DifficultiesGroupBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.ClearInputButton);
            this.Controls.Add(this.CheckInputButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.sudokuGridPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SudokuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku Solver";
            this.Load += new System.EventHandler(this.SudokuForm_Load);
            this.DifficultiesGroupBox.ResumeLayout(false);
            this.DifficultiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sudokuGridPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button CheckInputButton;
        private System.Windows.Forms.Button ClearInputButton;
        private System.Windows.Forms.RadioButton BeginnerLevel;
        private System.Windows.Forms.RadioButton IntermediateLevel;
        private System.Windows.Forms.RadioButton AdvancedLevel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.GroupBox DifficultiesGroupBox;
        private System.Windows.Forms.Button SolveButton;
    }
}