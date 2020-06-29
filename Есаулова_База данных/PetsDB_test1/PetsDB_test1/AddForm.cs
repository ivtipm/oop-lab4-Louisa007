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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button_AddRow_Click(object sender, EventArgs e)
        {
            MainForm f = Owner as MainForm;

            try
            {
                f.RowID = textBox_ID.Text = f.generateID().ToString();

                f.PetOwner = textBox_Owner.Text;
                f.PetKind = comboBox_Kind.Text;
                f.PetBreed = textBox_Breed.Text;
                f.PetGender = textBox_Gender.Text;
                f.PetName = textBox_PetName.Text;
                f.PetAge = textBox_PetAge.Text;

                Pet pet = new Pet
                    (
                    (ushort)Convert.ToInt32(textBox_ID.Text),
                    textBox_Owner.Text,
                    comboBox_Kind.Text,
                    textBox_Breed.Text,
                    textBox_Gender.Text,
                    textBox_PetName.Text,
                    (ushort)Convert.ToInt32(textBox_PetAge.Text)
                    );

                f.data.AddRow(pet);
                int n = f.data.PetsFile.Count;

                Pet pet1 = (Pet)f.data.PetsFile[n - 1];
                f.dataGrid.Rows.Add
                    (
                    pet1.RowID,
                    pet1.OwnerName,
                    pet1.PetKind,
                    pet1.PetBreed,
                    pet1.PetGender,
                    pet1.PetName,
                    pet1.PetAge
                    );

                f.BanChangeColumn(n - 1);                

                if ((!f.timer1.Enabled) && (f.filename != ""))
                {
                    f.timer1.Enabled = true;
                    f.timer1.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
