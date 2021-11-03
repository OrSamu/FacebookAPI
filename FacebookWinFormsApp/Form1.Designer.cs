namespace BasicFacebookFeatures
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
            this.m_ListBoxPictures = new System.Windows.Forms.ListBox();
            this.m_PictureBoxSelected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ListBoxPictures
            // 
            this.m_ListBoxPictures.FormattingEnabled = true;
            this.m_ListBoxPictures.ItemHeight = 20;
            this.m_ListBoxPictures.Location = new System.Drawing.Point(44, 107);
            this.m_ListBoxPictures.Name = "m_ListBoxPictures";
            this.m_ListBoxPictures.Size = new System.Drawing.Size(178, 304);
            this.m_ListBoxPictures.TabIndex = 0;
            this.m_ListBoxPictures.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxPictures_SelectedIndexChanged);
            // 
            // m_PictureBoxSelected
            // 
            this.m_PictureBoxSelected.Location = new System.Drawing.Point(259, 107);
            this.m_PictureBoxSelected.Name = "m_PictureBoxSelected";
            this.m_PictureBoxSelected.Size = new System.Drawing.Size(116, 105);
            this.m_PictureBoxSelected.TabIndex = 1;
            this.m_PictureBoxSelected.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_PictureBoxSelected);
            this.Controls.Add(this.m_ListBoxPictures);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_ListBoxPictures;
        private System.Windows.Forms.PictureBox m_PictureBoxSelected;
    }
}