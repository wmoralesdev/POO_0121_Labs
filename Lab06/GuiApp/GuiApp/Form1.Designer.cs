namespace GuiApp
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
            this.btn_show = new System.Windows.Forms.Button();
            this.cmb_names = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(90, 74);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(149, 37);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "button1";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            this.btn_show.MouseEnter += new System.EventHandler(this.btn_show_MouseEnter);
            this.btn_show.MouseLeave += new System.EventHandler(this.btn_show_MouseLeave);
            // 
            // cmb_names
            // 
            this.cmb_names.FormattingEnabled = true;
            this.cmb_names.Location = new System.Drawing.Point(90, 22);
            this.cmb_names.Name = "cmb_names";
            this.cmb_names.Size = new System.Drawing.Size(148, 21);
            this.cmb_names.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 143);
            this.Controls.Add(this.cmb_names);
            this.Controls.Add(this.btn_show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmb_names;

        private System.Windows.Forms.Button btn_show;

        #endregion
    }
}