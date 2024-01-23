namespace Note_Taking_App
{
    partial class NoteTaker
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
            titleBox = new TextBox();
            noteBox = new TextBox();
            title_label = new Label();
            note_label = new Label();
            previousNotes = new DataGridView();
            load = new Button();
            delete = new Button();
            save = new Button();
            newNote = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(11, 40);
            titleBox.Margin = new Padding(2);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(560, 23);
            titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(11, 96);
            noteBox.Margin = new Padding(2);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(560, 323);
            noteBox.TabIndex = 1;
            // 
            // title_label
            // 
            title_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            title_label.ForeColor = SystemColors.ButtonHighlight;
            title_label.Location = new Point(11, 9);
            title_label.Name = "title_label";
            title_label.Size = new Size(560, 29);
            title_label.TabIndex = 2;
            title_label.Text = "Title";
            title_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // note_label
            // 
            note_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            note_label.ForeColor = SystemColors.ButtonHighlight;
            note_label.Location = new Point(11, 65);
            note_label.Name = "note_label";
            note_label.Size = new Size(560, 29);
            note_label.TabIndex = 3;
            note_label.Text = "Notes";
            note_label.TextAlign = ContentAlignment.MiddleLeft;
            note_label.Click += note_label_Click;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(580, 39);
            previousNotes.Name = "previousNotes";
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(161, 434);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // load
            // 
            load.Location = new Point(11, 424);
            load.Name = "load";
            load.Size = new Size(279, 23);
            load.TabIndex = 5;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // delete
            // 
            delete.Location = new Point(296, 424);
            delete.Name = "delete";
            delete.Size = new Size(275, 23);
            delete.TabIndex = 6;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // save
            // 
            save.Location = new Point(296, 453);
            save.Name = "save";
            save.Size = new Size(275, 23);
            save.TabIndex = 8;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // newNote
            // 
            newNote.Location = new Point(11, 453);
            newNote.Name = "newNote";
            newNote.Size = new Size(279, 23);
            newNote.TabIndex = 7;
            newNote.Text = "New Note";
            newNote.UseVisualStyleBackColor = true;
            newNote.Click += newNote_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(753, 485);
            Controls.Add(save);
            Controls.Add(newNote);
            Controls.Add(delete);
            Controls.Add(load);
            Controls.Add(previousNotes);
            Controls.Add(note_label);
            Controls.Add(title_label);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label title_label;
        private Label note_label;
        private DataGridView previousNotes;
        private Button load;
        private Button delete;
        private Button save;
        private Button newNote;
    }
}