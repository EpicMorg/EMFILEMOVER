namespace EMFILEMOVER
{
    partial class frm_Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.txt_path1 = new System.Windows.Forms.TextBox();
            this.txt_path2 = new System.Windows.Forms.TextBox();
            this.txt_mask = new System.Windows.Forms.ComboBox();
            this.btn_path1 = new System.Windows.Forms.Button();
            this.btn_path2 = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.lbl_path1 = new System.Windows.Forms.Label();
            this.lbl_path2 = new System.Windows.Forms.Label();
            this.lbl_mask = new System.Windows.Forms.Label();
            this.dialog_browse1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dialog_browse2 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lnk_info = new System.Windows.Forms.LinkLabel();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.lbl_process = new System.Windows.Forms.Label();
            this.gb_null = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.gb_null.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_path1
            // 
            this.txt_path1.Location = new System.Drawing.Point(16, 32);
            this.txt_path1.Name = "txt_path1";
            this.txt_path1.Size = new System.Drawing.Size(435, 20);
            this.txt_path1.TabIndex = 0;
            // 
            // txt_path2
            // 
            this.txt_path2.Location = new System.Drawing.Point(16, 81);
            this.txt_path2.Name = "txt_path2";
            this.txt_path2.Size = new System.Drawing.Size(435, 20);
            this.txt_path2.TabIndex = 1;
            // 
            // txt_mask
            // 
            this.txt_mask.FormattingEnabled = true;
            this.txt_mask.Location = new System.Drawing.Point(16, 127);
            this.txt_mask.Name = "txt_mask";
            this.txt_mask.Size = new System.Drawing.Size(435, 21);
            this.txt_mask.TabIndex = 2;
            this.txt_mask.Text = "*.*";
            // 
            // btn_path1
            // 
            this.btn_path1.Location = new System.Drawing.Point(457, 30);
            this.btn_path1.Name = "btn_path1";
            this.btn_path1.Size = new System.Drawing.Size(75, 23);
            this.btn_path1.TabIndex = 3;
            this.btn_path1.Text = "Обзор";
            this.btn_path1.UseVisualStyleBackColor = true;
            this.btn_path1.Click += new System.EventHandler(this.btn_path1_Click);
            // 
            // btn_path2
            // 
            this.btn_path2.Location = new System.Drawing.Point(457, 79);
            this.btn_path2.Name = "btn_path2";
            this.btn_path2.Size = new System.Drawing.Size(75, 23);
            this.btn_path2.TabIndex = 3;
            this.btn_path2.Text = "Обзор";
            this.btn_path2.UseVisualStyleBackColor = true;
            this.btn_path2.Click += new System.EventHandler(this.btn_path2_Click);
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(457, 125);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(75, 23);
            this.btn_move.TabIndex = 4;
            this.btn_move.Text = "Поиск";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // lbl_path1
            // 
            this.lbl_path1.AutoSize = true;
            this.lbl_path1.Location = new System.Drawing.Point(16, 16);
            this.lbl_path1.Name = "lbl_path1";
            this.lbl_path1.Size = new System.Drawing.Size(63, 13);
            this.lbl_path1.TabIndex = 5;
            this.lbl_path1.Text = "Где искать";
            // 
            // lbl_path2
            // 
            this.lbl_path2.AutoSize = true;
            this.lbl_path2.Location = new System.Drawing.Point(16, 65);
            this.lbl_path2.Name = "lbl_path2";
            this.lbl_path2.Size = new System.Drawing.Size(98, 13);
            this.lbl_path2.TabIndex = 5;
            this.lbl_path2.Text = "Куда перемещать";
            // 
            // lbl_mask
            // 
            this.lbl_mask.AutoSize = true;
            this.lbl_mask.Location = new System.Drawing.Point(16, 111);
            this.lbl_mask.Name = "lbl_mask";
            this.lbl_mask.Size = new System.Drawing.Size(147, 13);
            this.lbl_mask.TabIndex = 5;
            this.lbl_mask.Text = "Какую маску использовать";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(16, 160);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(388, 13);
            this.lbl_info.TabIndex = 6;
            this.lbl_info.Text = "EpicMorg File Mover 1.1;   (C) 2013, STAM - GUI,   Kasthack - Code,   More info:";
            // 
            // lnk_info
            // 
            this.lnk_info.AutoSize = true;
            this.lnk_info.Location = new System.Drawing.Point(410, 160);
            this.lnk_info.Name = "lnk_info";
            this.lnk_info.Size = new System.Drawing.Size(108, 13);
            this.lnk_info.TabIndex = 7;
            this.lnk_info.TabStop = true;
            this.lnk_info.Text = "http://ww.epicm.org/";
            this.lnk_info.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_info_LinkClicked);
            // 
            // pic_icon
            // 
            this.pic_icon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_icon.Image = global::EMFILEMOVER.Properties.Resources.thedir;
            this.pic_icon.Location = new System.Drawing.Point(12, 12);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(48, 48);
            this.pic_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_icon.TabIndex = 8;
            this.pic_icon.TabStop = false;
            // 
            // lbl_process
            // 
            this.lbl_process.AutoSize = true;
            this.lbl_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_process.Location = new System.Drawing.Point(220, 26);
            this.lbl_process.Name = "lbl_process";
            this.lbl_process.Size = new System.Drawing.Size(139, 18);
            this.lbl_process.TabIndex = 9;
            this.lbl_process.Text = "Готово к работе";
            // 
            // gb_null
            // 
            this.gb_null.Controls.Add(this.txt_path1);
            this.gb_null.Controls.Add(this.txt_path2);
            this.gb_null.Controls.Add(this.txt_mask);
            this.gb_null.Controls.Add(this.lnk_info);
            this.gb_null.Controls.Add(this.btn_path1);
            this.gb_null.Controls.Add(this.lbl_info);
            this.gb_null.Controls.Add(this.btn_path2);
            this.gb_null.Controls.Add(this.lbl_mask);
            this.gb_null.Controls.Add(this.btn_move);
            this.gb_null.Controls.Add(this.lbl_path2);
            this.gb_null.Controls.Add(this.lbl_path1);
            this.gb_null.Location = new System.Drawing.Point(12, 66);
            this.gb_null.Name = "gb_null";
            this.gb_null.Size = new System.Drawing.Size(555, 189);
            this.gb_null.TabIndex = 10;
            this.gb_null.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 269);
            this.Controls.Add(this.gb_null);
            this.Controls.Add(this.lbl_process);
            this.Controls.Add(this.pic_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EpicMorg File Mover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.gb_null.ResumeLayout(false);
            this.gb_null.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_path1;
        private System.Windows.Forms.TextBox txt_path2;
        private System.Windows.Forms.ComboBox txt_mask;
        private System.Windows.Forms.Button btn_path1;
        private System.Windows.Forms.Button btn_path2;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Label lbl_path1;
        private System.Windows.Forms.Label lbl_path2;
        private System.Windows.Forms.Label lbl_mask;
        private System.Windows.Forms.FolderBrowserDialog dialog_browse1;
        private System.Windows.Forms.FolderBrowserDialog dialog_browse2;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.LinkLabel lnk_info;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label lbl_process;
        private System.Windows.Forms.GroupBox gb_null;
    }
}

