namespace Nuitka_MakeCommnad {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.smpf = new System.Windows.Forms.Button();
            this.path_txtbox = new System.Windows.Forms.TextBox();
            this.NoConsole_tgl = new System.Windows.Forms.CheckBox();
            this.One_File_tgl = new System.Windows.Forms.CheckBox();
            this.Standard_tgl = new System.Windows.Forms.CheckBox();
            this.icon_txt = new System.Windows.Forms.TextBox();
            this.icon_Btn = new System.Windows.Forms.Button();
            this.plugin_list = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Editor_text_box = new System.Windows.Forms.RichTextBox();
            this.Excuse_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smpf
            // 
            this.smpf.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.smpf.Location = new System.Drawing.Point(31, 81);
            this.smpf.Name = "smpf";
            this.smpf.Size = new System.Drawing.Size(327, 46);
            this.smpf.TabIndex = 0;
            this.smpf.Text = "SelectMainPythonFile";
            this.smpf.UseVisualStyleBackColor = true;
            this.smpf.Click += new System.EventHandler(this.smpf_Click);
            // 
            // path_txtbox
            // 
            this.path_txtbox.BackColor = System.Drawing.Color.White;
            this.path_txtbox.Enabled = false;
            this.path_txtbox.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.path_txtbox.ForeColor = System.Drawing.Color.Black;
            this.path_txtbox.Location = new System.Drawing.Point(364, 89);
            this.path_txtbox.Name = "path_txtbox";
            this.path_txtbox.ReadOnly = true;
            this.path_txtbox.Size = new System.Drawing.Size(828, 33);
            this.path_txtbox.TabIndex = 1;
            // 
            // NoConsole_tgl
            // 
            this.NoConsole_tgl.Appearance = System.Windows.Forms.Appearance.Button;
            this.NoConsole_tgl.AutoSize = true;
            this.NoConsole_tgl.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NoConsole_tgl.Location = new System.Drawing.Point(113, 330);
            this.NoConsole_tgl.Name = "NoConsole_tgl";
            this.NoConsole_tgl.Size = new System.Drawing.Size(186, 35);
            this.NoConsole_tgl.TabIndex = 2;
            this.NoConsole_tgl.Text = "No_Console_OFF";
            this.NoConsole_tgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoConsole_tgl.UseVisualStyleBackColor = true;
            this.NoConsole_tgl.CheckedChanged += new System.EventHandler(this.NoConsole_tgl_CheckedChanged);
            // 
            // One_File_tgl
            // 
            this.One_File_tgl.Appearance = System.Windows.Forms.Appearance.Button;
            this.One_File_tgl.AutoSize = true;
            this.One_File_tgl.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.One_File_tgl.Location = new System.Drawing.Point(132, 219);
            this.One_File_tgl.Name = "One_File_tgl";
            this.One_File_tgl.Size = new System.Drawing.Size(155, 35);
            this.One_File_tgl.TabIndex = 3;
            this.One_File_tgl.Text = "One_File_OFF";
            this.One_File_tgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.One_File_tgl.UseVisualStyleBackColor = true;
            this.One_File_tgl.CheckedChanged += new System.EventHandler(this.One_File_OFF_CheckedChanged);
            // 
            // Standard_tgl
            // 
            this.Standard_tgl.Appearance = System.Windows.Forms.Appearance.Button;
            this.Standard_tgl.AutoSize = true;
            this.Standard_tgl.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Standard_tgl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Standard_tgl.Location = new System.Drawing.Point(127, 274);
            this.Standard_tgl.Name = "Standard_tgl";
            this.Standard_tgl.Size = new System.Drawing.Size(181, 35);
            this.Standard_tgl.TabIndex = 4;
            this.Standard_tgl.Text = "Standalone_OFF";
            this.Standard_tgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Standard_tgl.UseVisualStyleBackColor = true;
            this.Standard_tgl.CheckedChanged += new System.EventHandler(this.Standard_tgl_CheckedChanged);
            // 
            // icon_txt
            // 
            this.icon_txt.BackColor = System.Drawing.Color.White;
            this.icon_txt.Enabled = false;
            this.icon_txt.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.icon_txt.ForeColor = System.Drawing.Color.Black;
            this.icon_txt.Location = new System.Drawing.Point(364, 157);
            this.icon_txt.Name = "icon_txt";
            this.icon_txt.ReadOnly = true;
            this.icon_txt.Size = new System.Drawing.Size(828, 33);
            this.icon_txt.TabIndex = 6;
            // 
            // icon_Btn
            // 
            this.icon_Btn.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.icon_Btn.Location = new System.Drawing.Point(90, 149);
            this.icon_Btn.Name = "icon_Btn";
            this.icon_Btn.Size = new System.Drawing.Size(221, 46);
            this.icon_Btn.TabIndex = 5;
            this.icon_Btn.Text = "SelectIconFile";
            this.icon_Btn.UseVisualStyleBackColor = true;
            this.icon_Btn.Click += new System.EventHandler(this.icon_Btn_Click);
            // 
            // plugin_list
            // 
            this.plugin_list.CheckOnClick = true;
            this.plugin_list.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plugin_list.FormattingEnabled = true;
            this.plugin_list.Items.AddRange(new object[] {
            "anti-bloat",
            "data-files",
            "dill-compat",
            "enum-compat",
            "eventlet",
            "gevent",
            "glfw",
            "implicit-imports",
            "multiprocessing",
            "numpy",
            "pbr-compat",
            "pkg-resources",
            "pmw-freezer",
            "pylint-warnings",
            "pyqt5",
            "pyside2",
            "pyside6",
            "pyzmq",
            "tensorflow",
            "tk-inter",
            "torch"});
            this.plugin_list.Location = new System.Drawing.Point(102, 419);
            this.plugin_list.Name = "plugin_list";
            this.plugin_list.Size = new System.Drawing.Size(236, 184);
            this.plugin_list.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(129, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Opstion_Select";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Location = new System.Drawing.Point(369, 635);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(175, 51);
            this.Edit_Btn.TabIndex = 9;
            this.Edit_Btn.Text = "EditCommand";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Edit_Command_Image";
            // 
            // Editor_text_box
            // 
            this.Editor_text_box.BackColor = System.Drawing.Color.Black;
            this.Editor_text_box.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Editor_text_box.ForeColor = System.Drawing.Color.White;
            this.Editor_text_box.Location = new System.Drawing.Point(369, 282);
            this.Editor_text_box.Name = "Editor_text_box";
            this.Editor_text_box.ReadOnly = true;
            this.Editor_text_box.Size = new System.Drawing.Size(823, 321);
            this.Editor_text_box.TabIndex = 12;
            this.Editor_text_box.Text = "";
            // 
            // Excuse_Btn
            // 
            this.Excuse_Btn.Enabled = false;
            this.Excuse_Btn.Location = new System.Drawing.Point(550, 635);
            this.Excuse_Btn.Name = "Excuse_Btn";
            this.Excuse_Btn.Size = new System.Drawing.Size(177, 51);
            this.Excuse_Btn.TabIndex = 13;
            this.Excuse_Btn.Text = "Execuse";
            this.Excuse_Btn.UseVisualStyleBackColor = true;
            this.Excuse_Btn.Click += new System.EventHandler(this.Excuse_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 54);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sorry\r\nExecuse Button is currently under development.\r\nI\'d be happy to do a commi" +
    "t push or merge request.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 722);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Excuse_Btn);
            this.Controls.Add(this.Editor_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plugin_list);
            this.Controls.Add(this.icon_txt);
            this.Controls.Add(this.icon_Btn);
            this.Controls.Add(this.Standard_tgl);
            this.Controls.Add(this.One_File_tgl);
            this.Controls.Add(this.NoConsole_tgl);
            this.Controls.Add(this.path_txtbox);
            this.Controls.Add(this.smpf);
            this.Name = "Form1";
            this.Text = "Nuitka_Command_Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button smpf;
        private System.Windows.Forms.TextBox path_txtbox;
        private System.Windows.Forms.CheckBox NoConsole_tgl;
        private System.Windows.Forms.CheckBox One_File_tgl;
        private System.Windows.Forms.CheckBox Standard_tgl;
        private System.Windows.Forms.TextBox icon_txt;
        private System.Windows.Forms.Button icon_Btn;
        private System.Windows.Forms.CheckedListBox plugin_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Editor_text_box;
        private System.Windows.Forms.Button Excuse_Btn;
        private System.Windows.Forms.Label label3;
    }
}

