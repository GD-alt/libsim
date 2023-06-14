using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private Book _entry = null;
        private ViewForm _caller;
        private bool _edited;

        public Editor(int RowNum, Book entry, ViewForm caller)
        {
            InitializeComponent();
            EntryNum.Text = RowNum.ToString();
            _entry = entry;
            UIEHolder.Text = entry.Holder;
            UIEIssueDate.Text = entry.IssueDate.ToString();
            UIEBookName.Text = entry.BookName;
            UIECost.Text = entry.Cost.ToString();
            UIEIfPresent.Checked = entry.Present;
            _caller = caller;
            _edited = true;
            _caller.Hide();
        }

        public Editor(ViewForm caller)
        {
            InitializeComponent();
            SaveAndClose.Hide();
            EntrySaveButton.Size = new Size(313, 23);
            EntryNum.Hide();
            label1.Text = "Вы добавляете новую запись";
            _caller = caller;
            _edited = false;
            _caller.Hide();
        }

        private void NoSaveClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EntrySaveButton_Click(object sender, EventArgs e)
        {
            if (_entry == null) { _entry = new Book("U", DateTime.Now, "T", 55.77, true); }
            _entry.Holder = UIEHolder.Text;
            try { _entry.IssueDate = DateTime.Parse(UIEIssueDate.Text); }
            catch { MessageBox.Show("Неверный формат даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            _entry.BookName = UIEBookName.Text;

            try { _entry.Cost = double.Parse(UIECost.Text); if (_entry.Cost < 1) { throw new Exception(); } }
            catch { MessageBox.Show("Неверный формат числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            _entry.Present = UIEIfPresent.Checked;
            if (_edited) { _caller.EditEntry(int.Parse(EntryNum.Text), _entry); }
            else { _caller.AddEntry(_entry); _caller.Show(); MessageBox.Show("Успешно сохранено!", "Успех", MessageBoxButtons.OK); Close(); return; }
            MessageBox.Show("Успешно сохранено!", "Успех", MessageBoxButtons.OK);
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            _caller.Show();
        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            _entry.Holder = UIEHolder.Text;
            try { _entry.IssueDate = DateTime.Parse(UIEIssueDate.Text); }
            catch { MessageBox.Show("Неверный формат даты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            _entry.BookName = UIEBookName.Text;

            try { _entry.Cost = double.Parse(UIECost.Text); if (_entry.Cost < 1) { throw new Exception(); } }
            catch { MessageBox.Show("Неверный формат числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            _entry.Present = UIEIfPresent.Checked;
            _caller.EditEntry(int.Parse(EntryNum.Text), _entry);
            _caller.Show();
            MessageBox.Show("Успешно сохранено!", "Успех", MessageBoxButtons.OK);
            Close();
        }
    }
}
