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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteName
            // 
            this.noteName.Location = new System.Drawing.Point(165, 16);
            this.noteName.Margin = new System.Windows.Forms.Padding(4);
            this.noteName.Name = "noteName";
            this.noteName.Size = new System.Drawing.Size(209, 25);
            this.noteName.TabIndex = 0;
            // 
            // noteDescription
            // 
            this.noteDescription.Location = new System.Drawing.Point(16, 50);
            this.noteDescription.Margin = new System.Windows.Forms.Padding(4);
            this.noteDescription.Multiline = true;
            this.noteDescription.Name = "noteDescription";
            this.noteDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteDescription.Size = new System.Drawing.Size(359, 249);
            this.noteDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название заметки";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(276, 344);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(213, 309);
            this.priorityBox.Margin = new System.Windows.Forms.Padding(4);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(160, 25);
            this.priorityBox.TabIndex = 4;
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Location = new System.Drawing.Point(16, 309);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(71, 25);
            this.buttonChangeColor.TabIndex = 5;
            this.buttonChangeColor.Text = "Цвет";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            // 
            // AddOrEditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 388);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteDescription);
            this.Controls.Add(this.noteName);
            this.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonChangeColor;
    }
}