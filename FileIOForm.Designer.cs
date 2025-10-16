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
            btnExportJson = new Button();
            SuspendLayout();
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(79, 49);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(94, 57);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(79, 135);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(94, 59);
            btnExportCsv.TabIndex = 1;
            btnExportCsv.Text = "Export data as CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnExportJson
            // 
            btnExportJson.Location = new Point(79, 224);
            btnExportJson.Name = "btnExportJson";
            btnExportJson.Size = new Size(94, 59);
            btnExportJson.TabIndex = 2;
            btnExportJson.Text = "Export data as JSON";
            btnExportJson.UseVisualStyleBackColor = true;
            btnExportJson.Click += btnExportJson_Click;
            // 
            // FileIOForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportJson);
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
        private Button btnExportJson;
    }
}
