
namespace Working_with_ComboBox
{
    partial class item1Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.text_item1 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.btnsave = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "ITEM 1";
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.FillThickness = 2;
            this.siticoneSeparator1.Location = new System.Drawing.Point(115, 61);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(123, 10);
            this.siticoneSeparator1.TabIndex = 5;
            // 
            // text_item1
            // 
            this.text_item1.Animated = false;
            this.text_item1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_item1.DefaultText = "";
            this.text_item1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text_item1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text_item1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_item1.DisabledState.Parent = this.text_item1;
            this.text_item1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text_item1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.text_item1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_item1.FocusedState.Parent = this.text_item1;
            this.text_item1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text_item1.HoveredState.Parent = this.text_item1;
            this.text_item1.Location = new System.Drawing.Point(37, 148);
            this.text_item1.Name = "text_item1";
            this.text_item1.PasswordChar = '\0';
            this.text_item1.PlaceholderText = "";
            this.text_item1.SelectedText = "";
            this.text_item1.ShadowDecoration.Parent = this.text_item1;
            this.text_item1.Size = new System.Drawing.Size(284, 36);
            this.text_item1.TabIndex = 6;
            // 
            // btnsave
            // 
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.HoveredState.Parent = this.btnsave;
            this.btnsave.Location = new System.Drawing.Point(105, 252);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Parent = this.btnsave;
            this.btnsave.Size = new System.Drawing.Size(155, 36);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "S A V E";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // item1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 356);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.text_item1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "item1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.item1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox text_item1;
        private Siticone.UI.WinForms.SiticoneButton btnsave;
    }
}