using UnityEngine;
using System;
public class ActionFuncExample : MonoBehaviour
{
    void Start(){
    //   Action<string> act = PrintMessage;
    //   Action act2 = SayHello;
    //   Func<int, int, string> mul = Multiply; 
    //   act("abcde");
    //     act2();
    //     Debug.Log(mul(2, 5));

    // void PrintMessage(string Message){
    //     Debug.Log(Message);
    // }
    // void SayHello(){
    //     Debug.Log("Hello");
    // }
    // string Multiply(int a, int b){
    //     return (a * b).ToString();
    // }
    
    Func<int, int, string> mul = (a, b)=>(a * b).ToString();
    Debug.Log(mul(2, 7));
    }


   
}
