using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
/*
public class Save : MonoBehaviour
{
    public string LoadedPlayerName;
    public int LoadedScore;
    public float LoadedPlayTime;

    private void Start()
    {
        SaveFile();
        LoadFile();
    }
    public void SaveFile()
    {
        string filePath = Application.dataPath + "/SaveFile.SAV";
        Debug.Log(filePath);
        FileStream file;

        if (File.Exists(filePath))
        {
            file = File.OpenWrite(filePath);
        }
        else
        {
            file = File.Create(filePath);
        }

     //   GameData data = new GameData(96, "_XXX_NoScopeLord_XXX_", 6000);

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }



    public void LoadFile()
    {
        string filePath = Application.dataPath + "/SaveFile.SAV";
        Debug.Log(filePath);
        FileStream file;

        if (File.Exists(filePath))
        {
            file = File.OpenRead(filePath);
        }
        else
        {
            Debug.LogError("Save file not found");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData)bf.Deserialize(file);
        file.Close();

        LoadedPlayerName = data.PlayerName;
        LoadedScore = data.Score;
        LoadedPlayTime = data.TimePlayed;
    }
}
zdfgsdzgmfzd] 
    vx

    zv dfl,ng*/