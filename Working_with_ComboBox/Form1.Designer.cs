
namespace Working_with_ComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.item1_combo = new Siticone.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.item2_item = new Siticone.UI.WinForms.SiticoneComboBox();
            this.additem1 = new System.Windows.Forms.PictureBox();
            this.additem2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.additem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additem2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working with";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "COMBOBOX";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.FillThickness = 2;
            this.siticoneSeparator1.Location = new System.Drawing.Point(159, 49);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(123, 10);
            this.siticoneSeparator1.TabIndex = 2;
            // 
            // item1_combo
            // 
            this.item1_combo.BackColor = System.Drawing.Color.Transparent;
            this.item1_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.item1_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item1_combo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.item1_combo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.item1_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.item1_combo.HoveredState.Parent = this.item1_combo;
            this.item1_combo.ItemHeight = 30;
            this.item1_combo.ItemsAppearance.Parent = this.item1_combo;
            this.item1_combo.Location = new System.Drawing.Point(23, 151);
            this.item1_combo.Name = "item1_combo";
            this.item1_combo.ShadowDecoration.Parent = this.item1_combo;
            this.item1_combo.Size = new System.Drawing.Size(299, 36);
            this.item1_combo.TabIndex = 3;
            this.item1_combo.SelectedIndexChanged += new System.EventHandler(this.item1_combo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "item 2";
            // 
            // item2_item
            // 
            this.item2_item.BackColor = System.Drawing.Color.Transparent;
            this.item2_item.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.item2_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.item2_item.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.item2_item.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.item2_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.item2_item.HoveredState.Parent = this.item2_item;
            this.item2_item.ItemHeight = 30;
            this.item2_item.ItemsAppearance.Parent = this.item2_item;
            this.item2_item.Location = new System.Drawing.Point(23, 234);
            this.item2_item.Name = "item2_item";
            this.item2_item.ShadowDecoration.Parent = this.item2_item;
            this.item2_item.Size = new System.Drawing.Size(299, 36);
            this.item2_item.TabIndex = 5;

            // 
            // additem1
            // 
            this.additem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.additem1.Image = ((System.Drawing.Image)(resources.GetObject("additem1.Image")));
            this.additem1.Location = new System.Drawing.Point(324, 151);
            this.additem1.Name = "additem1";
            this.additem1.Size = new System.Drawing.Size(37, 36);
            this.additem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.additem1.TabIndex = 7;
            this.additem1.TabStop = false;
            this.additem1.Click += new System.EventHandler(this.additem1_Click);
            // 
            // additem2
            // 
            this.additem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.additem2.Image = ((System.Drawing.Image)(resources.GetObject("additem2.Image")));
            this.additem2.Location = new System.Drawing.Point(324, 234);
            this.additem2.Name = "additem2";
            this.additem2.Size = new System.Drawing.Size(37, 36);
            this.additem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.additem2.TabIndex = 8;
            this.additem2.TabStop = false;
            this.additem2.Click += new System.EventHandler(this.additem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 356);
            this.Controls.Add(this.additem2);
            this.Controls.Add(this.additem1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.item2_item);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.item1_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.additem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneComboBox item1_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Siticone.UI.WinForms.SiticoneComboBox item2_item;
        private System.Windows.Forms.PictureBox additem1;
        private System.Windows.Forms.PictureBox additem2;
    }
}

