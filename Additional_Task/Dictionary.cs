using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] ENG = new string[5];
        private string[] UA = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; ENG[0] = "book"; UA[0] = "книга";
            key[1] = "ручка"; ENG[1] = "pen"; UA[1] = "ручка";
            key[2] = "солнце"; ENG[2] = "sun"; UA[2] = "солнце";
            key[3] = "яблоко"; ENG[3] = "apple"; UA[3] = "яблуко";
            key[4] = "стол"; ENG[4] = "table"; UA[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + UA[i] + " - " + ENG[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + UA[index] + " - " + ENG[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
