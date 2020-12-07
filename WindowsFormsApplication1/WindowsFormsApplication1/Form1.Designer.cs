namespace WindowsFormsApplication1
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
            this.labelNama = new System.Windows.Forms.Label();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxNama = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(12, 23);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(69, 13);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Billy Agustian";
            // 
            // buttonUbah
            // 
            this.buttonUbah.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.Red;
            this.buttonUbah.Location = new System.Drawing.Point(111, 134);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(106, 49);
            this.buttonUbah.TabIndex = 1;
            this.buttonUbah.Text = "Ubah!";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.DockChanged += new System.EventHandler(this.buttonUbah_DockChanged);
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            this.buttonUbah.DragDrop += new System.Windows.Forms.DragEventHandler(this.buttonUbah_DragDrop);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(111, 108);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 2;
            this.textBoxNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNama_KeyDown);
            // 
            // comboBoxNama
            // 
            this.comboBoxNama.FormattingEnabled = true;
            this.comboBoxNama.Location = new System.Drawing.Point(297, 61);
            this.comboBoxNama.Name = "comboBoxNama";
            this.comboBoxNama.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNama.TabIndex = 3;
            this.comboBoxNama.SelectedIndexChanged += new System.EventHandler(this.comboBoxNama_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(439, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxNama);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxNama;
        private System.Windows.Forms.ListBox listBox1;
    }
}

