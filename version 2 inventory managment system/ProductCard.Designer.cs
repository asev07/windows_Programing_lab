namespace version_2_inventory_managment_system
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tittleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tittleNameLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tittleLbl
            // 
            this.tittleLbl.AutoSize = true;
            this.tittleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLbl.Location = new System.Drawing.Point(174, 160);
            this.tittleLbl.Name = "tittleLbl";
            this.tittleLbl.Size = new System.Drawing.Size(136, 54);
            this.tittleLbl.TabIndex = 0;
            this.tittleLbl.Text = "Title :";
            this.tittleLbl.Click += new System.EventHandler(this.tittleLbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // tittleNameLbl
            // 
            this.tittleNameLbl.AutoSize = true;
            this.tittleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleNameLbl.Location = new System.Drawing.Point(316, 160);
            this.tittleNameLbl.Name = "tittleNameLbl";
            this.tittleNameLbl.Size = new System.Drawing.Size(361, 54);
            this.tittleNameLbl.TabIndex = 3;
            this.tittleNameLbl.Text = "_____________";
            this.tittleNameLbl.Click += new System.EventHandler(this.tittleNameLbl_Click);
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(338, 424);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(387, 54);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "______________";
            this.priceLbl.Click += new System.EventHandler(this.priceLbl_Click);
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(470, 300);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(387, 54);
            this.descLbl.TabIndex = 5;
            this.descLbl.Text = "______________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 54);
            this.label5.TabIndex = 6;
            this.label5.Text = "Product Card";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.tittleNameLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tittleLbl);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(988, 508);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tittleNameLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label label5;
    }
}
