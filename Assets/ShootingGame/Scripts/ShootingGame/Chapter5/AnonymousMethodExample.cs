using UnityEngine;

public class AnonymousMethodExample : MonoBehaviour
{
    delegate int myDelegate(int a, int b);
    void Start(){
      myDelegate del = (a, b) => a + b;
      Debug.Log(del(2, 4));
    }
    
}
