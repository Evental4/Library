namespace Library
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StripMenuItemDeletBook = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuItemEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxSearsh = new System.Windows.Forms.TextBox();
            this.BookTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TitolTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AutorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePupiyshDateTimePiker = new System.Windows.Forms.DateTimePicker();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItemDeletBook,
            this.StripMenuItemEditBook});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // StripMenuItemDeletBook
            // 
            this.StripMenuItemDeletBook.Name = "StripMenuItemDeletBook";
            this.StripMenuItemDeletBook.Size = new System.Drawing.Size(189, 22);
            this.StripMenuItemDeletBook.Text = "Удалить книгу";
            // 
            // StripMenuItemEditBook
            // 
            this.StripMenuItemEditBook.Name = "StripMenuItemEditBook";
            this.StripMenuItemEditBook.Size = new System.Drawing.Size(189, 22);
            this.StripMenuItemEditBook.Text = "Редоктировать книгу";
            // 
            // DataGridViewBooks
            // 
            this.DataGridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBooks.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridViewBooks.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridViewBooks.Location = new System.Drawing.Point(29, 51);
            this.DataGridViewBooks.Name = "DataGridViewBooks";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewBooks.Size = new System.Drawing.Size(619, 391);
            this.DataGridViewBooks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск\r\n";
            // 
            // TextBoxSearsh
            // 
            this.TextBoxSearsh.Location = new System.Drawing.Point(71, 12);
            this.TextBoxSearsh.Name = "TextBoxSearsh";
            this.TextBoxSearsh.Size = new System.Drawing.Size(674, 20);
            this.TextBoxSearsh.TabIndex = 3;
            // 
            // BookTextBox
            // 
            this.BookTextBox.Location = new System.Drawing.Point(664, 51);
            this.BookTextBox.Multiline = true;
            this.BookTextBox.Name = "BookTextBox";
            this.BookTextBox.ReadOnly = true;
            this.BookTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BookTextBox.Size = new System.Drawing.Size(311, 401);
            this.BookTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBookButton);
            this.groupBox1.Controls.Add(this.DatePupiyshDateTimePiker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AutorTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TitolTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить новую книгу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // TitolTextBox
            // 
            this.TitolTextBox.Location = new System.Drawing.Point(70, 30);
            this.TitolTextBox.Name = "TitolTextBox";
            this.TitolTextBox.Size = new System.Drawing.Size(229, 20);
            this.TitolTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор\r\n";
            // 
            // AutorTextBox
            // 
            this.AutorTextBox.Location = new System.Drawing.Point(350, 30);
            this.AutorTextBox.Name = "AutorTextBox";
            this.AutorTextBox.Size = new System.Drawing.Size(229, 20);
            this.AutorTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Год поблюкации";
            // 
            // DatePupiyshDateTimePiker
            // 
            this.DatePupiyshDateTimePiker.CustomFormat = "yyyy";
            this.DatePupiyshDateTimePiker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePupiyshDateTimePiker.Location = new System.Drawing.Point(680, 30);
            this.DatePupiyshDateTimePiker.Name = "DatePupiyshDateTimePiker";
            this.DatePupiyshDateTimePiker.Size = new System.Drawing.Size(47, 20);
            this.DatePupiyshDateTimePiker.TabIndex = 5;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(735, 30);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(203, 23);
            this.AddBookButton.TabIndex = 6;
            this.AddBookButton.Text = "Добавить книгу";
            this.AddBookButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BookTextBox);
            this.Controls.Add(this.TextBoxSearsh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemDeletBook;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItemEditBook;
        private System.Windows.Forms.DataGridView DataGridViewBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSearsh;
        private System.Windows.Forms.TextBox BookTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatePupiyshDateTimePiker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AutorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitolTextBox;
        private System.Windows.Forms.Button AddBookButton;
    }
}

