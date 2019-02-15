using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Core.MemorySystem
{
    public class MemorySystem
    {
        public static void NewGame(string gameName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + 
                "/MyGame.data");
            bf.Serialize(file, new GameData(gameName, 15, 24));
            file.Close();
        }

        public static void SaveGame()
        {

        }

        public static GameData LoadGame()
        {
            if(File.Exists(Application.persistentDataPath +
                "/MyGame.data"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath +
                "/MyGame.data", FileMode.Open);
                GameData currentGameData = (GameData)bf.Deserialize(file);
                file.Close();
                return currentGameData;
            }
            return new GameData();
        }

        public static void EreaseGame()
        {

        }
    }
}
