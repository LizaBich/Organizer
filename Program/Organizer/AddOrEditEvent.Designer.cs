namespace Organizer
{
    partial class AddOrEditEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.TextBox();
            this.eventPlace = new System.Windows.Forms.TextBox();
            this.eventStart = new System.Windows.Forms.TextBox();
            this.eventEnd = new System.Windows.Forms.TextBox();
            this.eventDescription = new System.Windows.Forms.TextBox();
            this.buttonEventSave = new System.Windows.Forms.Button();
            this.buttonRepeateConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Место";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Начало";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Окончание";
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(107, 8);
            this.eventName.Margin = new System.Windows.Forms.Padding(4);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(268, 25);
            this.eventName.TabIndex = 4;
            // 
            // eventPlace
            // 
            this.eventPlace.Location = new System.Drawing.Point(107, 42);
            this.eventPlace.Margin = new System.Windows.Forms.Padding(4);
            this.eventPlace.Name = "eventPlace";
            this.eventPlace.Size = new System.Drawing.Size(268, 25);
            this.eventPlace.TabIndex = 5;
            // 
            // eventStart
            // 
            this.eventStart.Location = new System.Drawing.Point(107, 75);
            this.eventStart.Margin = new System.Windows.Forms.Padding(4);
            this.eventStart.Name = "eventStart";
            this.eventStart.Size = new System.Drawing.Size(268, 25);
            this.eventStart.TabIndex = 6;
            // 
            // eventEnd
            // 
            this.eventEnd.Location = new System.Drawing.Point(107, 109);
            this.eventEnd.Margin = new System.Windows.Forms.Padding(4);
            this.eventEnd.Name = "eventEnd";
            this.eventEnd.Size = new System.Drawing.Size(268, 25);
            this.eventEnd.TabIndex = 7;
            // 
            // eventDescription
            // 
            this.eventDescription.Location = new System.Drawing.Point(19, 143);
            this.eventDescription.Margin = new System.Windows.Forms.Padding(4);
            this.eventDescription.Multiline = true;
            this.eventDescription.Name = "eventDescription";
            this.eventDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventDescription.Size = new System.Drawing.Size(356, 103);
            this.eventDescription.TabIndex = 8;
            // 
            // buttonEventSave
            // 
            this.buttonEventSave.Location = new System.Drawing.Point(275, 256);
            this.buttonEventSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEventSave.Name = "buttonEventSave";
            this.buttonEventSave.Size = new System.Drawing.Size(100, 30);
            this.buttonEventSave.TabIndex = 9;
            this.buttonEventSave.Text = "Сохранить";
            this.buttonEventSave.UseVisualStyleBackColor = true;
            // 
            // buttonRepeateConfig
            // 
            this.buttonRepeateConfig.Location = new System.Drawing.Point(19, 256);
            this.buttonRepeateConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRepeateConfig.Name = "buttonRepeateConfig";
            this.buttonRepeateConfig.Size = new System.Drawing.Size(100, 30);
            this.buttonRepeateConfig.TabIndex = 10;
            this.buttonRepeateConfig.Text = "Настройки";
            this.buttonRepeateConfig.UseVisualStyleBackColor = true;
            // 
            // AddOrEditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 295);
            this.Controls.Add(this.buttonRepeateConfig);
            this.Controls.Add(this.buttonEventSave);
            this.Controls.Add(this.eventDescription);
            this.Controls.Add(this.eventEnd);
            this.Controls.Add(this.eventStart);
            this.Controls.Add(this.eventPlace);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrEditEvent";
            this.Text = "AddOrEditEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.TextBox eventPlace;
        private System.Windows.Forms.TextBox eventStart;
        private System.Windows.Forms.TextBox eventEnd;
        private System.Windows.Forms.TextBox eventDescription;
        private System.Windows.Forms.Button buttonEventSave;
        private System.Windows.Forms.Button buttonRepeateConfig;
    }
}