namespace PetsDB_test1
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label_Search2 = new System.Windows.Forms.Label();
            this.button_SearchOK = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Search2
            // 
            this.label_Search2.AutoSize = true;
            this.label_Search2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search2.Location = new System.Drawing.Point(21, 53);
            this.label_Search2.Name = "label_Search2";
            this.label_Search2.Size = new System.Drawing.Size(296, 36);
            this.label_Search2.TabIndex = 107;
            this.label_Search2.Text = "Введите любое слово, которое хотите \r\nнайти в базе";
            this.label_Search2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_SearchOK
            // 
            this.button_SearchOK.BackColor = System.Drawing.Color.SandyBrown;
            this.button_SearchOK.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.button_SearchOK.Location = new System.Drawing.Point(12, 122);
            this.button_SearchOK.Name = "button_SearchOK";
            this.button_SearchOK.Size = new System.Drawing.Size(308, 30);
            this.button_SearchOK.TabIndex = 106;
            this.button_SearchOK.Text = "Найти данные";
            this.button_SearchOK.UseVisualStyleBackColor = false;
            this.button_SearchOK.Click += new System.EventHandler(this.button_SearchOK_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(12, 96);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(308, 20);
            this.textBox_Search.TabIndex = 105;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(130, 9);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(78, 25);
            this.label_Search.TabIndex = 104;
            this.label_Search.Text = "Поиск";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(336, 164);
            this.Controls.Add(this.label_Search2);
            this.Controls.Add(this.button_SearchOK);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "Поиск данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Search2;
        private System.Windows.Forms.Button button_SearchOK;
        public System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
    }
}