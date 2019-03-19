using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashTable
    {
        //private Tuple<int, List<object>>[] data;
        class HashData
        {
            public readonly int Hash;
            public  object Value { get; set; }

            public HashData(int h, object obj)
            {
                Hash = h;
                Value = obj;
            }
        }
        private List<HashData>[] data;
        /// <summary>
        /// Конструктор контейнера
        /// summary>
        /// size">Размер хэш-таблицы
        public HashTable(int size)
        {
            data = new List<HashData>[size];//new Tuple<int, List<object>>[size];
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

            if(data[index] == null)
                data[index] = new List<HashData> { new HashData(keyHashCode,  value )};//Tuple.Create(keyHashCode, new List<object> { value });
            else
            {
                var el = data[index].FirstOrDefault(x => x.Hash == keyHashCode);
                if (el != null) el.Value = value;
                else data[index].Add(new HashData(keyHashCode, value));
            }
            //data[index] = Tuple.Create(keyHashCode, new List<object> {value});
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
                var valueByKey = data[Math.Abs(keyHashCode) % data.Length];
                return valueByKey.Find(x => x.Hash == keyHashCode).Value;
                //return pair.Item1 == keyHashCode ? pair.Item2 : null;
            }
            catch
            {
                return null;
            }
        }

    }
}
