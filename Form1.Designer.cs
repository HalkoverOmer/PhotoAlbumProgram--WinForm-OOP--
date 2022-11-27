namespace PhotoAlbumProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAlbums = new System.Windows.Forms.Button();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNewAlbum = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.flpAlbumPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExportAlbum = new System.Windows.Forms.Button();
            this.btnSaveAlbum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbumDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRightClick = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAlbums);
            this.groupBox1.Controls.Add(this.lstAlbums);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 759);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Albümler";
            // 
            // btnDeleteAlbums
            // 
            this.btnDeleteAlbums.Location = new System.Drawing.Point(188, 704);
            this.btnDeleteAlbums.Name = "btnDeleteAlbums";
            this.btnDeleteAlbums.Size = new System.Drawing.Size(112, 42);
            this.btnDeleteAlbums.TabIndex = 1;
            this.btnDeleteAlbums.Text = "Sil";
            this.btnDeleteAlbums.UseVisualStyleBackColor = true;
            this.btnDeleteAlbums.Click += new System.EventHandler(this.btnDeleteAlbums_Click);
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.ItemHeight = 25;
            this.lstAlbums.Location = new System.Drawing.Point(6, 30);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(294, 654);
            this.lstAlbums.TabIndex = 0;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddNewAlbum);
            this.groupBox2.Controls.Add(this.btnAddPhoto);
            this.groupBox2.Controls.Add(this.flpAlbumPhotos);
            this.groupBox2.Controls.Add(this.btnExportAlbum);
            this.groupBox2.Controls.Add(this.btnSaveAlbum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAlbumDescription);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAlbumName);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1174, 759);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Albüm Bilgileri ve Resimler";
            // 
            // btnAddNewAlbum
            // 
            this.btnAddNewAlbum.Location = new System.Drawing.Point(283, 698);
            this.btnAddNewAlbum.Name = "btnAddNewAlbum";
            this.btnAddNewAlbum.Size = new System.Drawing.Size(252, 48);
            this.btnAddNewAlbum.TabIndex = 4;
            this.btnAddNewAlbum.Text = "Yeni Albüm Ekle";
            this.btnAddNewAlbum.UseVisualStyleBackColor = true;
            this.btnAddNewAlbum.Click += new System.EventHandler(this.btnAddNewAlbum_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(6, 298);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(252, 34);
            this.btnAddPhoto.TabIndex = 3;
            this.btnAddPhoto.Text = "Resim Ekle";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // flpAlbumPhotos
            // 
            this.flpAlbumPhotos.AutoScroll = true;
            this.flpAlbumPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAlbumPhotos.Location = new System.Drawing.Point(283, 58);
            this.flpAlbumPhotos.Name = "flpAlbumPhotos";
            this.flpAlbumPhotos.Size = new System.Drawing.Size(876, 626);
            this.flpAlbumPhotos.TabIndex = 3;
            // 
            // btnExportAlbum
            // 
            this.btnExportAlbum.Location = new System.Drawing.Point(6, 357);
            this.btnExportAlbum.Name = "btnExportAlbum";
            this.btnExportAlbum.Size = new System.Drawing.Size(252, 34);
            this.btnExportAlbum.TabIndex = 2;
            this.btnExportAlbum.Text = "Albüm Excell Export";
            this.btnExportAlbum.UseVisualStyleBackColor = true;
            // 
            // btnSaveAlbum
            // 
            this.btnSaveAlbum.Location = new System.Drawing.Point(943, 704);
            this.btnSaveAlbum.Name = "btnSaveAlbum";
            this.btnSaveAlbum.Size = new System.Drawing.Size(216, 42);
            this.btnSaveAlbum.TabIndex = 2;
            this.btnSaveAlbum.Text = "Albümü Kaydet";
            this.btnSaveAlbum.UseVisualStyleBackColor = true;
            this.btnSaveAlbum.Click += new System.EventHandler(this.btnSaveAlbum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // txtAlbumDescription
            // 
            this.txtAlbumDescription.Location = new System.Drawing.Point(6, 158);
            this.txtAlbumDescription.Multiline = true;
            this.txtAlbumDescription.Name = "txtAlbumDescription";
            this.txtAlbumDescription.Size = new System.Drawing.Size(252, 117);
            this.txtAlbumDescription.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Albüm Adı";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(6, 86);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(252, 31);
            this.txtAlbumName.TabIndex = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRightClick});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(155, 36);
            this.contextMenuStrip2.Text = "Sağ Tık Menü";
            // 
            // tsmRightClick
            // 
            this.tsmRightClick.Name = "tsmRightClick";
            this.tsmRightClick.Size = new System.Drawing.Size(154, 32);
            this.tsmRightClick.Text = "Resmi Sil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 790);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Albüm Dizayn Yazılımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDeleteAlbums;
        private ListBox lstAlbums;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtAlbumName;
        private FlowLayoutPanel flpAlbumPhotos;
        private Button btnExportAlbum;
        private Button btnSaveAlbum;
        private Label label2;
        private TextBox txtAlbumDescription;
        private Button btnAddPhoto;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button btnAddNewAlbum;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem tsmRightClick;
    }
}