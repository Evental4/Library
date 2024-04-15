using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        private List<Book> books = new List<Book>();
        private bool visebsalContexMene = false;
        private object dataGridViewBooks;

        public MainForm()
        {
            InitializeComponent();
        }
        // Книги
        private void InitTestBookData()
        {
            books.Add(new Book("Войти и мир", "Лев Николаевич Толстой", DateTime.Parse("1867-01-01")));
            books.Add(new Book("Анна Каренина", "Лев Николаевич Толстой", DateTime.Parse("1877-01-01")));
            books.Add(new Book("Победа бала", "Лев Николаевич Толстой", DateTime.Parse("1911-01-01")));
            books.Add(new Book("Юность", "Лев Николаевич Толстой", DateTime.Parse("1857-01-01")));
            books.Add(new Book("Кавказский пленник", "Александ Сергеивич Пушкин", DateTime.Parse("1872-01-01")));
            books.Add(new Book("Пиковая дама", "Александ Сергеивич Пушкин", DateTime.Parse("1834-01-01")));
            books.Add(new Book("Евгений Онегин", "Александ Сергеивич Пушкин", DateTime.Parse("1833-01-01")));
            books.Add(new Book("Магический стрелок", "Ли Субэк Сяимель", DateTime.Parse("2021-01-01")));
            books.Add(new Book("Нос", "Николай Васильевич Гоголь", DateTime.Parse("1836-01-01")));
            books.Add(new Book("Мертвые души", "Николай Васильевич Гоголь", DateTime.Parse("1842-01-01")));
            books.Add(new Book("Тарас Бульба", "Николай Васильевич Гоголь", DateTime.Parse("1835-01-01")));
        }
        // масив
        private List<Book> GetFilteredBook()
        {
            List<Book> result = new List<Book>();
            string Searshbook = TextBoxSearsh.Text;

            if (Searshbook.Length == 0)
            {
                return books;
            }
            Searshbook = Searshbook.ToLower();
            foreach (Book book in books)
            {
                if (book.Title.Length > 0 && book.Title.ToLower().Contains(Searshbook) ||
                   book.Author.Length > 0 && book.Author.ToLower().Contains(Searshbook) ||
                   book.YearPublished.Length > 0 && book.YearPublished.Contains(Searshbook))
                {
                    result.Add(book);
                }

            }
            return result;
        }
        //Расположения в таблице
        private void RefreshDateGridView()
        {
            DataGridViewBooks.DataSource = null;
            DataGridViewBooks.DataSource = GetFilteredBook();

            DataGridViewBooks.Columns["Title"].HeaderText = "Название";
            DataGridViewBooks.Columns["Title"].Width = 250;

            DataGridViewBooks.Columns["Author"].HeaderText = "Автор";
            DataGridViewBooks.Columns["Author"].Width = 250;

            DataGridViewBooks.Columns["DatePublished"].HeaderText = "Дата издания";
            DataGridViewBooks.Columns["DatePublished"].Width = 200;
            DataGridViewBooks.Columns["DatePublished"].Visible = false;

            DataGridViewBooks.Columns["YearPublished"].HeaderText = "Год публикации";
            DataGridViewBooks.Columns["YearPublished"].Width = 200;
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitTestBookData();
            RefreshDateGridView();
            UpDateBooks();
        }
        //ОБНОВЛЕНИЕ КНИГ
        private void UpDateBooks()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Books: [\r\n");
            foreach (Book book in books)
            {
                sb.Append(book.ToString());
                sb.Append("\r\n");
            }
            sb.Append("]");

            BookTextBox.Text = sb.ToString();
        }
        //ДОБАВИТЬ КНИГУ
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            DateTime selecteDate = DatePupiyshDateTimePiker.Value;
            DateTime yearDate = DateTime.Parse(selecteDate.ToString("dd.MM.yyyy"));

            Book newBook = new Book(TitolTextBox.Text, AutorTextBox.Text, yearDate);

            books.Add(newBook);

            UpDateBooks();
            RefreshDateGridView();

            TitolTextBox.Text = "";
            AutorTextBox.Text = "";
            DatePupiyshDateTimePiker.Value = DateTime.Now;

            TitolTextBox.Focus();
        }

        private void DataGridViewBooks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            DataGridViewCell cell = DataGridViewBooks[col, row];

            object cellValue = cell.Value;

            Book book = books[row];
            switch (col)
            {
                case 0:
                    book.Title = (string)cellValue;
                    break;
                case 1:
                    book.Author = (string)cellValue;
                    break;
                case 2:
                    book.DatePublished = (DateTime)cellValue;
                    break;

            }
            RefreshDateGridView();
        }

        private void DataGridViewBooks_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var testInfo = DataGridViewBooks.HitTest(e.X, e.Y);
                if (testInfo.RowIndex >= 0 && testInfo.ColumnIndex >= 0)
                {
                    DataGridViewBooks.ClearSelection();
                    DataGridViewBooks.Rows[testInfo.RowIndex].Selected = true;
                    visebsalContexMene = false;
                }
                else
                { visebsalContexMene = true; }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (visebsalContexMene)
            {
                e.Cancel = true;
            }

        }
        //РЕДАКТИРОВАНИЯ КАРТИНОК
        private void StripMenuItemEditBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndedex = selectedRow.Index;

                Book book = books[rowIndedex];

                EditForm editForm = new EditForm();
                editForm.EditBook = book;
                editForm.BookUpdateEvent += EditForm_BookUpdateEvent;
                editForm.ShowDialog();
            }
        }
        //ОБНОВ.РЕДАКТИРОВАНИЯ КАРТИНОК
        private void EditForm_BookUpdateEvent(Book updateBook)
        {
            RefreshDateGridView();
        }
        // ПОИСК
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDateGridView();
        }
        //УДАЛЕНИЕ КАРТИНОК
        private void StripMenuItemDeletBook_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DataGridViewBooks.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndedex = selectedRow.Index;

                Book book = books[rowIndedex];

                DialogResult dlg = MessageBox.Show("Удалить книгу:\r\n\rАвтор:" + book.Author + "\r\nНазвание:" + book.Title + 
                    "\r\nГод публикации:" + book.YearPublished,"Подвердите",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes) 
                {
                    books.RemoveAt(rowIndedex);
                }
                RefreshDateGridView();
            }
        }
    }

}

