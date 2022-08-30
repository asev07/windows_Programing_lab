namespace version_2_inventory_managment_system
{
    partial class UserControlTrail
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(52, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1013, 658);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(579, 923);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(229, 71);
            this.clearBtn.TabIndex = 13;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(856, 923);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(229, 71);
            this.addProductBtn.TabIndex = 12;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(627, 737);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 52);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 737);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name :";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxtBox.Location = new System.Drawing.Point(836, 738);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(282, 53);
            this.priceTxtBox.TabIndex = 9;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxtBox.Location = new System.Drawing.Point(310, 736);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(282, 53);
            this.nameTxtBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 849);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 52);
            this.label1.TabIndex = 15;
            this.label1.Text = "Discription :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // discTxtBox
            // 
            this.discTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discTxtBox.Location = new System.Drawing.Point(310, 850);
            this.discTxtBox.Name = "discTxtBox";
            this.discTxtBox.Size = new System.Drawing.Size(282, 53);
            this.discTxtBox.TabIndex = 14;
            // 
            // UserControlTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.discTxtBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UserControlTrail";
            this.Text = "ProductCard";
            this.Load += new System.EventHandler(this.UserControlTrail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox discTxtBox;
    }
}