using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class EventManager : MonoBehaviour
{
   public static event Action EnemyDieEvent;
  public static void RunEnemyDieEvent(){
      if(EnemyDieEvent != null){
      EnemyDieEvent();
      }
  }
}

