namespace PetsDB_test1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.labelSave = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PetOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PetKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PetBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PetGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PetAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_NewFile = new System.Windows.Forms.Button();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.button_OpenFile = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Sort = new System.Windows.Forms.Button();
            this.comboBoxChoiceSort = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Moccasin;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.менюToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(586, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.Moccasin;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.создатьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.BackColor = System.Drawing.Color.Moccasin;
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.BackColor = System.Drawing.Color.Moccasin;
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеСтрокToolStripMenuItem,
            this.поискСтрокToolStripMenuItem,
            this.удалитьВсёToolStripMenuItem});
            this.менюToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.менюToolStripMenuItem.Text = "Команды";
            // 
            // добавлениеСтрокToolStripMenuItem
            // 
            this.добавлениеСтрокToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.добавлениеСтрокToolStripMenuItem.Name = "добавлениеСтрокToolStripMenuItem";
            this.добавлениеСтрокToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.добавлениеСтрокToolStripMenuItem.Text = "Добавление строк";
            this.добавлениеСтрокToolStripMenuItem.Click += new System.EventHandler(this.добавлениеСтрокToolStripMenuItem_Click);
            // 
            // поискСтрокToolStripMenuItem
            // 
            this.поискСтрокToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.поискСтрокToolStripMenuItem.Name = "поискСтрокToolStripMenuItem";
            this.поискСтрокToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.поискСтрокToolStripMenuItem.Text = "Поиск строк";
            this.поискСтрокToolStripMenuItem.Click += new System.EventHandler(this.поискСтрокToolStripMenuItem_Click);
            // 
            // удалитьВсёToolStripMenuItem
            // 
            this.удалитьВсёToolStripMenuItem.BackColor = System.Drawing.Color.NavajoWhite;
            this.удалитьВсёToolStripMenuItem.Name = "удалитьВсёToolStripMenuItem";
            this.удалитьВсёToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.удалитьВсёToolStripMenuItem.Text = "Удалить всё";
            this.удалитьВсёToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсёToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.BackColor = System.Drawing.Color.Crimson;
            this.labelAutoSave.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelAutoSave.Location = new System.Drawing.Point(400, 4);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(146, 17);
            this.labelAutoSave.TabIndex = 131;
            this.labelAutoSave.Text = "Автосохранение...";
            this.labelAutoSave.Visible = false;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.BackColor = System.Drawing.Color.Crimson;
            this.labelSave.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelSave.Location = new System.Drawing.Point(241, 4);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(112, 17);
            this.labelSave.TabIndex = 130;
            this.labelSave.Text = "Cохранение...";
            this.labelSave.Visible = false;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_PetOwner,
            this.Column_PetKind,
            this.Column_PetBreed,
            this.Column_PetGender,
            this.Column_PetName,
            this.Column_PetAge});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGrid.Location = new System.Drawing.Point(0, 203);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(586, 159);
            this.dataGrid.TabIndex = 133;
            this.dataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGrid_CellBeginEdit);
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            this.dataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGrid_UserDeletingRow);
            // 
            // Column_ID
            // 
            this.Column_ID.FillWeight = 2.281052F;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.MinimumWidth = 50;
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Width = 50;
            // 
            // Column_PetOwner
            // 
            this.Column_PetOwner.FillWeight = 93.9032F;
            this.Column_PetOwner.HeaderText = "Хозяин";
            this.Column_PetOwner.Name = "Column_PetOwner";
            this.Column_PetOwner.Width = 125;
            // 
            // Column_PetKind
            // 
            this.Column_PetKind.FillWeight = 147.2734F;
            this.Column_PetKind.HeaderText = "Вид";
            this.Column_PetKind.Name = "Column_PetKind";
            this.Column_PetKind.Width = 75;
            // 
            // Column_PetBreed
            // 
            this.Column_PetBreed.FillWeight = 350.2538F;
            this.Column_PetBreed.HeaderText = "Порода";
            this.Column_PetBreed.Name = "Column_PetBreed";
            this.Column_PetBreed.Width = 75;
            // 
            // Column_PetGender
            // 
            this.Column_PetGender.FillWeight = 4.108705F;
            this.Column_PetGender.HeaderText = "Пол";
            this.Column_PetGender.Name = "Column_PetGender";
            this.Column_PetGender.Width = 50;
            // 
            // Column_PetName
            // 
            this.Column_PetName.HeaderText = "Кличка";
            this.Column_PetName.Name = "Column_PetName";
            // 
            // Column_PetAge
            // 
            this.Column_PetAge.FillWeight = 2.179828F;
            this.Column_PetAge.HeaderText = "Возраст";
            this.Column_PetAge.Name = "Column_PetAge";
            this.Column_PetAge.Width = 55;
            // 
            // button_NewFile
            // 
            this.button_NewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(79)))));
            this.button_NewFile.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_NewFile.Location = new System.Drawing.Point(12, 69);
            this.button_NewFile.Name = "button_NewFile";
            this.button_NewFile.Size = new System.Drawing.Size(135, 26);
            this.button_NewFile.TabIndex = 136;
            this.button_NewFile.Text = "Новый файл";
            this.button_NewFile.UseVisualStyleBackColor = false;
            this.button_NewFile.Click += new System.EventHandler(this.button_NewFile_Click);
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(49)))), ((int)(((byte)(153)))));
            this.button_SaveFile.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_SaveFile.Location = new System.Drawing.Point(12, 133);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(135, 26);
            this.button_SaveFile.TabIndex = 135;
            this.button_SaveFile.Text = "Сохранить файл";
            this.button_SaveFile.UseVisualStyleBackColor = false;
            this.button_SaveFile.Click += new System.EventHandler(this.button_SaveFile_Click);
            // 
            // button_OpenFile
            // 
            this.button_OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(60)))), ((int)(((byte)(145)))));
            this.button_OpenFile.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OpenFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_OpenFile.Location = new System.Drawing.Point(12, 101);
            this.button_OpenFile.Name = "button_OpenFile";
            this.button_OpenFile.Size = new System.Drawing.Size(135, 26);
            this.button_OpenFile.TabIndex = 134;
            this.button_OpenFile.Text = "Открыть файл";
            this.button_OpenFile.UseVisualStyleBackColor = false;
            this.button_OpenFile.Click += new System.EventHandler(this.button_OpenFile_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.buttonDeleteAll.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDeleteAll.Location = new System.Drawing.Point(12, 165);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(135, 26);
            this.buttonDeleteAll.TabIndex = 137;
            this.buttonDeleteAll.Text = "Очистить базу данных";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(12, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(434, 42);
            this.labelTitle.TabIndex = 138;
            this.labelTitle.Text = "База питомцев и их хозяев";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Search.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.Location = new System.Drawing.Point(153, 121);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(135, 33);
            this.button_Search.TabIndex = 140;
            this.button_Search.Text = "Поиск записей";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Add.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(153, 82);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(135, 33);
            this.button_Add.TabIndex = 139;
            this.button_Add.Text = "Добавление данных";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Sort
            // 
            this.button_Sort.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Sort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sort.Location = new System.Drawing.Point(153, 160);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(96, 33);
            this.button_Sort.TabIndex = 141;
            this.button_Sort.Text = "Сортировать";
            this.button_Sort.UseVisualStyleBackColor = false;
            this.button_Sort.Click += new System.EventHandler(this.button_Sort_Click);
            // 
            // comboBoxChoiceSort
            // 
            this.comboBoxChoiceSort.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBoxChoiceSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoiceSort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChoiceSort.FormattingEnabled = true;
            this.comboBoxChoiceSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.comboBoxChoiceSort.Location = new System.Drawing.Point(255, 165);
            this.comboBoxChoiceSort.Name = "comboBoxChoiceSort";
            this.comboBoxChoiceSort.Size = new System.Drawing.Size(123, 23);
            this.comboBoxChoiceSort.TabIndex = 142;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PetsDB_test1.Properties.Resources.BackImage1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(133, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(586, 362);
            this.Controls.Add(this.comboBoxChoiceSort);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.button_NewFile);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.button_OpenFile);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(602, 400);
            this.MinimumSize = new System.Drawing.Size(602, 400);
            this.Name = "MainForm";
            this.Text = "База питомцев";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСтрокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсёToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelAutoSave;
        private System.Windows.Forms.Label labelSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PetOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PetKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PetBreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PetGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PetAge;
        private System.Windows.Forms.Button button_NewFile;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Button button_OpenFile;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.ComboBox comboBoxChoiceSort;
    }
}

