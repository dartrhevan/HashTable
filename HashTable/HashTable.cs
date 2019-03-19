using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable
    {
        private Tuple<int, object>[] data;
        /// <summary>
        /// Конструктор контейнера
        /// summary>
        /// size">Размер хэш-таблицы
        public HashTable(int size)
        {
            data = new Tuple<int, object>[size];
        }
        ///
        /// Метод складывающий пару ключ-значение в таблицу
        ///
        /// key">
        /// value">

        public void PutPair(object key, object value)
        {
            var keyHashCode = key.GetHashCode();
            var index = Math.Abs(keyHashCode) % data.Length;
            //if(pair.Item1 == keyHashCode)
            data[index] = Tuple.Create(keyHashCode, value);
        }
        /// <summary>
        /// Поиск значения по ключу
        /// summary>
        /// key">Ключ
        /// <returns>Значение, null если ключ отсутствует<returns>
        public object GetValueByKey(object key)
        {
            try
            {
                var keyHashCode = key.GetHashCode();
                var pair = data[Math.Abs(keyHashCode) % data.Length];
                return pair.Item1 == keyHashCode ? pair.Item2 : null;
            }
            catch
            {
                return null;
            }
        }

    }
}
