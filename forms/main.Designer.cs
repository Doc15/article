
namespace articles
{
    partial class main
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
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.update = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.delArt = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.addCat = new System.Windows.Forms.Button();
            this.addArticle = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(948, 401);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(124, 37);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(948, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.name,
            this.category,
            this.author,
            this.description,
            this.date,
            this.tag});
            this.list.Cursor = System.Windows.Forms.Cursors.Default;
            this.list.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(822, 426);
            this.list.TabIndex = 2;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "№";
            this.number.Width = 50;
            // 
            // name
            // 
            this.name.Text = "Название";
            this.name.Width = 220;
            // 
            // category
            // 
            this.category.Text = "Категория";
            this.category.Width = 136;
            // 
            // author
            // 
            this.author.Text = "Автор";
            this.author.Width = 132;
            // 
            // description
            // 
            this.description.Text = "Статья";
            this.description.Width = 325;
            // 
            // date
            // 
            this.date.Text = "Дата";
            this.date.Width = 145;
            // 
            // tag
            // 
            this.tag.Text = "Тег";
            this.tag.Width = 129;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(948, 237);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(124, 53);
            this.update.TabIndex = 18;
            this.update.Text = "Редактировать статью";
            this.update.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(948, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "Добавить тег";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // delArt
            // 
            this.delArt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delArt.Location = new System.Drawing.Point(840, 133);
            this.delArt.Name = "delArt";
            this.delArt.Size = new System.Drawing.Size(89, 28);
            this.delArt.TabIndex = 16;
            this.delArt.Text = "Удалить статью";
            this.delArt.UseVisualStyleBackColor = true;
            this.delArt.Click += new System.EventHandler(this.delArt_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(840, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 37);
            this.search.TabIndex = 15;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            // 
            // addCat
            // 
            this.addCat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCat.Location = new System.Drawing.Point(948, 121);
            this.addCat.Name = "addCat";
            this.addCat.Size = new System.Drawing.Size(124, 52);
            this.addCat.TabIndex = 14;
            this.addCat.Text = "Добавить категорию";
            this.addCat.UseVisualStyleBackColor = true;
            // 
            // addArticle
            // 
            this.addArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addArticle.Location = new System.Drawing.Point(948, 63);
            this.addArticle.Name = "addArticle";
            this.addArticle.Size = new System.Drawing.Size(124, 52);
            this.addArticle.TabIndex = 12;
            this.addArticle.Text = "Добавить статью";
            this.addArticle.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh.Location = new System.Drawing.Point(840, 70);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(89, 38);
            this.Refresh.TabIndex = 11;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delArt);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addCat);
            this.Controls.Add(this.addArticle);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.Name = "main";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader number;
        protected System.Windows.Forms.ColumnHeader name;
        public System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader tag;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delArt;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button addCat;
        private System.Windows.Forms.Button addArticle;
        private System.Windows.Forms.Button Refresh;
    }
}