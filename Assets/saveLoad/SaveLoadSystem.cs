using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadSystem : MonoBehaviour
{
    
    public static void SaveSystem()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("dosyam.bin", FileMode.Create);

        formatter.Serialize(stream, mineData.ad);
        formatter.Serialize(stream, mineData.puan);
        stream.Close();

    }
    public static void LoadSystem()
    {
        if (File.Exists("dosyam.bin"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("dosyam.bin", FileMode.Open);

            mineData.ad = (string)formatter.Deserialize(stream);
            mineData.puan = (int)formatter.Deserialize(stream);
            stream.Close();
        }
        else
        {
            Debug.LogError("bu atın kafası yok.");
        }
    }
}
