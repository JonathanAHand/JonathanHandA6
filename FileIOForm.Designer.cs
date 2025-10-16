namespace JonathanHandA6
{
    partial class FileIOForm
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
            btnChooseFile = new Button();
            btnExportCsv = new Button();
            SuspendLayout();
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(79, 49);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(94, 31);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(79, 127);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(94, 29);
            btnExportCsv.TabIndex = 1;
            btnExportCsv.Text = "Export data";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // FileIOForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportCsv);
            Controls.Add(btnChooseFile);
            Name = "FileIOForm";
            Text = "Jonathan Hand Assignment 6";
            Load += FileIOForm_Load;
            Click += btnChooseFile_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnChooseFile;
        private Button btnExportCsv;
    }
}
