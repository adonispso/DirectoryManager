namespace MyDirectory
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button_browse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_directory = new System.Windows.Forms.Label();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.label_size_num = new System.Windows.Forms.Label();
            this.label_files_num = new System.Windows.Forms.Label();
            this.label_folder_num = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.files = new System.Windows.Forms.Label();
            this.label_folder = new System.Windows.Forms.Label();
            this.groupBox_export = new System.Windows.Forms.GroupBox();
            this.comboBox_format = new System.Windows.Forms.ComboBox();
            this.button_export = new System.Windows.Forms.Button();
            this.label_format = new System.Windows.Forms.Label();
            this.groupBox_save = new System.Windows.Forms.GroupBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_save = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_format = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.groupBox_export.SuspendLayout();
            this.groupBox_save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_format)).BeginInit();
            this.SuspendLayout();
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(239, 16);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Search";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_directory);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Folder:";
            // 
            // label_directory
            // 
            this.label_directory.AutoSize = true;
            this.label_directory.Location = new System.Drawing.Point(125, 38);
            this.label_directory.Name = "label_directory";
            this.label_directory.Size = new System.Drawing.Size(35, 13);
            this.label_directory.TabIndex = 1;
            this.label_directory.Text = "label1";
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.label_size_num);
            this.groupBox_info.Controls.Add(this.label_files_num);
            this.groupBox_info.Controls.Add(this.label_folder_num);
            this.groupBox_info.Controls.Add(this.size);
            this.groupBox_info.Controls.Add(this.files);
            this.groupBox_info.Controls.Add(this.label_folder);
            this.groupBox_info.Location = new System.Drawing.Point(12, 90);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(344, 109);
            this.groupBox_info.TabIndex = 2;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Folder Informations";
            // 
            // label_size_num
            // 
            this.label_size_num.AutoSize = true;
            this.label_size_num.Location = new System.Drawing.Point(125, 80);
            this.label_size_num.Name = "label_size_num";
            this.label_size_num.Size = new System.Drawing.Size(35, 13);
            this.label_size_num.TabIndex = 5;
            this.label_size_num.Text = "label6";
            // 
            // label_files_num
            // 
            this.label_files_num.AutoSize = true;
            this.label_files_num.Location = new System.Drawing.Point(125, 54);
            this.label_files_num.Name = "label_files_num";
            this.label_files_num.Size = new System.Drawing.Size(35, 13);
            this.label_files_num.TabIndex = 4;
            this.label_files_num.Text = "label5";
            // 
            // label_folder_num
            // 
            this.label_folder_num.AutoSize = true;
            this.label_folder_num.Location = new System.Drawing.Point(125, 28);
            this.label_folder_num.Name = "label_folder_num";
            this.label_folder_num.Size = new System.Drawing.Size(35, 13);
            this.label_folder_num.TabIndex = 3;
            this.label_folder_num.Text = "label4";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(72, 80);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(30, 13);
            this.size.TabIndex = 2;
            this.size.Text = "Size:";
            // 
            // files
            // 
            this.files.AutoSize = true;
            this.files.Location = new System.Drawing.Point(81, 54);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(31, 13);
            this.files.TabIndex = 1;
            this.files.Text = "Files:";
            // 
            // label_folder
            // 
            this.label_folder.AutoSize = true;
            this.label_folder.Location = new System.Drawing.Point(74, 28);
            this.label_folder.Name = "label_folder";
            this.label_folder.Size = new System.Drawing.Size(44, 13);
            this.label_folder.TabIndex = 0;
            this.label_folder.Text = "Folders:";
            // 
            // groupBox_export
            // 
            this.groupBox_export.Controls.Add(this.comboBox_format);
            this.groupBox_export.Controls.Add(this.button_export);
            this.groupBox_export.Controls.Add(this.label_format);
            this.groupBox_export.Location = new System.Drawing.Point(12, 314);
            this.groupBox_export.Name = "groupBox_export";
            this.groupBox_export.Size = new System.Drawing.Size(344, 88);
            this.groupBox_export.TabIndex = 3;
            this.groupBox_export.TabStop = false;
            this.groupBox_export.Text = "Export Options";
            // 
            // comboBox_format
            // 
            this.comboBox_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_format.FormattingEnabled = true;
            this.comboBox_format.Items.AddRange(new object[] {
            ".txt",
            ".csv"});
            this.comboBox_format.Location = new System.Drawing.Point(193, 22);
            this.comboBox_format.Name = "comboBox_format";
            this.comboBox_format.Size = new System.Drawing.Size(121, 21);
            this.comboBox_format.TabIndex = 1;
            this.comboBox_format.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_format_Validating);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(238, 59);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(75, 23);
            this.button_export.TabIndex = 4;
            this.button_export.Text = "Export";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // label_format
            // 
            this.label_format.AutoSize = true;
            this.label_format.Location = new System.Drawing.Point(6, 25);
            this.label_format.Name = "label_format";
            this.label_format.Size = new System.Drawing.Size(39, 13);
            this.label_format.TabIndex = 0;
            this.label_format.Text = "Format";
            // 
            // groupBox_save
            // 
            this.groupBox_save.Controls.Add(this.textBox_name);
            this.groupBox_save.Controls.Add(this.label_name);
            this.groupBox_save.Controls.Add(this.label_save);
            this.groupBox_save.Controls.Add(this.button_save);
            this.groupBox_save.Location = new System.Drawing.Point(12, 205);
            this.groupBox_save.Name = "groupBox_save";
            this.groupBox_save.Size = new System.Drawing.Size(344, 103);
            this.groupBox_save.TabIndex = 5;
            this.groupBox_save.TabStop = false;
            this.groupBox_save.Text = "Save Options";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(84, 57);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(229, 20);
            this.textBox_name.TabIndex = 3;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 60);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Name:";
            // 
            // label_save
            // 
            this.label_save.AutoSize = true;
            this.label_save.Location = new System.Drawing.Point(6, 24);
            this.label_save.Name = "label_save";
            this.label_save.Size = new System.Drawing.Size(35, 13);
            this.label_save.TabIndex = 1;
            this.label_save.Text = "label2";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(239, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Select";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_format
            // 
            this.errorProvider_format.ContainerControl = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(368, 425);
            this.Controls.Add(this.groupBox_save);
            this.Controls.Add(this.groupBox_export);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "My Directory Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.groupBox_export.ResumeLayout(false);
            this.groupBox_export.PerformLayout();
            this.groupBox_save.ResumeLayout(false);
            this.groupBox_save.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_format)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Label label_size_num;
        private System.Windows.Forms.Label label_files_num;
        private System.Windows.Forms.Label label_folder_num;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label files;
        private System.Windows.Forms.Label label_folder;
        private System.Windows.Forms.Label label_directory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_export;
        private System.Windows.Forms.ComboBox comboBox_format;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Label label_format;
        private System.Windows.Forms.GroupBox groupBox_save;
        private System.Windows.Forms.Label label_save;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.ErrorProvider errorProvider_format;
    }
}

