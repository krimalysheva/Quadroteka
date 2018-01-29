namespace Att_3
{
    partial class Ex1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenutoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartButtom = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Answerlabel1 = new System.Windows.Forms.Label();
            this.inputGridView = new System.Windows.Forms.DataGridView();
            this.InputDGVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputGDVAmountOfMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputGDVRaiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputGDVCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputGridView = new System.Windows.Forms.DataGridView();
            this.OutputGDVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputGDVAmmountOfMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputGDVRaiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputGDVCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.label1Col = new System.Windows.Forms.Label();
            this.label2R = new System.Windows.Forms.Label();
            this.label3M = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.TextBox();
            this.label4K = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenutoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenutoolStripMenuItem
            // 
            this.MenutoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.SaveToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.MenutoolStripMenuItem.Name = "MenutoolStripMenuItem";
            this.MenutoolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.MenutoolStripMenuItem.Text = "Меню";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(135, 22);
            this.MainMenuFileOpen.Text = "Открыть";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить ";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // StartButtom
            // 
            this.StartButtom.Location = new System.Drawing.Point(27, 281);
            this.StartButtom.Name = "StartButtom";
            this.StartButtom.Size = new System.Drawing.Size(75, 34);
            this.StartButtom.TabIndex = 1;
            this.StartButtom.Text = "Enter";
            this.StartButtom.UseVisualStyleBackColor = true;
            this.StartButtom.Click += new System.EventHandler(this.StartButtom_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Answerlabel1
            // 
            this.Answerlabel1.AutoSize = true;
            this.Answerlabel1.Location = new System.Drawing.Point(266, 281);
            this.Answerlabel1.Name = "Answerlabel1";
            this.Answerlabel1.Size = new System.Drawing.Size(40, 13);
            this.Answerlabel1.TabIndex = 2;
            this.Answerlabel1.Text = "Ответ:";
            // 
            // inputGridView
            // 
            this.inputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InputDGVName,
            this.InputGDVAmountOfMemory,
            this.InputGDVRaiting,
            this.InputGDVCount});
            this.inputGridView.Location = new System.Drawing.Point(269, 27);
            this.inputGridView.Name = "inputGridView";
            this.inputGridView.Size = new System.Drawing.Size(493, 225);
            this.inputGridView.TabIndex = 3;
            // 
            // InputDGVName
            // 
            this.InputDGVName.HeaderText = "Название";
            this.InputDGVName.Name = "InputDGVName";
            this.InputDGVName.Width = 150;
            // 
            // InputGDVAmountOfMemory
            // 
            this.InputGDVAmountOfMemory.HeaderText = "Объем памяти";
            this.InputGDVAmountOfMemory.Name = "InputGDVAmountOfMemory";
            // 
            // InputGDVRaiting
            // 
            this.InputGDVRaiting.HeaderText = "Рейтинг";
            this.InputGDVRaiting.Name = "InputGDVRaiting";
            // 
            // InputGDVCount
            // 
            this.InputGDVCount.HeaderText = "Цена";
            this.InputGDVCount.Name = "InputGDVCount";
            // 
            // outputGridView
            // 
            this.outputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutputGDVName,
            this.OutputGDVAmmountOfMemory,
            this.OutputGDVRaiting,
            this.OutputGDVCount});
            this.outputGridView.Location = new System.Drawing.Point(269, 305);
            this.outputGridView.Name = "outputGridView";
            this.outputGridView.Size = new System.Drawing.Size(493, 212);
            this.outputGridView.TabIndex = 4;
            // 
            // OutputGDVName
            // 
            this.OutputGDVName.Frozen = true;
            this.OutputGDVName.HeaderText = "Название";
            this.OutputGDVName.Name = "OutputGDVName";
            this.OutputGDVName.ReadOnly = true;
            this.OutputGDVName.Width = 150;
            // 
            // OutputGDVAmmountOfMemory
            // 
            this.OutputGDVAmmountOfMemory.HeaderText = "Объем памяти";
            this.OutputGDVAmmountOfMemory.Name = "OutputGDVAmmountOfMemory";
            this.OutputGDVAmmountOfMemory.ReadOnly = true;
            // 
            // OutputGDVRaiting
            // 
            this.OutputGDVRaiting.HeaderText = "Рейтинг";
            this.OutputGDVRaiting.Name = "OutputGDVRaiting";
            this.OutputGDVRaiting.ReadOnly = true;
            // 
            // OutputGDVCount
            // 
            this.OutputGDVCount.HeaderText = "Цена";
            this.OutputGDVCount.Name = "OutputGDVCount";
            this.OutputGDVCount.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.Location = new System.Drawing.Point(27, 71);
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(100, 20);
            this.Col.TabIndex = 5;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(27, 182);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(100, 20);
            this.M.TabIndex = 6;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(27, 130);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(100, 20);
            this.R.TabIndex = 7;
            // 
            // label1Col
            // 
            this.label1Col.AutoSize = true;
            this.label1Col.Location = new System.Drawing.Point(24, 55);
            this.label1Col.Name = "label1Col";
            this.label1Col.Size = new System.Drawing.Size(105, 13);
            this.label1Col.TabIndex = 8;
            this.label1Col.Text = "Кол-во планшетов: ";
            // 
            // label2R
            // 
            this.label2R.AutoSize = true;
            this.label2R.Location = new System.Drawing.Point(24, 114);
            this.label2R.Name = "label2R";
            this.label2R.Size = new System.Drawing.Size(129, 13);
            this.label2R.TabIndex = 9;
            this.label2R.Text = "Минимальный рейтинг: ";
            // 
            // label3M
            // 
            this.label3M.AutoSize = true;
            this.label3M.Location = new System.Drawing.Point(24, 166);
            this.label3M.Name = "label3M";
            this.label3M.Size = new System.Drawing.Size(162, 13);
            this.label3M.TabIndex = 10;
            this.label3M.Text = "Минимальный объем памяти: ";
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(27, 232);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(100, 20);
            this.K.TabIndex = 11;
            // 
            // label4K
            // 
            this.label4K.AutoSize = true;
            this.label4K.Location = new System.Drawing.Point(24, 216);
            this.label4K.Name = "label4K";
            this.label4K.Size = new System.Drawing.Size(141, 13);
            this.label4K.TabIndex = 12;
            this.label4K.Text = "Минимальная стоимость: ";
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 544);
            this.Controls.Add(this.label4K);
            this.Controls.Add(this.K);
            this.Controls.Add(this.label3M);
            this.Controls.Add(this.label2R);
            this.Controls.Add(this.label1Col);
            this.Controls.Add(this.R);
            this.Controls.Add(this.M);
            this.Controls.Add(this.Col);
            this.Controls.Add(this.outputGridView);
            this.Controls.Add(this.inputGridView);
            this.Controls.Add(this.Answerlabel1);
            this.Controls.Add(this.StartButtom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ex1";
            this.Text = "10.1.18";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenutoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Button StartButtom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label Answerlabel1;
        private System.Windows.Forms.DataGridView inputGridView;
        private System.Windows.Forms.DataGridView outputGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputDGVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputGDVAmountOfMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputGDVRaiting;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputGDVCount;
        private System.Windows.Forms.TextBox Col;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Label label1Col;
        private System.Windows.Forms.Label label2R;
        private System.Windows.Forms.Label label3M;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.Label label4K;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputGDVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputGDVAmmountOfMemory;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputGDVRaiting;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputGDVCount;
    }
}

