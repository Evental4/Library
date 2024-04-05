using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public MainForm()
        {
            InitializeComponent();
         
        }

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
                if (book.Title.ToLower().Contains(Searshbook))
                {
                    result.Add(book);
                }

            }
            return result;
        }
            
        private void RefreshDateGridView()
        {
            DataGridViewBooks.DataSource = null;
            DataGridViewBooks.DataSource = GetFilteredBook();

            DataGridViewBooks.Columns["Title"].HeaderText = "Название";
            DataGridViewBooks.Columns["Title"].Width = 150;

            DataGridViewBooks.Columns["Author"].HeaderText = "Автор";
            DataGridViewBooks.Columns["Author"].Width = 200;

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

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDateGridView();
        }

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

    }
}
