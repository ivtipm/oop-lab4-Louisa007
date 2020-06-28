namespace PetsDB_test1
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.button_AddRow = new System.Windows.Forms.Button();
            this.textBox_PetAge = new System.Windows.Forms.TextBox();
            this.label_PetAge = new System.Windows.Forms.Label();
            this.label_PetBreed = new System.Windows.Forms.Label();
            this.textBox_Gender = new System.Windows.Forms.TextBox();
            this.textBox_Breed = new System.Windows.Forms.TextBox();
            this.label_PetGender = new System.Windows.Forms.Label();
            this.comboBox_Kind = new System.Windows.Forms.ComboBox();
            this.label_PetKind = new System.Windows.Forms.Label();
            this.textBox_Owner = new System.Windows.Forms.TextBox();
            this.label_PetOwner = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.Label_ID = new System.Windows.Forms.Label();
            this.textBox_PetName = new System.Windows.Forms.TextBox();
            this.label_PetName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_AddRow
            // 
            this.button_AddRow.BackColor = System.Drawing.Color.SandyBrown;
            this.button_AddRow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddRow.Location = new System.Drawing.Point(16, 202);
            this.button_AddRow.Name = "button_AddRow";
            this.button_AddRow.Size = new System.Drawing.Size(308, 30);
            this.button_AddRow.TabIndex = 139;
            this.button_AddRow.Text = "Добавить запись";
            this.button_AddRow.UseVisualStyleBackColor = false;
            this.button_AddRow.Click += new System.EventHandler(this.button_AddRow_Click);
            // 
            // textBox_PetAge
            // 
            this.textBox_PetAge.Location = new System.Drawing.Point(114, 171);
            this.textBox_PetAge.Name = "textBox_PetAge";
            this.textBox_PetAge.Size = new System.Drawing.Size(77, 20);
            this.textBox_PetAge.TabIndex = 138;
            // 
            // label_PetAge
            // 
            this.label_PetAge.AutoSize = true;
            this.label_PetAge.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PetAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PetAge.Location = new System.Drawing.Point(13, 171);
            this.label_PetAge.Name = "label_PetAge";
            this.label_PetAge.Size = new System.Drawing.Size(64, 18);
            this.label_PetAge.TabIndex = 137;
            this.label_PetAge.Text = "Возраст";
            // 
            // label_PetBreed
            // 
            this.label_PetBreed.AutoSize = true;
            this.label_PetBreed.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PetBreed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PetBreed.Location = new System.Drawing.Point(12, 95);
            this.label_PetBreed.Name = "label_PetBreed";
            this.label_PetBreed.Size = new System.Drawing.Size(56, 18);
            this.label_PetBreed.TabIndex = 133;
            this.label_PetBreed.Text = "Порода";
            // 
            // textBox_Gender
            // 
            this.textBox_Gender.Location = new System.Drawing.Point(114, 119);
            this.textBox_Gender.Name = "textBox_Gender";
            this.textBox_Gender.Size = new System.Drawing.Size(77, 20);
            this.textBox_Gender.TabIndex = 136;
            // 
            // textBox_Breed
            // 
            this.textBox_Breed.Location = new System.Drawing.Point(114, 93);
            this.textBox_Breed.Name = "textBox_Breed";
            this.textBox_Breed.Size = new System.Drawing.Size(210, 20);
            this.textBox_Breed.TabIndex = 134;
            // 
            // label_PetGender
            // 
            this.label_PetGender.AutoSize = true;
            this.label_PetGender.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PetGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PetGender.Location = new System.Drawing.Point(13, 121);
            this.label_PetGender.Name = "label_PetGender";
            this.label_PetGender.Size = new System.Drawing.Size(32, 18);
            this.label_PetGender.TabIndex = 135;
            this.label_PetGender.Text = "Пол";
            // 
            // comboBox_Kind
            // 
            this.comboBox_Kind.FormattingEnabled = true;
            this.comboBox_Kind.Items.AddRange(new object[] {
            "Кошки",
            "Собаки",
            "Хомяки",
            "Кролики",
            "Попугаи",
            "Совы",
            "Рыбы",
            "Ящерицы",
            "Лошади",
            "Коровы",
            "Овцы"});
            this.comboBox_Kind.Location = new System.Drawing.Point(114, 66);
            this.comboBox_Kind.Name = "comboBox_Kind";
            this.comboBox_Kind.Size = new System.Drawing.Size(210, 21);
            this.comboBox_Kind.TabIndex = 132;
            // 
            // label_PetKind
            // 
            this.label_PetKind.AutoSize = true;
            this.label_PetKind.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PetKind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PetKind.Location = new System.Drawing.Point(12, 68);
            this.label_PetKind.Name = "label_PetKind";
            this.label_PetKind.Size = new System.Drawing.Size(96, 18);
            this.label_PetKind.TabIndex = 131;
            this.label_PetKind.Text = "Вид питомца";
            // 
            // textBox_Owner
            // 
            this.textBox_Owner.Location = new System.Drawing.Point(114, 40);
            this.textBox_Owner.Name = "textBox_Owner";
            this.textBox_Owner.Size = new System.Drawing.Size(210, 20);
            this.textBox_Owner.TabIndex = 130;
            // 
            // label_PetOwner
            // 
            this.label_PetOwner.AutoSize = true;
            this.label_PetOwner.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PetOwner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PetOwner.Location = new System.Drawing.Point(12, 42);
            this.label_PetOwner.Name = "label_PetOwner";
            this.label_PetOwner.Size = new System.Drawing.Size(56, 18);
            this.label_PetOwner.TabIndex = 129;
            this.label_PetOwner.Text = "Хозяин";
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ID.Location = new System.Drawing.Point(114, 14);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(77, 20);
            this.textBox_ID.TabIndex = 140;
            this.textBox_ID.TabStop = false;
            // 
            // Label_ID
            // 
            this.Label_ID.AutoSize = true;
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_ID.Location = new System.Drawing.Point(13, 18);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(23, 16);
            this.Label_ID.TabIndex = 128;
            this.Label_ID.Text = "ID";
            // 
            // textBox_PetName
            // 
            this.textBox_PetName.Location = new System.Drawing.Point(114, 145);
            this.textBox_PetName.Name = "textBox_PetName";
            this.textBox_PetName.Size = new System.Drawing.Size(210, 20);
            this.textBox_PetName.TabIndex = 142;
            // 
            // label_PetName
            // 
            this.label_PetName.AutoSize = true;
            this.label_PetName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PetName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_PetName.Location = new System.Drawing.Point(13, 145);
            this.label_PetName.Name = "label_PetName";
            this.label_PetName.Size = new System.Drawing.Size(56, 18);
            this.label_PetName.TabIndex = 141;
            this.label_PetName.Text = "Кличка";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(336, 244);
            this.Controls.Add(this.textBox_PetName);
            this.Controls.Add(this.label_PetName);
            this.Controls.Add(this.button_AddRow);
            this.Controls.Add(this.textBox_PetAge);
            this.Controls.Add(this.label_PetAge);
            this.Controls.Add(this.label_PetBreed);
            this.Controls.Add(this.textBox_Gender);
            this.Controls.Add(this.textBox_Breed);
            this.Controls.Add(this.label_PetGender);
            this.Controls.Add(this.comboBox_Kind);
            this.Controls.Add(this.label_PetKind);
            this.Controls.Add(this.textBox_Owner);
            this.Controls.Add(this.label_PetOwner);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.Label_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Добавление данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddRow;
        public System.Windows.Forms.TextBox textBox_PetAge;
        private System.Windows.Forms.Label label_PetAge;
        private System.Windows.Forms.Label label_PetBreed;
        public System.Windows.Forms.TextBox textBox_Gender;
        public System.Windows.Forms.TextBox textBox_Breed;
        private System.Windows.Forms.Label label_PetGender;
        public System.Windows.Forms.ComboBox comboBox_Kind;
        private System.Windows.Forms.Label label_PetKind;
        public System.Windows.Forms.TextBox textBox_Owner;
        private System.Windows.Forms.Label label_PetOwner;
        public System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label Label_ID;
        public System.Windows.Forms.TextBox textBox_PetName;
        private System.Windows.Forms.Label label_PetName;
    }
}