using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class GameManager : MonoBehaviour
{
   public GameObject Cover;
    public SpawnManager spawnManager;
    public ItemManager itemManager;
    public Text ScoreText;
    public Text BestScoreText;
    int Score = 0;
   UserData userData;
    // int BestScore = 0;

   public void OnClickStartBtn(){
       Cover.SetActive(false);
       itemManager.SpawnRandom();
       StartCoroutine(spawnManager.SpawnRandom());
       StartCoroutine(itemManager.SpawnRandom());
   }
   void Start(){
      EventManager.EnemyDieEvent += OnEnemyDie; 
      ScoreText.text = String.Format("Score: {0}", Score);
      // BestScore = PlayerPrefs.GetInt("BestScore", 0);
      LoadUserData();
      BestScoreText.text = String.Format("BestScore: {0}", userData.BestScore);
     
   }
   void OnEnemyDie(){
      Score++;
      ScoreText.text = String.Format("Score: {0}", Score);
      if(Score > userData.BestScore){
         userData.BestScore = Score;
         BestScoreText.text = String.Format("BestScore: {0}", userData.BestScore);
         SaveUserData();
      }
    }
    void SaveUserData(){
       FileStream fs = new FileStream(Application.persistentDataPath + "/userData.dat", FileMode.Create);
       BinaryFormatter bf = new BinaryFormatter();
       bf.Serialize(fs, userData);
       fs.Close();
    }
    void LoadUserData(){
   //     if(File.Exists(Application.persistentDataPath + "/userData.dat")){
   //     FileStream fs = new FileStream(Application.persistentDataPath + "/userData.dat", FileMode.Open);
   //     BinaryFormatter bf = new BinaryFormatter();
   //    userData = (UserData) bf.Deserialize(fs);
   //    fs.Close();
   //    }
   //    else{
   //       userData = new UserData();
   //    }
   //  }
   try{
       FileStream fs = new FileStream(Application.persistentDataPath + "/userData.dat", FileMode.Open);
       BinaryFormatter bf = new BinaryFormatter();
      userData = (UserData) bf.Deserialize(fs);
      fs.Close();
   }
   catch(Exception e){
      Debug.Log(e.Message);
      userData = new UserData();
   }
  }
}

[System.Serializable]
class UserData{
   public int BestScore = 0;
}

