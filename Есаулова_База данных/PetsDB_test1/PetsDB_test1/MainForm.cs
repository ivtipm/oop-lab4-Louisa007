using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsDB_test1
{
    public partial class MainForm : Form
    {
        public DataMethods data = new DataMethods();
        public string oldValue = "";
        public string filename = "";

        public string RowID;
        public string PetOwner;
        public string PetKind;
        public string PetBreed;
        public string PetGender;
        public string PetName;
        public string PetAge;

        public MainForm()
        {
            InitializeComponent();

            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            InitializeTimers();

            //Всплывающие подсказки для кнопок
            ToolTip t = new ToolTip();
            t.SetToolTip(button_OpenFile, "Открыть файл (Ctrl+O)");
            t.SetToolTip(button_SaveFile, "Сохранить файл (Ctrl+S)");
            t.SetToolTip(button_Search, "Поиск данных");
            t.SetToolTip(button_Add, "Добавление новых данных");
            t.SetToolTip(button_Sort, "Сортировать питомцев по возрасту");
        }

        private void InitializeTimers()
        {
            // Таймер для автосохранения данных в файл раз в 1 минуту
            timer1.Interval = 60000;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Таймер для отображения надписи, свидетельствующей о сохранении файла
            // длительностью 3 сек
            timer2.Interval = 3000;
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.SaveToFile(filename);
            labelAutoSave.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (labelAutoSave.Visible)
            {
                labelAutoSave.Visible = false;
            }
            else
            {
                labelSave.Visible = false;
            }
            timer2.Enabled = false;
            timer2.Stop();
        }

        //Создаёт порядковый ID
        public ushort generateID()
        {
            int id = data.PetsFile.Count + 1;

            for (int i = 0; i < data.PetsFile.Count; i++)
            {
                Pet pet = (Pet)data.PetsFile[i];
                if (pet.RowID == id)
                {
                    i = 0;
                    id++;
                }
            }
            return (ushort)id;
        }

        //Запрет редактирования последней строки
        public void BanChangeColumn(int index)
        {
            dataGrid.Rows[index].Cells[0].ReadOnly = true;
        }

        //Полностью очистить базу
        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (data.PetsFile.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Уверены," +
                    "что хотите удалить все элементы?",
                    "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    data.DeleteAllRows();
                    dataGrid.Rows.Clear();
                }
            }
        }

        private void удалитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDeleteAll_Click(buttonDeleteAll, null);
        }

        //Записать базу в таблицу
        private void WriteToDataGrid()
        {
            try
            {
                for (int i = 0; i < data.PetsFile.Count; i++)
                {
                    Pet pet = (Pet)data.PetsFile[i];
                    dataGrid.Rows.Add
                        (
                        pet.RowID,
                        pet.OwnerName,
                        pet.PetKind,
                        pet.PetBreed,
                        pet.PetGender,
                        pet.PetName,
                        pet.PetAge
                        );
                    BanChangeColumn(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        //Создаёт новый файл
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((data.PetsFile.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Уверены," +
                    "что хотите создать новый файл?" + "\r\n" +
                    "Изменения в текущем не сохранятся!",
                    "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База питомцев";
                    filename = "";
                    data.DeleteAllRows();
                    dataGrid.Rows.Clear();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                }
            }
        }

        private void button_NewFile_Click(object sender, EventArgs e)
        {
            создатьToolStripMenuItem_Click(создатьToolStripMenuItem, null);
        }

        //Открывает файл и считывает из него базу
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                filename = openFileDialog1.FileName;
                this.Text = filename + " - База питомцев";
                dataGrid.Rows.Clear();
                data.OpenFile(filename);
                WriteToDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            открытьToolStripMenuItem_Click(открытьToolStripMenuItem, null);
        }

        //Сохраняет базу в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (filename == "")
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    filename = saveFileDialog1.FileName;
                    this.Text = filename + " - База питомцев";
                }
                // Если сохранение произошло первый раз, то запускаем 
                // таймер для автосохранения
                if (!timer1.Enabled)
                {
                    timer1.Enabled = true;
                    timer1.Start();
                }
                // При каждом сохранении будет появляться надпись "Сохранение..."
                labelSave.Visible = true;
                timer2.Enabled = true;
                timer2.Start();

                data.SaveToFile(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void button_SaveFile_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(сохранитьToolStripMenuItem, null);
        }

        //Сортировка по возрасту питомцев
        private void button_Sort_Click(object sender, EventArgs e)
        {
            if (data.PetsFile.Count != 0)
            {
                dataGrid.Rows.Clear();
                if (comboBoxChoiceSort.SelectedIndex == 0)
                {
                    data.Sort(SortDirection.Ascending);
                }
                else
                {
                    data.Sort(SortDirection.Descending);
                }
                WriteToDataGrid();
            }
        }

        //Открыть форму со справкой
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Info = "База питомцев" + "\n\n" +
                          "Powered by Visual Studio 2017, C#" + "\n\n" +
                          "2020 г.";
            MessageBox.Show(Info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Открывает форму, с помощью которой можно добавлять данные
        private void button_Add_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.ShowDialog();
        }

        private void добавлениеСтрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Add_Click(button_Add, null);
        }

        //Открывает форму, с помощью которой можно найти данные в базе
        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.ShowDialog();
        }

        private void поискСтрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Search_Click(button_Search, null);
        }

        //При закрытии формы сказать про несохранённые данные
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((data.PetsFile.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Уверены," +
                    "что хотите выйти из программы?" + "\r\n" +
                    "Изменения ещё не сохранены!",
                    "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База питомцев";
                    filename = "";
                    data.DeleteAllRows();
                    dataGrid.Rows.Clear();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Stop();
                    timer2.Enabled = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        //Удаление записи из таблицы и базы
        private void dataGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                object ObjID = e.Row.Cells[0].Value;
                ushort ID = (ushort)ObjID;
                Pet pet;

                for (int i = 0; i < data.PetsFile.Count; i++)
                {
                    pet = (Pet)data.PetsFile[i];

                    if (pet.RowID == ID)
                    {
                        data.DeleteRow(i);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        //Пользователь начинает редактирование ячейки
        //На всякий случай сохраняется "старое" значение ячейки
        private void dataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                oldValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        //Пользователь заканчивает редактирование ячейки
        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indRow = dataGrid.Rows[e.RowIndex].Index;
                int indColumn = dataGrid.Columns[e.ColumnIndex].Index;
                object value = dataGrid.Rows[indRow].Cells[indColumn].Value;

                // Если значение не было введено, то оставляем старое
                if (value is null)
                {
                    MessageBox.Show("Вы не ввели значение.");
                    dataGrid.Rows[indRow].Cells[indColumn].Value = oldValue;
                    return;
                }

                if (indColumn == 1)
                {
                    data.EditOwnerName((string)value, indRow);
                }

                else
                if (indColumn == 2)
                {
                    data.EditPetKind((string)value, indRow);
                }

                else
                if (indColumn == 3)
                {
                    data.EditPetBreed((string)value, indRow);
                }

                else
                if (indColumn == 4)
                {
                    data.EditPetGender((string)value, indRow);
                }

                else
                if (indColumn == 5)
                {
                    data.EditPetName((string)value, indRow);
                }

                else
                if (indColumn == 6)
                {
                    try
                    {
                        data.EditPetAge((ushort)Convert.ToInt32(value), indRow);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Ошибка: {exception.Message}");
                        dataGrid.Rows[indRow].Cells[indColumn].Value = oldValue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }        
    }
}
