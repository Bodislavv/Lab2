namespace science_xml_app
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            fileToolStrip = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            contentTextBox = new RichTextBox();
            linqButton = new RadioButton();
            domButton = new RadioButton();
            saxButton = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            transformButton = new Button();
            levelsComboBox = new ComboBox();
            faculcyComboBox = new ComboBox();
            cafedraComboBox = new ComboBox();
            clearButton = new Button();
            groupByLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(735, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            fileToolStrip.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStrip.Name = "fileToolStrip";
            fileToolStrip.Size = new Size(50, 20);
            fileToolStrip.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(127, 22);
            openToolStripMenuItem.Text = "Read XML";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(127, 22);
            saveToolStripMenuItem.Text = "Save XML";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // contentTextBox
            // 
            contentTextBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contentTextBox.ForeColor = Color.DimGray;
            contentTextBox.Location = new Point(15, 62);
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(434, 222);
            contentTextBox.TabIndex = 2;
            contentTextBox.Text = "";
            // 
            // linqButton
            // 
            linqButton.AutoSize = true;
            linqButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            linqButton.ForeColor = Color.FromArgb(0, 0, 64);
            linqButton.Location = new Point(380, 27);
            linqButton.Name = "linqButton";
            linqButton.Size = new Size(69, 29);
            linqButton.TabIndex = 7;
            linqButton.TabStop = true;
            linqButton.Text = "LINQ";
            linqButton.UseVisualStyleBackColor = true;
            // 
            // domButton
            // 
            domButton.AutoSize = true;
            domButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            domButton.ForeColor = Color.FromArgb(0, 0, 64);
            domButton.Location = new Point(192, 27);
            domButton.Name = "domButton";
            domButton.Size = new Size(101, 29);
            domButton.TabIndex = 6;
            domButton.TabStop = true;
            domButton.Text = "DOM API";
            domButton.UseVisualStyleBackColor = true;
            // 
            // saxButton
            // 
            saxButton.AutoSize = true;
            saxButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            saxButton.ForeColor = Color.FromArgb(0, 0, 64);
            saxButton.Location = new Point(15, 27);
            saxButton.Name = "saxButton";
            saxButton.Size = new Size(94, 29);
            saxButton.TabIndex = 5;
            saxButton.TabStop = true;
            saxButton.Text = "SAX API";
            saxButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(466, 224);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 19;
            label3.Text = "Science level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(481, 191);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 18;
            label2.Text = "Faculcy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(484, 156);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 17;
            label1.Text = "Cafedra";
            // 
            // transformButton
            // 
            transformButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            transformButton.Location = new Point(305, 290);
            transformButton.Name = "transformButton";
            transformButton.Size = new Size(144, 53);
            transformButton.TabIndex = 16;
            transformButton.Text = "XML -> HTML";
            transformButton.UseVisualStyleBackColor = true;
            transformButton.Click += xmlTranformButton_Click;
            // 
            // levelsComboBox
            // 
            levelsComboBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            levelsComboBox.FormattingEnabled = true;
            levelsComboBox.Location = new Point(565, 219);
            levelsComboBox.Name = "levelsComboBox";
            levelsComboBox.Size = new Size(158, 28);
            levelsComboBox.TabIndex = 15;
            levelsComboBox.SelectedIndexChanged += departamentComboBox_SelectedIndexChanged;
            // 
            // faculcyComboBox
            // 
            faculcyComboBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            faculcyComboBox.FormattingEnabled = true;
            faculcyComboBox.Location = new Point(565, 186);
            faculcyComboBox.Name = "faculcyComboBox";
            faculcyComboBox.Size = new Size(158, 28);
            faculcyComboBox.TabIndex = 14;
            faculcyComboBox.SelectedIndexChanged += faculcyComboBox_SelectedIndexChanged;
            // 
            // cafedraComboBox
            // 
            cafedraComboBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cafedraComboBox.FormattingEnabled = true;
            cafedraComboBox.Location = new Point(565, 153);
            cafedraComboBox.Name = "cafedraComboBox";
            cafedraComboBox.Size = new Size(158, 28);
            cafedraComboBox.TabIndex = 13;
            cafedraComboBox.SelectedIndexChanged += nameComboBox_SelectedIndexChanged;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(15, 286);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(144, 57);
            clearButton.TabIndex = 20;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // groupByLabel
            // 
            groupByLabel.AutoSize = true;
            groupByLabel.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupByLabel.ForeColor = Color.Black;
            groupByLabel.Location = new Point(527, 111);
            groupByLabel.Name = "groupByLabel";
            groupByLabel.Size = new Size(162, 29);
            groupByLabel.TabIndex = 21;
            groupByLabel.Text = "Group by criteria:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 356);
            Controls.Add(groupByLabel);
            Controls.Add(clearButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(transformButton);
            Controls.Add(levelsComboBox);
            Controls.Add(faculcyComboBox);
            Controls.Add(cafedraComboBox);
            Controls.Add(linqButton);
            Controls.Add(domButton);
            Controls.Add(saxButton);
            Controls.Add(contentTextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Кадри науковців (\"Звання\")";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStrip;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private RichTextBox contentTextBox;
        private RadioButton linqButton;
        private RadioButton domButton;
        private RadioButton saxButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button transformButton;
        private ComboBox levelsComboBox;
        private ComboBox faculcyComboBox;
        private ComboBox cafedraComboBox;
        private Button clearButton;
        private Label groupByLabel;
    }
}