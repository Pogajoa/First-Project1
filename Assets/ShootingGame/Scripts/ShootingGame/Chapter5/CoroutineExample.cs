using UnityEngine;
using System.Collections;

public class CoroutineExample : MonoBehaviour
{
   void Start(){
       StartCoroutine(First());
       Debug.Log("3");
   }

   IEnumerator First(){
        Debug.Log("1");
        yield return null;
        StartCoroutine(Second());
   }
   IEnumerator Second(){
       Debug.Log("2");
       yield return null;
   }
}
