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
    public partial class ViewForm : Form
    {
        private LoginForm _caller;
        private int _lastIndexClicked;
        private bool _queried = false;

        public ViewForm(LoginForm caller)
        {
            InitializeComponent();
            _caller = caller;
        }

        List<Book> data;

        public ViewForm(string login, LoginForm caller)
        {
            InitializeComponent();
            _caller = caller;
            StatusBar.Text = $"Приветствую, {login}";
            Text = String.Format(Text, login);
            // Viewer.
            data = InitData();
            Viewer.DataSource = data;
            label1.Text = $"Записей в базе: {data.Count}";
        }

        public override void Refresh()
        {
            Viewer.DataSource = null;
            Viewer.DataSource = data;
            label1.Text = $"Записей в базе: {data.Count}";
        }

        private List<Book> InitData()
        {
            List<Book> data = new List<Book>();

            data.Add(new Book("Олег", DateTime.Now, "Олег и Олег", 500.0, true));
            data.Add(new Book("Андрей", new DateTime(2005, 3, 12), "Сокровища в океане", 29.99, true));
            data.Add(new Book("Екатерина", new DateTime(2010, 7, 1), "Зов предков", 14.5, false));
            data.Add(new Book("Николай", new DateTime(1998, 11, 5), "Тайны старого особняка", 42.75, true));
            data.Add(new Book("Ольга", new DateTime(2003, 9, 22), "Последний эльф", 18.99, false));
            data.Add(new Book("Иван", new DateTime(2015, 5, 9), "Время перемен", 9.99, true));
            data.Add(new Book("Мария", new DateTime(2007, 2, 14), "Тайна проклятого замка", 35.25, false));
            data.Add(new Book("Александр", new DateTime(2012, 12, 30), "Охота на драконов", 28.75, true));
            data.Add(new Book("Елена", new DateTime(1995, 8, 8), "Секреты алхимика", 12.99, false));
            data.Add(new Book("Дмитрий", new DateTime(2001, 6, 17), "Королевские интриги", 19.5, true));
            data.Add(new Book("Анна", new DateTime(2009, 4, 3), "Загадочный остров", 24.99, false));
            data.Add(new Book("Сергей", new DateTime(1993, 10, 28), "Путь волшебника", 9.75, true));
            data.Add(new Book("Татьяна", new DateTime(2017, 1, 19), "Танец с драконом", 15.99, false));
            data.Add(new Book("Максим", new DateTime(2008, 7, 9), "Похищение принцессы", 31.5, true));
            data.Add(new Book("Ирина", new DateTime(2004, 11, 14), "Магический артефакт", 11.25, false));
            data.Add(new Book("Владимир", new DateTime(1999, 9, 4), "Путешествие во времени", 39.99, true));
            data.Add(new Book("Алиса", new DateTime(2014, 5, 30), "Запретный лес", 17.75, false));
            data.Add(new Book("Павел", new DateTime(1997, 12, 10), "Тайна забытого города", 22.5, true));
            data.Add(new Book("Оксана", new DateTime(2002, 10, 1), "Призрак в монастыре", 7.99, false));
            data.Add(new Book("Павел", new DateTime(2016, 6, 15), "Секреты прошлого", 34.25, true));
            data.Add(new Book("Людмила", new DateTime(2006, 3, 5), "Книга судьбы", 13.5, false));
            data.Add(new Book("Григорий", new DateTime(2011, 8, 20), "Охота на сокровища", 27.99, true));
            data.Add(new Book("Яна", new DateTime(1996, 4, 23), "Символы силы", 10.75, false));
            data.Add(new Book("Михаил", new DateTime(2013, 11, 9), "Путешествие в иное измерение", 37.99, true));
            data.Add(new Book("Лариса", new DateTime(2000, 9, 18), "Тайна красного фонаря", 16.25, false));
            data.Add(new Book("Артем", new DateTime(2009, 2, 7), "Последний герой", 29.5, true));
            data.Add(new Book("Инна", new DateTime(2005, 10, 24), "Загадочный амулет", 8.99, false));
            data.Add(new Book("Алексей", new DateTime(1998, 6, 14), "Секреты туманного замка", 33.25, true));
            data.Add(new Book("Наталья", new DateTime(2014, 1, 31), "Ключ от прошлого", 12.5, false));
            data.Add(new Book("Валерий", new DateTime(2001, 7, 25), "Скрытый мир вампиров", 19.99, true));
            data.Add(new Book("Елизавета", new DateTime(1994, 5, 11), "Тайна заброшенной усадьбы", 23.75, false));
            data.Add(new Book("Андрей", new DateTime(2006, 3, 19), "Затерянный артефакт", 9.5, true));
            data.Add(new Book("Екатерина", new DateTime(2010, 9, 7), "Секреты монастыря", 36.99, false));
            data.Add(new Book("Николай", new DateTime(1999, 11, 2), "Магия зеркал", 15.25, true));
            data.Add(new Book("Ольга", new DateTime(2004, 8, 16), "Тайны города призраков", 42.5, false));
            data.Add(new Book("Иван", new DateTime(2015, 6, 4), "Погоня за сокровищами", 11.99, true));
            data.Add(new Book("Мария", new DateTime(2007, 2, 27), "Секреты древнего свитка", 26.75, false));
            data.Add(new Book("Александр", new DateTime(2012, 12, 13), "Тайна проклятого замка", 7.5, true));
            data.Add(new Book("Елена", new DateTime(1996, 9, 24), "Путешествие в потусторонний мир", 32.99, false));
            data.Add(new Book("Дмитрий", new DateTime(2002, 7, 10), "Охота на фантомного убийцу", 13.25, true));
            data.Add(new Book("Анна", new DateTime(2009, 5, 2), "Загадочные истории старого особняка", 18.5, false));
            data.Add(new Book("Сергей", new DateTime(1993, 11, 28), "Тайна золотого амулета", 39.75, true));
            data.Add(new Book("Татьяна", new DateTime(2017, 2, 12), "Магический лабиринт", 14.99, false));
            data.Add(new Book("Максим", new DateTime(2008, 8, 29), "Проклятие черной розы", 30.25, true));
            data.Add(new Book("Ирина", new DateTime(2004, 11, 17), "Таинственный ключ", 10.5, false));
            data.Add(new Book("Владимир", new DateTime(1999, 10, 9), "Подземный мир", 37.99, true));
            data.Add(new Book("Алиса", new DateTime(2014, 6, 22), "Забытые тайны древней цивилизации", 16.75, false));
            data.Add(new Book("Роман", new DateTime(1997, 12, 7), "Секреты заброшенного замка", 22.99, true));
            data.Add(new Book("Оксана", new DateTime(2002, 11, 18), "Мистерия магической книги", 9.25, false));
            data.Add(new Book("Павел", new DateTime(2016, 7, 5), "Тайны запретного острова", 34.5, true));
            data.Add(new Book("Людмила", new DateTime(2005, 1, 30), "Похищение принца", 11.99, false));

            return data;
        }

        private void ViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _caller.Show();
        }

        private void Viewer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_queried) { return; }
            contextMenuStrip1.Show(this, e.Location);
            _lastIndexClicked = e.RowIndex;
        }

        public void EditEntry(int entryIndex, Book newValue)
        {
            data[entryIndex] = newValue;
            Refresh();
        }

        public void DelEntry(int entryIndex)
        {
            Console.WriteLine(data.Count);
            data = data.Take(entryIndex).Concat(data.Skip(entryIndex + 1)).ToList();
            Refresh();
        }

        public void AddEntry(Book newValue)
        {
            data.Add(newValue);
            Refresh();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor(_lastIndexClicked, ((List<Book>)Viewer.DataSource)[_lastIndexClicked], this);
            editor.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelEntry(_lastIndexClicked);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor(this);
            editor.Show();
        }

        private void QBooksReader_Click(object sender, EventArgs e)
        {
            string reader = ArgumentInput.Text;
            if (string.IsNullOrEmpty(reader))
            {
                MessageBox.Show("Отсутствует аргумент для расчёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Viewer.DataSource = data
                .Where(b => b.Holder == reader)
                .ToList();
            _queried = true;
            QueryResult.Text = "< Запрос выполнен";
        }

        private void DropFilters_Click(object sender, EventArgs e)
        {
            Refresh();
            _queried = false;
            QueryResult.Text = "Фильтр сброшен";
        }
        
        internal class NameView
        {

            public string Name
            {
                get;
            }

            public NameView(string name)
            {
                Name = name;
            }
        }

        private void QReadersBook_Click(object sender, EventArgs e)
        {
            string book = ArgumentInput.Text;
            if (string.IsNullOrEmpty(book))
            {
                MessageBox.Show("Отсутствует аргумент для расчёта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> res = data
                .Where(b => b.BookName == book)
                .Select(b => b.Holder)
                .ToList();
            List<NameView> rest = new List<NameView>();
            foreach (string name in res)
            {
                Console.WriteLine(name);
                rest.Add(new NameView(name));
            }
            Viewer.DataSource = rest;
            _queried = true;
            QueryResult.Text = "< Запрос выполнен";
        }

        private void QHolderBooksR_Click(object sender, EventArgs e)
        {
            string holderWithMostBooks = data
            .GroupBy(b => b.Holder)
            .OrderByDescending(g => g.Count())
            .FirstOrDefault()?.Key;
            QueryResult.Text = holderWithMostBooks;
        }

        private void QReadersYear_Click(object sender, EventArgs e)
        {
            try { int x = int.Parse(ArgumentInput.Text); }
            catch { MessageBox.Show("Некорректное значение аргумента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            int year = int.Parse(ArgumentInput.Text);
            if (year < 1900)
            {
                MessageBox.Show("Некорректное значение аргумента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Book> res = data.Where(b => b.IssueDate.Year == year).ToList();
            List<NameView> rest = new List<NameView>();
            foreach (Book b in res)
            {
                Console.WriteLine(b.Holder);
                rest.Add(new NameView(b.Holder));
            }

            Viewer.DataSource = rest.ToList();
            _queried = true;
            QueryResult.Text = "< Запрос выполнен";
        }

        private void QBooksOut_Click(object sender, EventArgs e)
        {
            Viewer.DataSource = data.Where(b => !b.Present).ToList();
            _queried = true;
            QueryResult.Text = "< Запрос выполнен";
        }

        private void QBooksIn_Click(object sender, EventArgs e)
        {
            Viewer.DataSource = data.Where(b => b.Present).ToList();
            _queried = true;
            QueryResult.Text = "< Запрос выполнен";
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string sortParam = SortParam.Text;
            bool rr = !ReverseResults.Checked;
            QueryResult.Text = "< Отсортировано";

            switch (sortParam)
            {
                case "Holder":
                    Viewer.DataSource = rr? data.OrderBy(b => b.Holder).ToList() : data.OrderByDescending(b => b.Holder).ToList();
                    return;
                case "IssueDate":
                    Viewer.DataSource = rr? data.OrderBy(b => b.IssueDate).ToList() : data.OrderByDescending(b => b.IssueDate).ToList();
                    return;
                case "BookName":
                    Viewer.DataSource = rr? data.OrderBy(b => b.BookName).ToList() : data.OrderByDescending(b => b.BookName).ToList();
                    return;
                case "Cost":
                    Viewer.DataSource = rr? data.OrderBy(b => b.Cost).ToList() : data.OrderByDescending(b => b.Cost).ToList();
                    return;
                case "Present":
                    Viewer.DataSource = rr? data.OrderBy(b => b.Present).ToList() : data.OrderByDescending(b => b.Present).ToList();
                    return;
                default:
                    MessageBox.Show("Некорректный парметр сортировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
    }
}
