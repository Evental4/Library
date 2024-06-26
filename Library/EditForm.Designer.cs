﻿namespace Library
{
    partial class EditForm
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePupiyshDateTimePiker = new System.Windows.Forms.DateTimePicker();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "НАЗВАНИЕ КНИГИ";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.TitleTextBox.Location = new System.Drawing.Point(13, 30);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(353, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год Издания";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.AuthorTextBox.Location = new System.Drawing.Point(13, 82);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(353, 20);
            this.AuthorTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "АВТОР/ХУДОЖНИК\r\n";
            // 
            // datePupiyshDateTimePiker
            // 
            this.datePupiyshDateTimePiker.CustomFormat = "yyyy";
            this.datePupiyshDateTimePiker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "DatePublished", true));
            this.datePupiyshDateTimePiker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePupiyshDateTimePiker.Location = new System.Drawing.Point(16, 140);
            this.datePupiyshDateTimePiker.Name = "datePupiyshDateTimePiker";
            this.datePupiyshDateTimePiker.Size = new System.Drawing.Size(47, 20);
            this.datePupiyshDateTimePiker.TabIndex = 7;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(12, 187);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(151, 45);
            this.OkButton.TabIndex = 8;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(206, 187);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(149, 45);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Library.Book);
            // 
            // EditForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.datePupiyshDateTimePiker);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редокирование книге";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePupiyshDateTimePiker;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.BindingSource bookBindingSource;
    }
}