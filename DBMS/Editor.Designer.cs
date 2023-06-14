namespace DBMS
{
    partial class Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.EntryNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UIEHolder = new System.Windows.Forms.TextBox();
            this.UIEIssueDate = new System.Windows.Forms.TextBox();
            this.UIEBookName = new System.Windows.Forms.TextBox();
            this.UIECost = new System.Windows.Forms.TextBox();
            this.UIEIfPresent = new System.Windows.Forms.CheckBox();
            this.EntrySaveButton = new System.Windows.Forms.Button();
            this.SaveAndClose = new System.Windows.Forms.Button();
            this.NoSaveClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вы редактируете запись под номером";
            // 
            // EntryNum
            // 
            this.EntryNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EntryNum.Enabled = false;
            this.EntryNum.Location = new System.Drawing.Point(231, 20);
            this.EntryNum.Name = "EntryNum";
            this.EntryNum.Size = new System.Drawing.Size(55, 20);
            this.EntryNum.TabIndex = 2;
            this.EntryNum.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Держатель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Дата обращения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Название книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "В наличии";
            // 
            // UIEHolder
            // 
            this.UIEHolder.Location = new System.Drawing.Point(101, 59);
            this.UIEHolder.Name = "UIEHolder";
            this.UIEHolder.Size = new System.Drawing.Size(231, 20);
            this.UIEHolder.TabIndex = 0;
            // 
            // UIEIssueDate
            // 
            this.UIEIssueDate.Location = new System.Drawing.Point(115, 105);
            this.UIEIssueDate.Name = "UIEIssueDate";
            this.UIEIssueDate.Size = new System.Drawing.Size(217, 20);
            this.UIEIssueDate.TabIndex = 1;
            // 
            // UIEBookName
            // 
            this.UIEBookName.Location = new System.Drawing.Point(111, 151);
            this.UIEBookName.Name = "UIEBookName";
            this.UIEBookName.Size = new System.Drawing.Size(221, 20);
            this.UIEBookName.TabIndex = 2;
            // 
            // UIECost
            // 
            this.UIECost.Location = new System.Drawing.Point(101, 198);
            this.UIECost.Name = "UIECost";
            this.UIECost.Size = new System.Drawing.Size(231, 20);
            this.UIECost.TabIndex = 3;
            // 
            // UIEIfPresent
            // 
            this.UIEIfPresent.AutoSize = true;
            this.UIEIfPresent.Location = new System.Drawing.Point(101, 241);
            this.UIEIfPresent.Name = "UIEIfPresent";
            this.UIEIfPresent.Size = new System.Drawing.Size(15, 14);
            this.UIEIfPresent.TabIndex = 4;
            this.UIEIfPresent.UseVisualStyleBackColor = true;
            // 
            // EntrySaveButton
            // 
            this.EntrySaveButton.Location = new System.Drawing.Point(19, 276);
            this.EntrySaveButton.Name = "EntrySaveButton";
            this.EntrySaveButton.Size = new System.Drawing.Size(122, 23);
            this.EntrySaveButton.TabIndex = 5;
            this.EntrySaveButton.Text = "Сохранить запись";
            this.EntrySaveButton.UseVisualStyleBackColor = true;
            this.EntrySaveButton.Click += new System.EventHandler(this.EntrySaveButton_Click);
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.Location = new System.Drawing.Point(147, 276);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(185, 23);
            this.SaveAndClose.TabIndex = 6;
            this.SaveAndClose.Text = "Сохранить запись и закрыть";
            this.SaveAndClose.UseVisualStyleBackColor = true;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // NoSaveClose
            // 
            this.NoSaveClose.Location = new System.Drawing.Point(19, 302);
            this.NoSaveClose.Name = "NoSaveClose";
            this.NoSaveClose.Size = new System.Drawing.Size(313, 23);
            this.NoSaveClose.TabIndex = 7;
            this.NoSaveClose.Text = "Закрыть без сохранения";
            this.NoSaveClose.UseVisualStyleBackColor = true;
            this.NoSaveClose.Click += new System.EventHandler(this.NoSaveClose_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 337);
            this.Controls.Add(this.NoSaveClose);
            this.Controls.Add(this.SaveAndClose);
            this.Controls.Add(this.EntrySaveButton);
            this.Controls.Add(this.UIEIfPresent);
            this.Controls.Add(this.UIECost);
            this.Controls.Add(this.UIEBookName);
            this.Controls.Add(this.UIEIssueDate);
            this.Controls.Add(this.UIEHolder);
            this.Controls.Add(this.EntryNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Editor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EntryNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UIEHolder;
        private System.Windows.Forms.TextBox UIEIssueDate;
        private System.Windows.Forms.TextBox UIEBookName;
        private System.Windows.Forms.TextBox UIECost;
        private System.Windows.Forms.CheckBox UIEIfPresent;
        private System.Windows.Forms.Button EntrySaveButton;
        private System.Windows.Forms.Button SaveAndClose;
        private System.Windows.Forms.Button NoSaveClose;
    }
}