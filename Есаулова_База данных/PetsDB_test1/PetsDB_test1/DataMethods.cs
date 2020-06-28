using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsDB_test1
{
    public class DataMethods
    {
        // массив из записей с данными о питомцах
        public ArrayList PetsFile { get; } = new ArrayList();

        // Добавить новую строку в массив
        public void AddRow(Pet petRow)
        {
            PetsFile.Add(petRow);
        }

        // Удалить определённую строку из массива
        public void DeleteRow(int number)
        {
            PetsFile.RemoveAt(number);
        }

        // Удалить все строки из массива
        public void DeleteAllRows()
        {
            PetsFile.Clear();
        }

        // Изменить имя хозяина
        public void EditOwnerName(string ownerName, int index)
        {
            Pet pet = (Pet)PetsFile[index];
            pet.OwnerName = ownerName;
        }

        // Изменить вид питомца (кошка, собака, попугай, сова ...)
        public void EditPetKind(string petKind, int index)
        {
            Pet pet = (Pet)PetsFile[index];
            pet.PetKind = petKind;
        }

        // Изменить породу питомца
        public void EditPetBreed(string petBreed, int index)
        {
            Pet pet = (Pet)PetsFile[index];
            pet.PetBreed = petBreed;
        }

        // Изменить пол питомца
        public void EditPetGender(string petGender, int index)
        {
            Pet pet = (Pet)PetsFile[index];
            pet.PetGender = petGender;
        }

        // Изменить кличку питомца
        public void EditPetName(string petName, int index)
        {
            Pet pet = (Pet)PetsFile[index];
            pet.PetName = petName;
        }

        // Изменить возраст питомца
        public void EditPetAge(ushort petAge, int index)
        {
            Pet pet = (Pet)PetsFile[index];
            if ((petAge < 1) || (petAge > 50))
            {
                throw new Exception("Возраст питомца должен быть не меньше года, и не больше 50");
            }
            pet.PetAge = petAge;
        }

        // Сохранить массив в файл
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (Pet s in PetsFile)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        // Загрузить массив из файла
        public void OpenFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new Exception("Файл не существует");
            }

            if (PetsFile.Count != 0)
            {
                DeleteAllRows();
            }

            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    string[] dataFromFile = str.Split(new String[] { "|" }, StringSplitOptions.RemoveEmptyEntries);

                    ushort id = (ushort)Convert.ToInt32(dataFromFile[0]);
                    string petOwner = dataFromFile[1];
                    string petKind = dataFromFile[2];
                    string petBreed = dataFromFile[3];
                    string petGender = dataFromFile[4];
                    string petName = dataFromFile[5];
                    ushort petAge = (ushort)Convert.ToInt32(dataFromFile[6]);

                    Pet pet = new Pet(id, petOwner, petKind, petBreed, petGender, petName, petAge);
                    AddRow(pet);
                }
            }
        }

        // Поиск совпадений по базе, и получение ID всех найденных записей        
        // Возвращает -1, если совпадений не найдено
        public List<int> SearchRows(string query)
        {
            List<int> count = new List<int>();

            //Проверяются ID и возраст питомца
            if (ushort.TryParse(query, out ushort num_query))
            {
                for (int i = 0; i < PetsFile.Count; i++)
                {
                    Pet pet = (Pet)PetsFile[i];

                    if (pet.RowID == num_query)
                    {
                        count.Add(i);
                        break; // Если нашли запись по уникальному ID, то закончить поиск
                    }
                    else
                    {
                        if (pet.PetAge == num_query)
                        {
                            count.Add(i);
                        }
                    }
                }

                if (count.Count == 0)
                {
                    count.Add(-1);
                }
                return count;
            }

            // Поиск по текстовым полям записи
            query = query.ToLower(); // перевод в нижний регистр
            query = query.Replace(" ", "");

            for (int i = 0; i < PetsFile.Count; i++)
            {
                Pet pet = (Pet)PetsFile[i];

                if (pet.OwnerName.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (pet.PetKind.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (pet.PetBreed.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (pet.PetGender.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }

                else
                if (pet.PetName.ToLower().Replace(" ", "").Contains(query))
                {
                    count.Add(i);
                }
            }

            if (count.Count == 0)
            {
                count.Add(-1);
            }
            return count;
        }

        // Сортировка по возрасту питомцев
        public void Sort(SortDirection direction)
        {
            PetsFile.Sort(new AgeComparer(direction));
        }
    }

    // Сортировка по возрастанию/убыванию
    public enum SortDirection
    {
        Ascending, // возрастание
        Descending // убывание
    }

    public class AgeComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public AgeComparer() : base() { }

        public AgeComparer(SortDirection direction)
        {
            m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Pet pet1 = (Pet)x;
            Pet pet2 = (Pet)y;

            return (m_direction == SortDirection.Ascending) ?
                pet1.PetAge.CompareTo(pet2.PetAge) :
                pet2.PetAge.CompareTo(pet1.PetAge);
        }
    }
}
