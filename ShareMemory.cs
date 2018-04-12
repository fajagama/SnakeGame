using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    static class ShareMemory
    {
        private static Dictionary<String, int> _sharedMemory = new Dictionary<string, int>();

        public static void Add(string key, int value)
        {
            if (_sharedMemory.ContainsKey(key)){
                _sharedMemory[key] = value;
            }
            else
            {
                _sharedMemory.Add(key, value);
            }
        }

        public static int Read(string key)
        {
            return _sharedMemory[key];
        }

        public static void Clear()
        {
            _sharedMemory.Clear();
        }
    }
}
