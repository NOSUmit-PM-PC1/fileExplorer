namespace fileExplorer
{
    partial class FormExplorer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplorer));
            this.listViewFolder = new System.Windows.Forms.ListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.imageListLage = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listViewFolder
            // 
            this.listViewFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFolder.HideSelection = false;
            this.listViewFolder.LargeImageList = this.imageListLage;
            this.listViewFolder.Location = new System.Drawing.Point(0, 0);
            this.listViewFolder.Name = "listViewFolder";
            this.listViewFolder.Size = new System.Drawing.Size(509, 538);
            this.listViewFolder.SmallImageList = this.imageListSmall;
            this.listViewFolder.TabIndex = 0;
            this.listViewFolder.UseCompatibleStateImageBehavior = false;
            this.listViewFolder.View = System.Windows.Forms.View.Details;
            this.listViewFolder.SelectedIndexChanged += new System.EventHandler(this.listViewFolder_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(509, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 538);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 31;
            this.listBoxFiles.Location = new System.Drawing.Point(512, 0);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(467, 538);
            this.listBoxFiles.TabIndex = 2;
            // 
            // imageListLage
            // 
            this.imageListLage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLage.ImageStream")));
            this.imageListLage.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLage.Images.SetKeyName(0, "folder.jpg");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "folder-icon.jpg");
            // 
            // FormExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 538);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listViewFolder);
            this.Name = "FormExplorer";
            this.Text = "Просмотр папок";
            this.Load += new System.EventHandler(this.FormExplorer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewFolder;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ImageList imageListLage;
        private System.Windows.Forms.ImageList imageListSmall;
    }
}

