using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{    void Start(){
    Publisher pub = new Publisher();
    Subscriber sub1 = new Subscriber();
    Subscriber sub2 = new Subscriber();
    Subscriber sub3 = new Subscriber();
    Subscriber sub4 = new Subscriber();
    Publisher.RunEvent();
    }
}
delegate void myEventHandler();
class Publisher{
        public static event myEventHandler myEvent;
        public static void RunEvent()
        {
            if(myEvent != null){
            myEvent();
            }
        }
    }
class Subscriber{
    public Subscriber(){
        Publisher.myEvent += DoSomething;
    }
    void DoSomething(){
        Debug.Log("DoSomething");
    }
}