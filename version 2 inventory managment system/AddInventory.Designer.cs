namespace version_2_inventory_managment_system
{
    partial class AddInventory
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
            System.Windows.Forms.Label idLabel;
            this.saveBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.monitorLbl = new System.Windows.Forms.Label();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.CountLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new version_2_inventory_managment_system.inventoryDataSet();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new version_2_inventory_managment_system.inventoryDataSetTableAdapters.inventoryTableAdapter();
            this.tableAdapterManager = new version_2_inventory_managment_system.inventoryDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new version_2_inventory_managment_system.inventoryDataSetTableAdapters.EmployeeTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLabel1 = new System.Windows.Forms.Label();
            this.numberLbl = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(515, 703);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(229, 93);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(915, 703);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(229, 93);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1341, 703);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(229, 93);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // monitorLbl
            // 
            this.monitorLbl.AutoSize = true;
            this.monitorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorLbl.Location = new System.Drawing.Point(1344, 48);
            this.monitorLbl.Name = "monitorLbl";
            this.monitorLbl.Size = new System.Drawing.Size(327, 46);
            this.monitorLbl.TabIndex = 5;
            this.monitorLbl.Text = "Inventory Monitor";
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLbl.Location = new System.Drawing.Point(85, 396);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(213, 46);
            this.itemNameLbl.TabIndex = 6;
            this.itemNameLbl.Text = "Item Name";
            // 
            // CountLbl
            // 
            this.CountLbl.AutoSize = true;
            this.CountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLbl.Location = new System.Drawing.Point(85, 646);
            this.CountLbl.Name = "CountLbl";
            this.CountLbl.Size = new System.Drawing.Size(127, 46);
            this.CountLbl.TabIndex = 7;
            this.CountLbl.Text = "Count";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(523, 391);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(112, 46);
            this.priceLbl.TabIndex = 8;
            this.priceLbl.Text = "Price";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(93, 484);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(353, 64);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTextBox.Location = new System.Drawing.Point(93, 742);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(353, 64);
            this.countTextBox.TabIndex = 13;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(533, 484);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(353, 64);
            this.priceTextBox.TabIndex = 14;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1365, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "-    -   -   -    - ";
            // 
            // inventoryDataSetBindingSource
            // 
            this.inventoryDataSetBindingSource.DataSource = this.inventoryDataSet;
            this.inventoryDataSetBindingSource.Position = 0;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "inventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(32, 12);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(229, 45);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.inventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = version_2_inventory_managment_system.inventoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.inventoryDataSet;
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "id", true));
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel1.Location = new System.Drawing.Point(182, 158);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(212, 53);
            this.idLabel1.TabIndex = 19;
            this.idLabel1.Text = "label2";
            this.idLabel1.Click += new System.EventHandler(this.idLabel1_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(93, 157);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(72, 54);
            idLabel.TabIndex = 18;
            idLabel.Text = "id:";
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(83, 236);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(161, 46);
            this.numberLbl.TabIndex = 3;
            this.numberLbl.Text = "Number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(91, 298);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(303, 64);
            this.numberTextBox.TabIndex = 9;
            this.numberTextBox.Leave += new System.EventHandler(this.numberTextBox_Leave);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(533, 298);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(303, 64);
            this.dateTextBox.TabIndex = 10;
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            this.dateTextBox.Leave += new System.EventHandler(this.dateTextBox_Leave);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(523, 236);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(104, 46);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1137, 378);
            this.label2.TabIndex = 20;
            this.label2.Text = "           ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1933, 1562);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.CountLbl);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.monitorLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.numberLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.saveBtn);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddInventory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label monitorLbl;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource inventoryDataSetBindingSource;
        private inventoryDataSet inventoryDataSet;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private inventoryDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private inventoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private inventoryDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label label2;
    }
}

