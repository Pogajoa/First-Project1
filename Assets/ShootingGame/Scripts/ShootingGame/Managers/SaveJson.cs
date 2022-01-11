using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class SaveJson : MonoBehaviour {
   public PlayerData1 playerData1;
   [ContextMenu("To Json Data")]
   void SavePlayerDataToJson(){
       string jsonData = JsonUtility.ToJson(playerData1, true);
       string path = Path.Combine(Application.dataPath, "playerData.json");
       File.WriteAllText(path, jsonData);
   }
    [ContextMenu("From Json Data")]
   void LoadPlayerDataToJson(){
       string path = Path.Combine(Application.dataPath, "playerData.json");
       string jsonData = File.ReadAllText(path);
       playerData1 = JsonUtility.FromJson<PlayerData1>(jsonData);
   }
   
}
[Serializable]
public class PlayerData1
{
    public string name;
    public int age;
    public int level;
    public bool isDead;
    public string[] items;
}