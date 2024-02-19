
namespace практика4
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productArticleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeDataSet = new практика4.TradeDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.productTableAdapter = new практика4.TradeDataSetTableAdapters.ProductTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productArticleNumberDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.productPhotoDataGridViewImageColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.productDiscountAmountDataGridViewTextBoxColumn,
            this.productQuantityInStockDataGridViewTextBoxColumn,
            this.productStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // productArticleNumberDataGridViewTextBoxColumn
            // 
            this.productArticleNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.productArticleNumberDataGridViewTextBoxColumn.Name = "productArticleNumberDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            // 
            // productPhotoDataGridViewImageColumn
            // 
            this.productPhotoDataGridViewImageColumn.DataPropertyName = "ProductPhoto";
            this.productPhotoDataGridViewImageColumn.HeaderText = "Фотография";
            this.productPhotoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productPhotoDataGridViewImageColumn.Name = "productPhotoDataGridViewImageColumn";
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            // 
            // productDiscountAmountDataGridViewTextBoxColumn
            // 
            this.productDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.HeaderText = "Действующая скидка";
            this.productDiscountAmountDataGridViewTextBoxColumn.Name = "productDiscountAmountDataGridViewTextBoxColumn";
            // 
            // productQuantityInStockDataGridViewTextBoxColumn
            // 
            this.productQuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.productQuantityInStockDataGridViewTextBoxColumn.Name = "productQuantityInStockDataGridViewTextBoxColumn";
            // 
            // productStatusDataGridViewTextBoxColumn
            // 
            this.productStatusDataGridViewTextBoxColumn.DataPropertyName = "ProductStatus";
            this.productStatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.productStatusDataGridViewTextBoxColumn.Name = "productStatusDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.tradeDataSet;
            // 
            // tradeDataSet
            // 
            this.tradeDataSet.DataSetName = "TradeDataSet";
            this.tradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::практика4.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(971, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(755, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить / Изменить картинку товара";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProduct";
            this.Text = "Редактировать товары";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TradeDataSet tradeDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private TradeDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productArticleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn productPhotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusDataGridViewTextBoxColumn;
    }
}