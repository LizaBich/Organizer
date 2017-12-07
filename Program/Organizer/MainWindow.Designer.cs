namespace Organizer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainControl = new System.Windows.Forms.TabControl();
            this.CalendarEvent = new System.Windows.Forms.TabPage();
            this.eventsList = new System.Windows.Forms.ListView();
            this.buttonEventDelete = new System.Windows.Forms.Button();
            this.buttonEventEdit = new System.Windows.Forms.Button();
            this.buttonEventAdd = new System.Windows.Forms.Button();
            this.eventDescription = new System.Windows.Forms.TextBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Note = new System.Windows.Forms.TabPage();
            this.labelPriority = new System.Windows.Forms.Label();
            this.notesList = new System.Windows.Forms.ListView();
            this.buttonNoteDelete = new System.Windows.Forms.Button();
            this.buttonNoteEdit = new System.Windows.Forms.Button();
            this.noteDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.nameForSearch = new System.Windows.Forms.TextBox();
            this.buttonNoteAdd = new System.Windows.Forms.Button();
            this.labelNoteChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainControl.SuspendLayout();
            this.CalendarEvent.SuspendLayout();
            this.Note.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainControl
            // 
            this.MainControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainControl.Controls.Add(this.CalendarEvent);
            this.MainControl.Controls.Add(this.Note);
            this.MainControl.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainControl.HotTrack = true;
            this.MainControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainControl.Location = new System.Drawing.Point(1, 1);
            this.MainControl.Multiline = true;
            this.MainControl.Name = "MainControl";
            this.MainControl.SelectedIndex = 0;
            this.MainControl.Size = new System.Drawing.Size(800, 486);
            this.MainControl.TabIndex = 0;
            // 
            // CalendarEvent
            // 
            this.CalendarEvent.BackColor = System.Drawing.Color.Gainsboro;
            this.CalendarEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CalendarEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CalendarEvent.Controls.Add(this.eventsList);
            this.CalendarEvent.Controls.Add(this.buttonEventDelete);
            this.CalendarEvent.Controls.Add(this.buttonEventEdit);
            this.CalendarEvent.Controls.Add(this.buttonEventAdd);
            this.CalendarEvent.Controls.Add(this.eventDescription);
            this.CalendarEvent.Controls.Add(this.monthCalendar);
            this.CalendarEvent.Location = new System.Drawing.Point(28, 4);
            this.CalendarEvent.Name = "CalendarEvent";
            this.CalendarEvent.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarEvent.Size = new System.Drawing.Size(768, 478);
            this.CalendarEvent.TabIndex = 0;
            this.CalendarEvent.Text = "Events";
            // 
            // eventsList
            // 
            this.eventsList.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsList.Location = new System.Drawing.Point(14, 181);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(221, 247);
            this.eventsList.TabIndex = 9;
            this.eventsList.UseCompatibleStateImageBehavior = false;
            this.eventsList.View = System.Windows.Forms.View.Tile;
            // 
            // buttonEventDelete
            // 
            this.buttonEventDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEventDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEventDelete.BackgroundImage")));
            this.buttonEventDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEventDelete.Location = new System.Drawing.Point(667, 434);
            this.buttonEventDelete.Name = "buttonEventDelete";
            this.buttonEventDelete.Size = new System.Drawing.Size(42, 39);
            this.buttonEventDelete.TabIndex = 8;
            this.buttonEventDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEventEdit
            // 
            this.buttonEventEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEventEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEventEdit.BackgroundImage")));
            this.buttonEventEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEventEdit.Location = new System.Drawing.Point(715, 434);
            this.buttonEventEdit.Name = "buttonEventEdit";
            this.buttonEventEdit.Size = new System.Drawing.Size(43, 40);
            this.buttonEventEdit.TabIndex = 7;
            this.buttonEventEdit.UseVisualStyleBackColor = true;
            // 
            // buttonEventAdd
            // 
            this.buttonEventAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEventAdd.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEventAdd.Location = new System.Drawing.Point(160, 443);
            this.buttonEventAdd.Name = "buttonEventAdd";
            this.buttonEventAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonEventAdd.TabIndex = 6;
            this.buttonEventAdd.Text = "Добавить";
            this.buttonEventAdd.UseVisualStyleBackColor = true;
            this.buttonEventAdd.Click += new System.EventHandler(this.ButtonEventAdd_Click);
            // 
            // eventDescription
            // 
            this.eventDescription.Enabled = false;
            this.eventDescription.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDescription.Location = new System.Drawing.Point(255, 7);
            this.eventDescription.Multiline = true;
            this.eventDescription.Name = "eventDescription";
            this.eventDescription.Size = new System.Drawing.Size(503, 421);
            this.eventDescription.TabIndex = 2;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(42, 7);
            this.monthCalendar.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.Gainsboro;
            this.Note.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Note.Controls.Add(this.label1);
            this.Note.Controls.Add(this.label2);
            this.Note.Controls.Add(this.labelNoteChange);
            this.Note.Controls.Add(this.labelPriority);
            this.Note.Controls.Add(this.notesList);
            this.Note.Controls.Add(this.buttonNoteDelete);
            this.Note.Controls.Add(this.buttonNoteEdit);
            this.Note.Controls.Add(this.noteDescription);
            this.Note.Controls.Add(this.groupBox1);
            this.Note.Controls.Add(this.buttonNoteAdd);
            this.Note.Location = new System.Drawing.Point(28, 4);
            this.Note.Name = "Note";
            this.Note.Padding = new System.Windows.Forms.Padding(3);
            this.Note.Size = new System.Drawing.Size(768, 478);
            this.Note.TabIndex = 1;
            this.Note.Text = "Notes";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriority.Location = new System.Drawing.Point(356, 432);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(0, 19);
            this.labelPriority.TabIndex = 7;
            // 
            // notesList
            // 
            this.notesList.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notesList.Location = new System.Drawing.Point(14, 67);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(221, 362);
            this.notesList.TabIndex = 6;
            this.notesList.UseCompatibleStateImageBehavior = false;
            this.notesList.View = System.Windows.Forms.View.Tile;
            // 
            // buttonNoteDelete
            // 
            this.buttonNoteDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNoteDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNoteDelete.BackgroundImage")));
            this.buttonNoteDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNoteDelete.Location = new System.Drawing.Point(667, 434);
            this.buttonNoteDelete.Name = "buttonNoteDelete";
            this.buttonNoteDelete.Size = new System.Drawing.Size(42, 39);
            this.buttonNoteDelete.TabIndex = 5;
            this.buttonNoteDelete.UseVisualStyleBackColor = true;
            // 
            // buttonNoteEdit
            // 
            this.buttonNoteEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNoteEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNoteEdit.BackgroundImage")));
            this.buttonNoteEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNoteEdit.Location = new System.Drawing.Point(715, 434);
            this.buttonNoteEdit.Name = "buttonNoteEdit";
            this.buttonNoteEdit.Size = new System.Drawing.Size(43, 40);
            this.buttonNoteEdit.TabIndex = 4;
            this.buttonNoteEdit.UseVisualStyleBackColor = true;
            // 
            // noteDescription
            // 
            this.noteDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteDescription.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteDescription.Location = new System.Drawing.Point(255, 7);
            this.noteDescription.Multiline = true;
            this.noteDescription.Name = "noteDescription";
            this.noteDescription.Size = new System.Drawing.Size(503, 422);
            this.noteDescription.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.nameForSearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(166, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(62, 25);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // nameForSearch
            // 
            this.nameForSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameForSearch.Location = new System.Drawing.Point(7, 20);
            this.nameForSearch.Name = "nameForSearch";
            this.nameForSearch.Size = new System.Drawing.Size(153, 25);
            this.nameForSearch.TabIndex = 0;
            // 
            // buttonNoteAdd
            // 
            this.buttonNoteAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNoteAdd.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNoteAdd.Location = new System.Drawing.Point(160, 443);
            this.buttonNoteAdd.Name = "buttonNoteAdd";
            this.buttonNoteAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonNoteAdd.TabIndex = 1;
            this.buttonNoteAdd.Text = "Добавить";
            this.buttonNoteAdd.UseVisualStyleBackColor = true;
            // 
            // labelNoteChange
            // 
            this.labelNoteChange.AutoSize = true;
            this.labelNoteChange.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoteChange.Location = new System.Drawing.Point(383, 454);
            this.labelNoteChange.Name = "labelNoteChange";
            this.labelNoteChange.Size = new System.Drawing.Size(0, 19);
            this.labelNoteChange.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата изменения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(251, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Приоритет: ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(801, 487);
            this.Controls.Add(this.MainControl);
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "MainWindow";
            this.Text = "Organizer";
            this.MainControl.ResumeLayout(false);
            this.CalendarEvent.ResumeLayout(false);
            this.CalendarEvent.PerformLayout();
            this.Note.ResumeLayout(false);
            this.Note.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainControl;
        private System.Windows.Forms.TabPage CalendarEvent;
        private System.Windows.Forms.TabPage Note;
        private System.Windows.Forms.TextBox noteDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox nameForSearch;
        private System.Windows.Forms.Button buttonNoteAdd;
        private System.Windows.Forms.Button buttonNoteDelete;
        private System.Windows.Forms.Button buttonNoteEdit;
        private System.Windows.Forms.ListView notesList;
        private System.Windows.Forms.Button buttonEventDelete;
        private System.Windows.Forms.Button buttonEventEdit;
        private System.Windows.Forms.Button buttonEventAdd;
        private System.Windows.Forms.TextBox eventDescription;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ListView eventsList;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelNoteChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

