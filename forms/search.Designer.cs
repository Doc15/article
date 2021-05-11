
namespace articles.forms
{
    partial class search
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
            this.refresh = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.articleBox = new System.Windows.Forms.TextBox();
            this.tagBox = new System.Windows.Forms.TextBox();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.catBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            this.toSearch = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(1396, 537);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 34);
            this.refresh.TabIndex = 40;
            this.refresh.Text = "Вернуть";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(109, 184);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(400, 26);
            this.date.TabIndex = 39;
            // 
            // articleBox
            // 
            this.articleBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleBox.Location = new System.Drawing.Point(109, 278);
            this.articleBox.Multiline = true;
            this.articleBox.Name = "articleBox";
            this.articleBox.Size = new System.Drawing.Size(400, 250);
            this.articleBox.TabIndex = 38;
            // 
            // tagBox
            // 
            this.tagBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagBox.Location = new System.Drawing.Point(109, 230);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(400, 26);
            this.tagBox.TabIndex = 37;
            // 
            // authorBox
            // 
            this.authorBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorBox.Location = new System.Drawing.Point(109, 145);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(400, 26);
            this.authorBox.TabIndex = 36;
            // 
            // catBox
            // 
            this.catBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catBox.Location = new System.Drawing.Point(109, 104);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(400, 26);
            this.catBox.TabIndex = 35;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleBox.Location = new System.Drawing.Point(109, 67);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(400, 26);
            this.titleBox.TabIndex = 34;
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDbox.Location = new System.Drawing.Point(109, 23);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(400, 26);
            this.IDbox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Тег";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Статья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.title,
            this.cat,
            this.author,
            this.article,
            this.date1,
            this.tag});
            this.dataGridView1.Location = new System.Drawing.Point(545, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 472);
            this.dataGridView1.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.FillWeight = 35.53299F;
            this.Id.HeaderText = "№";
            this.Id.Name = "Id";
            // 
            // title
            // 
            this.title.FillWeight = 110.7445F;
            this.title.HeaderText = "Название";
            this.title.Name = "title";
            // 
            // cat
            // 
            this.cat.FillWeight = 110.7445F;
            this.cat.HeaderText = "Категория";
            this.cat.Name = "cat";
            // 
            // author
            // 
            this.author.FillWeight = 110.7445F;
            this.author.HeaderText = "Автор";
            this.author.Name = "author";
            // 
            // article
            // 
            this.article.FillWeight = 110.7445F;
            this.article.HeaderText = "Статья";
            this.article.Name = "article";
            // 
            // date1
            // 
            this.date1.FillWeight = 110.7445F;
            this.date1.HeaderText = "Дата";
            this.date1.Name = "date1";
            // 
            // tag
            // 
            this.tag.FillWeight = 110.7445F;
            this.tag.HeaderText = "Тег";
            this.tag.Name = "tag";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(15, 537);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(83, 34);
            this.back.TabIndex = 24;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            // 
            // toSearch
            // 
            this.toSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toSearch.Location = new System.Drawing.Point(546, 24);
            this.toSearch.Name = "toSearch";
            this.toSearch.Size = new System.Drawing.Size(844, 25);
            this.toSearch.TabIndex = 23;
            // 
            // searchBut
            // 
            this.searchBut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBut.Location = new System.Drawing.Point(1396, 19);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(75, 31);
            this.searchBut.TabIndex = 22;
            this.searchBut.Text = "Найти";
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 588);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.date);
            this.Controls.Add(this.articleBox);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.catBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.toSearch);
            this.Controls.Add(this.searchBut);
            this.Name = "search";
            this.Text = "search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox articleBox;
        private System.Windows.Forms.TextBox tagBox;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.TextBox catBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox toSearch;
        private System.Windows.Forms.Button searchBut;
    }
}