namespace Quadroteka
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.newGameButton = new System.Windows.Forms.Button();
            this.gameStateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movesCountLabel = new System.Windows.Forms.Label();
            this.turnsCountLabel = new System.Windows.Forms.Label();
            this.rowsCollectedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            gameFieldDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(gameFieldDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(12, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(103, 23);
            this.newGameButton.TabIndex = 6;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gameFieldDataGridView
            // 
            gameFieldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameFieldDataGridView.Location = new System.Drawing.Point(12, 106);
            gameFieldDataGridView.Name = "gameFieldDataGridView";
            gameFieldDataGridView.Size = new System.Drawing.Size(240, 150);
            gameFieldDataGridView.TabIndex = 7;
            gameFieldDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gameFieldDataGridView_CellPainting);
            // 
            // gameStateLabel
            // 
            this.gameStateLabel.AutoSize = true;
            this.gameStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameStateLabel.Location = new System.Drawing.Point(121, 12);
            this.gameStateLabel.Name = "gameStateLabel";
            this.gameStateLabel.Size = new System.Drawing.Size(143, 20);
            this.gameStateLabel.TabIndex = 8;
            this.gameStateLabel.Text = "Игра не начилась";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ходов сделано:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поворотов сделано:";
            // 
            // movesCountLabel
            // 
            this.movesCountLabel.AutoSize = true;
            this.movesCountLabel.Location = new System.Drawing.Point(102, 48);
            this.movesCountLabel.Name = "movesCountLabel";
            this.movesCountLabel.Size = new System.Drawing.Size(13, 13);
            this.movesCountLabel.TabIndex = 11;
            this.movesCountLabel.Text = "0";
            // 
            // turnsCountLabel
            // 
            this.turnsCountLabel.AutoSize = true;
            this.turnsCountLabel.Location = new System.Drawing.Point(122, 77);
            this.turnsCountLabel.Name = "turnsCountLabel";
            this.turnsCountLabel.Size = new System.Drawing.Size(13, 13);
            this.turnsCountLabel.TabIndex = 12;
            this.turnsCountLabel.Text = "0";
            // 
            // rowsCollectedLabel
            // 
            this.rowsCollectedLabel.AutoSize = true;
            this.rowsCollectedLabel.Location = new System.Drawing.Point(275, 48);
            this.rowsCollectedLabel.Name = "rowsCollectedLabel";
            this.rowsCollectedLabel.Size = new System.Drawing.Size(13, 13);
            this.rowsCollectedLabel.TabIndex = 14;
            this.rowsCollectedLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Столбцов собрано:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 480);
            this.Controls.Add(this.rowsCollectedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.turnsCountLabel);
            this.Controls.Add(this.movesCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameStateLabel);
            this.Controls.Add(gameFieldDataGridView);
            this.Controls.Add(this.newGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(gameFieldDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label gameStateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label movesCountLabel;
        private System.Windows.Forms.Label turnsCountLabel;
        private System.Windows.Forms.Label rowsCollectedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gameFieldDataGridView;
    }
}

