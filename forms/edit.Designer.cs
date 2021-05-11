
namespace articles.forms
{
    partial class edit
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
            this.tagBox = new System.Windows.Forms.ComboBox();
            this.authorBox = new System.Windows.Forms.ComboBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.articleBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tagBox
            // 
            this.tagBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagBox.FormattingEnabled = true;
            this.tagBox.Location = new System.Drawing.Point(111, 229);
            this.tagBox.Name = "tagBox";
            this.tagBox.Size = new System.Drawing.Size(485, 27);
            this.tagBox.TabIndex = 60;
            // 
            // authorBox
            // 
            this.authorBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorBox.FormattingEnabled = true;
            this.authorBox.Location = new System.Drawing.Point(111, 140);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(485, 27);
            this.authorBox.TabIndex = 59;
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(111, 101);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(485, 27);
            this.categoryBox.TabIndex = 58;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(259, 536);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(94, 34);
            this.refresh.TabIndex = 57;
            this.refresh.Text = "Обновить";
            this.refresh.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(467, 536);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(129, 34);
            this.update.TabIndex = 56;
            this.update.Text = "Редактировать";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(111, 183);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(485, 26);
            this.date.TabIndex = 55;
            // 
            // articleBox
            // 
            this.articleBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleBox.Location = new System.Drawing.Point(111, 277);
            this.articleBox.Multiline = true;
            this.articleBox.Name = "articleBox";
            this.articleBox.Size = new System.Drawing.Size(485, 250);
            this.articleBox.TabIndex = 54;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleBox.Location = new System.Drawing.Point(111, 66);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(485, 26);
            this.titleBox.TabIndex = 53;
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDbox.Location = new System.Drawing.Point(111, 22);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(485, 26);
            this.IDbox.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(16, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "Тег";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 50;
            this.label6.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Статья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.title,
            this.cat,
            this.author,
            this.article,
            this.date1,
            this.tag});
            this.dataGridView.Location = new System.Drawing.Point(618, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(926, 505);
            this.dataGridView.TabIndex = 44;
            this.dataGridView.Click += new System.EventHandler(this.dstsGriView_Click);
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
            this.back.Location = new System.Drawing.Point(17, 536);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(83, 34);
            this.back.TabIndex = 43;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 584);
            this.Controls.Add(this.tagBox);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.update);
            this.Controls.Add(this.date);
            this.Controls.Add(this.articleBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.back);
            this.Name = "edit";
            this.Text = "edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tagBox;
        private System.Windows.Forms.ComboBox authorBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox articleBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.Button back;
    }
}