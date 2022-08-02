namespace version_2_inventory_managment_system
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
            this.components = new System.ComponentModel.Container();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numberLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.monitorLbl = new System.Windows.Forms.Label();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.CountLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.monitorTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(220, 943);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(228, 94);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(620, 943);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(228, 94);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1046, 943);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(228, 94);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(85, 84);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(161, 46);
            this.numberLbl.TabIndex = 3;
            this.numberLbl.Text = "Number";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.Location = new System.Drawing.Point(526, 84);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(104, 46);
            this.dateLbl.TabIndex = 4;
            this.dateLbl.Text = "Date";
            // 
            // monitorLbl
            // 
            this.monitorLbl.AutoSize = true;
            this.monitorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorLbl.Location = new System.Drawing.Point(1121, 84);
            this.monitorLbl.Name = "monitorLbl";
            this.monitorLbl.Size = new System.Drawing.Size(327, 46);
            this.monitorLbl.TabIndex = 5;
            this.monitorLbl.Text = "Inventory Monitor";
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLbl.Location = new System.Drawing.Point(85, 395);
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
            this.priceLbl.Location = new System.Drawing.Point(812, 646);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(112, 46);
            this.priceLbl.TabIndex = 8;
            this.priceLbl.Text = "Price";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(93, 147);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(302, 64);
            this.numberTextBox.TabIndex = 9;
            this.numberTextBox.Leave += new System.EventHandler(this.numberTextBox_Leave);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(534, 147);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(302, 64);
            this.dateTextBox.TabIndex = 10;
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            this.dateTextBox.Leave += new System.EventHandler(this.dateTextBox_Leave);
            // 
            // monitorTextBox
            // 
            this.monitorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorTextBox.Location = new System.Drawing.Point(1129, 158);
            this.monitorTextBox.Name = "monitorTextBox";
            this.monitorTextBox.Size = new System.Drawing.Size(354, 64);
            this.monitorTextBox.TabIndex = 11;
            this.monitorTextBox.Leave += new System.EventHandler(this.monitorTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(93, 485);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(354, 64);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // countTextBox
            // 
            this.countTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTextBox.Location = new System.Drawing.Point(93, 741);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(354, 64);
            this.countTextBox.TabIndex = 13;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(820, 741);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(354, 64);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 1119);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.monitorTextBox);
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
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label monitorLbl;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label CountLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox monitorTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}

