using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Core.MemorySystem
{
    public class MemorySystem
    {
        public static void NewGame()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + 
                "/MyGame.data");
            bf.Serialize(file, new GameData("RanemeGame", 15, 24));
        }

        public static void SaveGame()
        {

        }

        public static void LoadGame()
        {

        }

        public static void EreaseGame()
        {

        }
    }
}
