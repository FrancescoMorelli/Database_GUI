namespace Database_GUI
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Load = new System.Windows.Forms.TabPage();
            this.lbl_Load = new System.Windows.Forms.Label();
            this.txt_Load = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.tab_Search = new System.Windows.Forms.TabPage();
            this.btn_ListAllRecords = new System.Windows.Forms.Button();
            this.list_Search = new System.Windows.Forms.ListBox();
            this.cmBox_Search = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_Load.SuspendLayout();
            this.tab_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Load);
            this.tabControl1.Controls.Add(this.tab_Search);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Load
            // 
            this.tab_Load.Controls.Add(this.lbl_Load);
            this.tab_Load.Controls.Add(this.txt_Load);
            this.tab_Load.Controls.Add(this.btn_Load);
            this.tab_Load.Location = new System.Drawing.Point(4, 22);
            this.tab_Load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Load.Name = "tab_Load";
            this.tab_Load.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Load.Size = new System.Drawing.Size(516, 358);
            this.tab_Load.TabIndex = 2;
            this.tab_Load.Text = "Load";
            this.tab_Load.UseVisualStyleBackColor = true;
            // 
            // lbl_Load
            // 
            this.lbl_Load.AutoSize = true;
            this.lbl_Load.Location = new System.Drawing.Point(21, 64);
            this.lbl_Load.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Load.Name = "lbl_Load";
            this.lbl_Load.Size = new System.Drawing.Size(80, 13);
            this.lbl_Load.TabIndex = 2;
            this.lbl_Load.Text = "Load Database";
            // 
            // txt_Load
            // 
            this.txt_Load.Location = new System.Drawing.Point(116, 60);
            this.txt_Load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Load.Name = "txt_Load";
            this.txt_Load.Size = new System.Drawing.Size(270, 20);
            this.txt_Load.TabIndex = 1;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(412, 59);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(56, 19);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // tab_Search
            // 
            this.tab_Search.Controls.Add(this.btn_ListAllRecords);
            this.tab_Search.Controls.Add(this.list_Search);
            this.tab_Search.Controls.Add(this.cmBox_Search);
            this.tab_Search.Controls.Add(this.txt_Search);
            this.tab_Search.Controls.Add(this.lbl_Search);
            this.tab_Search.Controls.Add(this.btn_Search);
            this.tab_Search.Location = new System.Drawing.Point(4, 22);
            this.tab_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Search.Name = "tab_Search";
            this.tab_Search.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tab_Search.Size = new System.Drawing.Size(516, 358);
            this.tab_Search.TabIndex = 0;
            this.tab_Search.Text = "Search";
            this.tab_Search.UseVisualStyleBackColor = true;
            // 
            // btn_ListAllRecords
            // 
            this.btn_ListAllRecords.Location = new System.Drawing.Point(207, 315);
            this.btn_ListAllRecords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ListAllRecords.Name = "btn_ListAllRecords";
            this.btn_ListAllRecords.Size = new System.Drawing.Size(105, 19);
            this.btn_ListAllRecords.TabIndex = 5;
            this.btn_ListAllRecords.Text = "Show all records";
            this.btn_ListAllRecords.UseVisualStyleBackColor = true;
            this.btn_ListAllRecords.Click += new System.EventHandler(this.btn_ListAllRecords_Click);
            // 
            // list_Search
            // 
            this.list_Search.FormattingEnabled = true;
            this.list_Search.Location = new System.Drawing.Point(24, 46);
            this.list_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_Search.Name = "list_Search";
            this.list_Search.Size = new System.Drawing.Size(462, 251);
            this.list_Search.TabIndex = 4;
            this.list_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Search_MouseDown);
            // 
            // cmBox_Search
            // 
            this.cmBox_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox_Search.FormattingEnabled = true;
            this.cmBox_Search.Location = new System.Drawing.Point(92, 8);
            this.cmBox_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmBox_Search.Name = "cmBox_Search";
            this.cmBox_Search.Size = new System.Drawing.Size(92, 21);
            this.cmBox_Search.TabIndex = 3;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(207, 8);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(155, 20);
            this.txt_Search.TabIndex = 2;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(22, 11);
            this.lbl_Search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(56, 13);
            this.lbl_Search.TabIndex = 1;
            this.lbl_Search.Text = "Search for";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(394, 8);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(56, 19);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 384);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.Text = "SQL Data access";
            this.tabControl1.ResumeLayout(false);
            this.tab_Load.ResumeLayout(false);
            this.tab_Load.PerformLayout();
            this.tab_Search.ResumeLayout(false);
            this.tab_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Search;
        private System.Windows.Forms.ComboBox cmBox_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListBox list_Search;
        private System.Windows.Forms.TabPage tab_Load;
        private System.Windows.Forms.Label lbl_Load;
        private System.Windows.Forms.TextBox txt_Load;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_ListAllRecords;
    }
}

