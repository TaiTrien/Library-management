namespace Library_Management
{
    partial class frmSearchBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.clbItems = new System.Windows.Forms.CheckedListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbGoogle = new System.Windows.Forms.Label();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.clbItems);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lbGoogle);
            this.panel1.Controls.Add(this.tbSearchBar);
            this.panel1.Location = new System.Drawing.Point(29, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 358);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(172, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 2);
            this.label1.TabIndex = 28;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(211, 191);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(127, 20);
            this.lbSearch.TabIndex = 27;
            this.lbSearch.Text = "Tìm kiếm theo";
            // 
            // clbItems
            // 
            this.clbItems.FormattingEnabled = true;
            this.clbItems.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Thể loại",
            "Tác giả ",
            "Năm xuất bản",
            "Nhà xuất bản",
            "Trị giá"});
            this.clbItems.Location = new System.Drawing.Point(215, 214);
            this.clbItems.Name = "clbItems";
            this.clbItems.Size = new System.Drawing.Size(273, 106);
            this.clbItems.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.BackgroundImage = global::Library_Management.Properties.Resources.loupe;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(598, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 46);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lbGoogle
            // 
            this.lbGoogle.AutoSize = true;
            this.lbGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoogle.Location = new System.Drawing.Point(191, 37);
            this.lbGoogle.Name = "lbGoogle";
            this.lbGoogle.Size = new System.Drawing.Size(370, 44);
            this.lbGoogle.TabIndex = 24;
            this.lbGoogle.Text = "GOOGLE THƯ VIỆN";
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.BackColor = System.Drawing.SystemColors.Control;
            this.tbSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchBar.Location = new System.Drawing.Point(79, 106);
            this.tbSearchBar.Multiline = true;
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(578, 55);
            this.tbSearchBar.TabIndex = 1;
            this.tbSearchBar.Text = "Tìm kiếm....";
            this.tbSearchBar.Enter += new System.EventHandler(this.tbSearchBar_Enter);
            this.tbSearchBar.Leave += new System.EventHandler(this.tbSearchBar_Leave);
            // 
            // frmSearchBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearchBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.CheckedListBox clbItems;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbGoogle;
        private System.Windows.Forms.TextBox tbSearchBar;
    }
}