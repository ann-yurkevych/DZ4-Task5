namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AuthorsTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.measureUnitTextBox = new System.Windows.Forms.TextBox();
            this.expirationTimeTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.producingDateTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.Add_product = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_book = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.DeleteCommodity = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryOfOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.AuthorsTextBox);
            this.panel1.Controls.Add(this.publisherTextBox);
            this.panel1.Controls.Add(this.pagesTextBox);
            this.panel1.Controls.Add(this.measureUnitTextBox);
            this.panel1.Controls.Add(this.expirationTimeTextBox);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.producingDateTextBox);
            this.panel1.Controls.Add(this.countryTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 515);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(977, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 27;
            this.label15.Text = "Для книжок:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(714, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Для продуктів:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Придатний";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(926, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Автори";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(889, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Видавництво";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(915, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Сторінок";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(699, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Міра";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(693, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 20;
            // 
            // AuthorsTextBox
            // 
            this.AuthorsTextBox.Location = new System.Drawing.Point(985, 336);
            this.AuthorsTextBox.Name = "AuthorsTextBox";
            this.AuthorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorsTextBox.TabIndex = 19;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(985, 291);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 18;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.Location = new System.Drawing.Point(985, 249);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(100, 20);
            this.pagesTextBox.TabIndex = 17;
            // 
            // measureUnitTextBox
            // 
            this.measureUnitTextBox.Location = new System.Drawing.Point(740, 339);
            this.measureUnitTextBox.Name = "measureUnitTextBox";
            this.measureUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.measureUnitTextBox.TabIndex = 16;
            // 
            // expirationTimeTextBox
            // 
            this.expirationTimeTextBox.Location = new System.Drawing.Point(740, 291);
            this.expirationTimeTextBox.Name = "expirationTimeTextBox";
            this.expirationTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.expirationTimeTextBox.TabIndex = 15;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(740, 244);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 14;
            // 
            // producingDateTextBox
            // 
            this.producingDateTextBox.Location = new System.Drawing.Point(985, 170);
            this.producingDateTextBox.Name = "producingDateTextBox";
            this.producingDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.producingDateTextBox.TabIndex = 13;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(740, 175);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 12;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(985, 121);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(864, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Кількість";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Дата виробництва";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Країна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ціна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Назва";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(740, 121);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(677, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введіть параметри товару, який хочете додати";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton1,
            this.toolStripLabel2,
            this.DeleteCommodity});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1126, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabel1.Text = "Додати";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_product,
            this.Add_book});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(36, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // Add_product
            // 
            this.Add_product.Name = "Add_product";
            this.Add_product.Size = new System.Drawing.Size(180, 22);
            this.Add_product.Text = "Продукт";
            this.Add_product.Click += new System.EventHandler(this.Add_product_Click);
            // 
            // Add_book
            // 
            this.Add_book.Name = "Add_book";
            this.Add_book.Size = new System.Drawing.Size(180, 22);
            this.Add_book.Text = "Книгу";
            this.Add_book.Click += new System.EventHandler(this.Add_book_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(94, 24);
            this.toolStripLabel2.Text = "Вилучити товар";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // DeleteCommodity
            // 
            this.DeleteCommodity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteCommodity.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCommodity.Image")));
            this.DeleteCommodity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCommodity.Name = "DeleteCommodity";
            this.DeleteCommodity.Size = new System.Drawing.Size(24, 24);
            this.DeleteCommodity.Text = "toolStripButton2";
            this.DeleteCommodity.ToolTipText = "Видалити продукт";
            this.DeleteCommodity.Click += new System.EventHandler(this.DeleteCommodity_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.name,
            this.price,
            this.countryOfOrigin,
            this.packingDate});
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(657, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Назва";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Ціна";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // countryOfOrigin
            // 
            this.countryOfOrigin.HeaderText = "Країна виробник";
            this.countryOfOrigin.MinimumWidth = 6;
            this.countryOfOrigin.Name = "countryOfOrigin";
            this.countryOfOrigin.ReadOnly = true;
            this.countryOfOrigin.Width = 150;
            // 
            // packingDate
            // 
            this.packingDate.HeaderText = "Дата виробництва";
            this.packingDate.MinimumWidth = 6;
            this.packingDate.Name = "packingDate";
            this.packingDate.ReadOnly = true;
            this.packingDate.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 515);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton DeleteCommodity;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryOfOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AuthorsTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox measureUnitTextBox;
        private System.Windows.Forms.TextBox expirationTimeTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox producingDateTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem Add_product;
        private System.Windows.Forms.ToolStripMenuItem Add_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

