using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsDB_test1
{
    public class Pet
    {
        public Pet
            (
               ushort rowID,
               string ownerName,
               string petKind,
               string petBreed,
               string petGender,
               string petName,
               ushort petAge
            )
        {
            if ((ownerName == "") || (petKind == "") || (petBreed == "") || (petGender == "") || (petName == ""))
            {
                throw new Exception("Проверьте, всё ли вы заполнили. Все поля должны быть заполнены");
            }

            RowID = rowID;
            OwnerName = ownerName;
            PetKind = petKind;
            PetBreed = petBreed;
            PetGender = petGender;
            PetName = petName;
            PetAge = petAge;

            if ((petAge < 1) || (petAge > 50))
            {
                throw new Exception("Возраст питомца должен быть не меньше года, и не больше 50");
            }

            PetAge = petAge;
            RowID = rowID;
        }

        // Свойства для полей
        public ushort RowID     { get; set; }  // | ID записи в таблице  
        public string OwnerName { get; set; }  // | Имя хозяина
        public string PetKind   { get; set; }  // | Вид питомца (кошка, собака, попугай, сова ...)
        public string PetBreed  { get; set; }  // | Порода питомца
        public string PetGender { get; set; }  // | Пол питомца
        public string PetName   { get; set; }  // | Кличка питомца
        public ushort PetAge    { get; set; }  // | Возраст питомца

        public override string ToString()
        {
            return RowID + " | " + OwnerName + " | " + PetKind + " | " + PetBreed + " | " + PetGender + " | " + PetName + " | " + PetAge + " | ";
        }
    }
}
