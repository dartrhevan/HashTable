using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable
    {
        private readonly Dictionary<object, object> dict;// = new Dictionary<object, object>();
        
        /// <summary>
        /// Конструктор контейнера
        /// summary>
        /// size">Размер хэш-таблицы
        public HashTable(int size)
        {
            dict = new Dictionary<object, object>(size);
        }
        ///
        /// Метод складывающий пару ключ-значение в таблицу
        ///
        /// key">
        /// value">

        public void PutPair(object key, object value)
        {
            dict[key] = value;
        }
        /// <summary>
        /// Поиск значения по ключу
        /// summary>
        /// key">Ключ
        /// <returns>Значение, null если ключ отсутствуетreturns>
        public object GetValueByKey(object key)
        {
            try
            {
                return dict[key];
            }
            catch
            {
                return null;
            }
        }

    }
}
