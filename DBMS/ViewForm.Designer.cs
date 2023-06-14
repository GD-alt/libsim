namespace DBMS
{
    partial class ViewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Viewer = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.QBooksReader = new System.Windows.Forms.Button();
            this.QReadersBook = new System.Windows.Forms.Button();
            this.QHolderBooksR = new System.Windows.Forms.Button();
            this.QReadersYear = new System.Windows.Forms.Button();
            this.QBooksOut = new System.Windows.Forms.Button();
            this.QBooksIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QueryResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArgumentInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SortParam = new System.Windows.Forms.ComboBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DropFilters = new System.Windows.Forms.Button();
            this.ReverseResults = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Всего записей в базе:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBar
            // 
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Viewer
            // 
            this.Viewer.AllowUserToAddRows = false;
            this.Viewer.AllowUserToDeleteRows = false;
            this.Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Viewer.Location = new System.Drawing.Point(15, 52);
            this.Viewer.Name = "Viewer";
            this.Viewer.ReadOnly = true;
            this.Viewer.Size = new System.Drawing.Size(561, 510);
            this.Viewer.TabIndex = 2;
            this.Viewer.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Viewer_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить запись...";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить запись...";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить запись";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(598, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выполнить запрос:";
            // 
            // QBooksReader
            // 
            this.QBooksReader.Location = new System.Drawing.Point(601, 169);
            this.QBooksReader.Name = "QBooksReader";
            this.QBooksReader.Size = new System.Drawing.Size(151, 23);
            this.QBooksReader.TabIndex = 4;
            this.QBooksReader.Text = "Книги читателя";
            this.QBooksReader.UseVisualStyleBackColor = true;
            this.QBooksReader.Click += new System.EventHandler(this.QBooksReader_Click);
            // 
            // QReadersBook
            // 
            this.QReadersBook.Location = new System.Drawing.Point(601, 198);
            this.QReadersBook.Name = "QReadersBook";
            this.QReadersBook.Size = new System.Drawing.Size(151, 23);
            this.QReadersBook.TabIndex = 4;
            this.QReadersBook.Text = "Читатели книги";
            this.QReadersBook.UseVisualStyleBackColor = true;
            this.QReadersBook.Click += new System.EventHandler(this.QReadersBook_Click);
            // 
            // QHolderBooksR
            // 
            this.QHolderBooksR.Location = new System.Drawing.Point(601, 227);
            this.QHolderBooksR.Name = "QHolderBooksR";
            this.QHolderBooksR.Size = new System.Drawing.Size(151, 43);
            this.QHolderBooksR.TabIndex = 4;
            this.QHolderBooksR.Text = "Рекордсмен по количеству книг";
            this.QHolderBooksR.UseVisualStyleBackColor = true;
            this.QHolderBooksR.Click += new System.EventHandler(this.QHolderBooksR_Click);
            // 
            // QReadersYear
            // 
            this.QReadersYear.Location = new System.Drawing.Point(601, 276);
            this.QReadersYear.Name = "QReadersYear";
            this.QReadersYear.Size = new System.Drawing.Size(151, 23);
            this.QReadersYear.TabIndex = 4;
            this.QReadersYear.Text = "Читатели за год";
            this.QReadersYear.UseVisualStyleBackColor = true;
            this.QReadersYear.Click += new System.EventHandler(this.QReadersYear_Click);
            // 
            // QBooksOut
            // 
            this.QBooksOut.Location = new System.Drawing.Point(601, 305);
            this.QBooksOut.Name = "QBooksOut";
            this.QBooksOut.Size = new System.Drawing.Size(151, 23);
            this.QBooksOut.TabIndex = 4;
            this.QBooksOut.Text = "Книги на руках";
            this.QBooksOut.UseVisualStyleBackColor = true;
            this.QBooksOut.Click += new System.EventHandler(this.QBooksOut_Click);
            // 
            // QBooksIn
            // 
            this.QBooksIn.Location = new System.Drawing.Point(601, 334);
            this.QBooksIn.Name = "QBooksIn";
            this.QBooksIn.Size = new System.Drawing.Size(151, 23);
            this.QBooksIn.TabIndex = 4;
            this.QBooksIn.Text = "Книги в наличии";
            this.QBooksIn.UseVisualStyleBackColor = true;
            this.QBooksIn.Click += new System.EventHandler(this.QBooksIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Результат выполнения:";
            // 
            // QueryResult
            // 
            this.QueryResult.BackColor = System.Drawing.SystemColors.Window;
            this.QueryResult.Location = new System.Drawing.Point(601, 392);
            this.QueryResult.Name = "QueryResult";
            this.QueryResult.ReadOnly = true;
            this.QueryResult.Size = new System.Drawing.Size(151, 20);
            this.QueryResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Аргумент:";
            // 
            // ArgumentInput
            // 
            this.ArgumentInput.BackColor = System.Drawing.SystemColors.Window;
            this.ArgumentInput.Location = new System.Drawing.Point(601, 109);
            this.ArgumentInput.Name = "ArgumentInput";
            this.ArgumentInput.Size = new System.Drawing.Size(151, 20);
            this.ArgumentInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(598, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Отсортировать:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Параметр сортировки:";
            // 
            // SortParam
            // 
            this.SortParam.FormattingEnabled = true;
            this.SortParam.Items.AddRange(new object[] {
            "Holder",
            "IssueDate",
            "BookName",
            "Cost",
            "Present"});
            this.SortParam.Location = new System.Drawing.Point(601, 484);
            this.SortParam.Name = "SortParam";
            this.SortParam.Size = new System.Drawing.Size(151, 21);
            this.SortParam.TabIndex = 6;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(601, 539);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(151, 23);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Отсортировать";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Запросы:";
            // 
            // DropFilters
            // 
            this.DropFilters.Location = new System.Drawing.Point(366, 14);
            this.DropFilters.Name = "DropFilters";
            this.DropFilters.Size = new System.Drawing.Size(210, 23);
            this.DropFilters.TabIndex = 4;
            this.DropFilters.Text = "Снять фильтрацию и сортировку";
            this.DropFilters.UseVisualStyleBackColor = true;
            this.DropFilters.Click += new System.EventHandler(this.DropFilters_Click);
            // 
            // ReverseResults
            // 
            this.ReverseResults.AutoSize = true;
            this.ReverseResults.Location = new System.Drawing.Point(614, 514);
            this.ReverseResults.Name = "ReverseResults";
            this.ReverseResults.Size = new System.Drawing.Size(122, 17);
            this.ReverseResults.TabIndex = 7;
            this.ReverseResults.Text = "Обратный порядок";
            this.ReverseResults.UseVisualStyleBackColor = true;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 596);
            this.Controls.Add(this.ReverseResults);
            this.Controls.Add(this.SortParam);
            this.Controls.Add(this.ArgumentInput);
            this.Controls.Add(this.QueryResult);
            this.Controls.Add(this.QHolderBooksR);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.QBooksIn);
            this.Controls.Add(this.QBooksOut);
            this.Controls.Add(this.QReadersYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QReadersBook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DropFilters);
            this.Controls.Add(this.QBooksReader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewForm";
            this.Text = "Библиотека (вход совершён как {0})";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewForm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView Viewer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QBooksReader;
        private System.Windows.Forms.Button QReadersBook;
        private System.Windows.Forms.Button QHolderBooksR;
        private System.Windows.Forms.Button QReadersYear;
        private System.Windows.Forms.Button QBooksOut;
        private System.Windows.Forms.Button QBooksIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QueryResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ArgumentInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SortParam;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DropFilters;
        private System.Windows.Forms.CheckBox ReverseResults;
    }
}