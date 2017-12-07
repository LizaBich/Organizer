namespace Organizer
{
    partial class AddOrEditNote
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
            this.noteName = new System.Windows.Forms.TextBox();
            this.noteDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // noteName
            // 
            this.noteName.Location = new System.Drawing.Point(124, 12);
            this.noteName.Name = "noteName";
            this.noteName.Size = new System.Drawing.Size(158, 20);
            this.noteName.TabIndex = 0;
            // 
            // noteDescription
            // 
            this.noteDescription.Location = new System.Drawing.Point(12, 38);
            this.noteDescription.Multiline = true;
            this.noteDescription.Name = "noteDescription";
            this.noteDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteDescription.Size = new System.Drawing.Size(270, 191);
            this.noteDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название заметки";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(207, 263);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(160, 236);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(121, 21);
            this.priorityBox.TabIndex = 4;
            // 
            // AddOrEditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 297);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteDescription);
            this.Controls.Add(this.noteName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddOrEditNote";
            this.Text = "AddOrEditNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteName;
        private System.Windows.Forms.TextBox noteDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox priorityBox;
    }
}