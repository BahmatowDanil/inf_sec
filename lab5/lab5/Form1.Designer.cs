
namespace lab5
{
    partial class Form1
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
            this.Output = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.GenerateKeys = new System.Windows.Forms.Button();
            this.KeysInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadFromFile = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.FileError = new System.Windows.Forms.Label();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(238, 264);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(550, 174);
            this.Output.TabIndex = 0;
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.Location = new System.Drawing.Point(238, 34);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(550, 174);
            this.Message.TabIndex = 1;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 12);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(172, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(12, 41);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(173, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // GenerateKeys
            // 
            this.GenerateKeys.Location = new System.Drawing.Point(12, 235);
            this.GenerateKeys.Name = "GenerateKeys";
            this.GenerateKeys.Size = new System.Drawing.Size(172, 23);
            this.GenerateKeys.TabIndex = 4;
            this.GenerateKeys.Text = "Сгенерировать ключи";
            this.GenerateKeys.UseVisualStyleBackColor = true;
            this.GenerateKeys.Click += new System.EventHandler(this.GenerateKeys_Click);
            // 
            // KeysInfo
            // 
            this.KeysInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeysInfo.Location = new System.Drawing.Point(12, 264);
            this.KeysInfo.Multiline = true;
            this.KeysInfo.Name = "KeysInfo";
            this.KeysInfo.ReadOnly = true;
            this.KeysInfo.Size = new System.Drawing.Size(173, 174);
            this.KeysInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результат";
            // 
            // LoadFromFile
            // 
            this.LoadFromFile.Location = new System.Drawing.Point(11, 109);
            this.LoadFromFile.Name = "LoadFromFile";
            this.LoadFromFile.Size = new System.Drawing.Size(173, 23);
            this.LoadFromFile.TabIndex = 8;
            this.LoadFromFile.Text = "Загрузить из файла";
            this.LoadFromFile.UseVisualStyleBackColor = true;
            this.LoadFromFile.Click += new System.EventHandler(this.LoadFromFile_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.Location = new System.Drawing.Point(11, 176);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(173, 23);
            this.SaveToFile.TabIndex = 9;
            this.SaveToFile.Text = "Сохранить в файл";
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileName.Location = new System.Drawing.Point(11, 148);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(172, 22);
            this.FileName.TabIndex = 10;
            // 
            // FileError
            // 
            this.FileError.AutoSize = true;
            this.FileError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileError.ForeColor = System.Drawing.Color.Red;
            this.FileError.Location = new System.Drawing.Point(12, 202);
            this.FileError.Name = "FileError";
            this.FileError.Size = new System.Drawing.Size(57, 16);
            this.FileError.TabIndex = 11;
            this.FileError.Text = "Ошибка";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileError);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.LoadFromFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeysInfo);
            this.Controls.Add(this.GenerateKeys);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button GenerateKeys;
        private System.Windows.Forms.TextBox KeysInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadFromFile;
        private System.Windows.Forms.Button SaveToFile;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label FileError;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}

