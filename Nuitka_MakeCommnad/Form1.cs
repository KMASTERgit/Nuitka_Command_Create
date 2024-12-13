using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Nuitka_MakeCommnad {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// SelectPythonFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smpf_Click(object sender , EventArgs e) {
            string filefilter = "PythonFile(*.py)|*.py";
            string getpyfile = GetfileAction(filefilter);
            GC.Collect();
            string encode = File.ReadAllText(getpyfile , Encoding.GetEncoding("UTF-8"));
            string target = "if __name__ == \"__main__\":";
            bool tof = encode.Contains(target);
            GC.Collect();
            if ( tof ) {
                this.path_txtbox.Text = getpyfile;
            } else {
                this.path_txtbox.Text = null;
                MessageBox.Show("Please Main Func 【if __name__ == \"__main__\":】" ,
                    "Error" ,
                    MessageBoxButtons.OK ,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// NoconsoleToggle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoConsole_tgl_CheckedChanged(object sender , EventArgs e) {
            if ( this.NoConsole_tgl.Checked ) {
                this.NoConsole_tgl.Text = "No_Console_ON";
            } else {
                this.NoConsole_tgl.Text = "No_Console_OFF";
            }
        }

        /// <summary>
        /// OneFileToggle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void One_File_OFF_CheckedChanged(object sender , EventArgs e) {
            if ( this.One_File_tgl.Checked ) {
                this.One_File_tgl.Text = "One_File_ON";
            } else {
                this.One_File_tgl.Text = "One_File_OFF";
            }
        }

        /// <summary>
        ///StandardTggle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Standard_tgl_CheckedChanged(object sender , EventArgs e) {
            if ( this.Standard_tgl.Checked ) {
                this.Standard_tgl.Text = "Standalone_ON";
            } else {
                this.Standard_tgl.Text = "Standalone_OFF";
            }
        }

        /// <summary>
        /// iconselect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void icon_Btn_Click(object sender , EventArgs e) {
            string filefilter = "Icon(*.ico)|*.ico";
            string getfile = GetfileAction(filefilter);
            this.icon_txt.Text = getfile;
        }

        /// <summary>
        /// FileSelector
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Filename or Null</returns>
        private string GetfileAction(string filter) {
            GC.Collect();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = filter;
            ofd.Title = "Chose Open File.";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            GC.Collect();
            if ( ofd.ShowDialog() == DialogResult.OK ) {
                return ofd.FileName;
            } else {
                return null;
            }
        }

        /// <summary>
        /// CommandEdit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Btn_Click(object sender , EventArgs e) {
            if ( this.path_txtbox.TextLength == 0 ) {
                MessageBox.Show("Not Select Python File." ,
                        "Error" ,
                        MessageBoxButtons.OK ,
                        MessageBoxIcon.Error);
            } else {
                string resultCommand = EditCommand();
                Change_string_nitka(resultCommand);
            }
        }

        /// <summary>
        /// ExecuteCommand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Excuse_Btn_Click(object sender , EventArgs e) {
            if ( this.Editor_text_box.TextLength == 0 ) {
                MessageBox.Show("Generate Command" ,
                        "Error" ,
                        MessageBoxButtons.OK ,
                        MessageBoxIcon.Error);
            } else {
                string [] split_path = this.path_txtbox.Text.Split('\\');

                string sarchPath = Sarch_venv_File(split_path);
                IEnumerable<string> ps1_file = Directory.EnumerateFiles(sarchPath , "*.ps1" , SearchOption.AllDirectories);
                GC.Collect();
                string ps1_path = ps1_file.First();
                PowershellInstance(sarchPath , ps1_path);
                ResetObject();
            }
        }

        /// <summary>
        /// poworShellInstance
        /// </summary>
        /// <param name="cdPath"></param>
        /// <param name="ps1Path"></param>
        private void PowershellInstance(string cdPath , string ps1Path) {
            string command = null;
            string cdHead = cdPath.Split('\\') [ 0 ];
            command = "cd " + cdHead;
            if ( ps1Path != null ) {
                command += "-ExecutionPolicy Bypass -File " + ps1Path;
            }
            command += " " + this.Editor_text_box.Text;
            this.Excuse_Btn.Enabled = false;

            DialogResult msg = MessageBox.Show("It takes time to build, is that OK?" ,
                "confirmation" ,
                 MessageBoxButtons.YesNo ,
                 MessageBoxIcon.Question ,
                 MessageBoxDefaultButton.Button1
                );

            GC.Collect();
            // Setting Start Process
            ProcessStartInfo processStartInfo = new ProcessStartInfo {
                FileName = "cmd.exe" ,
                Arguments = "/c " + command ,
                CreateNoWindow = false ,
                UseShellExecute = true
            };
            if ( msg == DialogResult.Yes ) {
                GC.Collect();
                try {
                    // Start Process
                    using ( Process process = Process.Start(processStartInfo) ) {
                        // Wait End Process
                        process.WaitForExit();
                    }
                    GC.Collect();
                    MessageBox.Show("Build Sucsess" ,
                        "Sucsess" ,
                        MessageBoxButtons.OK
                        );
                    this.Excuse_Btn.Enabled = true;
                    GC.Collect();
                } catch ( Exception ex ) {
                    MessageBox.Show($"Build Error: {ex.Message}" ,
                        "Error" ,
                        MessageBoxButtons.OK ,
                        MessageBoxIcon.Error);
                    this.Excuse_Btn.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Sarch Python venv File
        /// </summary>
        /// <param name="split_path"></param>
        /// <returns>venvPath</returns>
        private string Sarch_venv_File(string [] split_path) {
            string sarch_venv_path = split_path [ 0 ];
            for ( int i = 1 ; i < split_path.Length - 1 ; i++ ) {
                sarch_venv_path += "\\" + split_path [ i ];
            }
            GC.Collect();
            return sarch_venv_path;
        }

        /// <summary>
        /// Reset Object
        /// </summary>
        private void ResetObject() {
            GC.Collect();
            this.path_txtbox.Text = string.Empty;
            this.icon_txt.Text = string.Empty;
            this.One_File_tgl.Text = "One_File_OFF";
            this.One_File_tgl.Checked = false;
            this.Standard_tgl.Text = "Standalone_OFF";
            this.Standard_tgl.Checked = false;
            this.NoConsole_tgl.Text = "No_Console_OFF";
            this.NoConsole_tgl.Checked = false;
            GC.Collect();
            for ( int i = 0 ; i < this.plugin_list.Items.Count ; i++ ) {
                this.plugin_list.SetItemChecked(i , false);
            }
            GC.Collect();
            this.plugin_list.ClearSelected();
            this.Editor_text_box.Text = string.Empty;
        }

        /// <summary>
        /// set string and ColorChange
        /// </summary>
        /// <param name="resultCommand"></param>
        private void Change_string_nitka(string resultCommand) {
            this.Editor_text_box.Text = resultCommand;
            int currentSelectionStart = this.Editor_text_box.SelectionStart;
            int currentSelectionLength = this.Editor_text_box.SelectionLength;
            this.Editor_text_box.Select(0 , 0);
            this.Editor_text_box.SelectionLength = 6;
            this.Editor_text_box.SelectionColor = Color.Yellow;
            this.Editor_text_box.Select(currentSelectionStart , currentSelectionLength);
        }

        /// <summary>
        /// CommandEdit Func
        /// </summary>
        /// <returns>command</returns>
        private string EditCommand() {
            string blank = " ";
            string retunCommand = "Nuitka";

            GC.Collect();
            if ( this.icon_txt.TextLength != 0 ) {
                retunCommand += blank + "--windows-icon-from-ico=" + this.icon_txt.Text;
            }

            GC.Collect();
            if ( this.One_File_tgl.Checked ) {
                retunCommand += blank + "--onefile";
            }
            if ( this.Standard_tgl.Checked ) {
                retunCommand += blank + "--standalone";
            }
            if ( this.NoConsole_tgl.Checked ) {
                retunCommand += blank + "--windows-console-mode=disable";
            }
            GC.Collect();
            List<string> getItemList = GetSeletctOpstions();
            if ( 0 < getItemList.Count ) {
                retunCommand += blank + "--plugin-enable=" + getItemList.First();
                foreach ( string getItem in getItemList.Skip(1) ) {
                    retunCommand += "," + getItem;
                }
                GC.Collect();
            }
            GC.Collect();
            retunCommand += blank + this.path_txtbox.Text;
            return retunCommand;
        }

        /// <summary>
        /// checkSelectList
        /// </summary>
        /// <returns>checkItemName</returns>
        private List<string> GetSeletctOpstions() {
            List<string> checkItemList = new List<string>();
            foreach ( string checkItem in this.plugin_list.CheckedItems ) {
                checkItemList.Add(checkItem);
            }
            GC.Collect();
            return checkItemList;
        }
    }
}
