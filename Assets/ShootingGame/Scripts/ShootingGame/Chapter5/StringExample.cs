using UnityEngine;

public class StringExample : MonoBehaviour
{
       void Start()
    {
    //     string str1 = "Hello";
    //     string str2 = "Hello World";
    //     Debug.Log(str1.Length);
    //     Debug.Log(str2.Length);
    //     Debug.Log(str1.IndexOf("e")); //1
    //     Debug.Log(str1.IndexOf("o")); //4
    //     Debug.Log(str1.Replace("el", "56"));
    //     string str3 = "abcdef";
    //     string[] arr = str3.Split('c');
    //     Debug.Log(arr.Length);
    //     Debug.Log(arr[0]);
    //     Debug.Log(arr[1]);
    //     string str4 = "철수, 영희, 나리, 훈이, 뽀삐";
    //     string [] nameArr = str4.Split(',');
    //     foreach(string name in nameArr){
    //         Debug.Log(name);
    //     }
    // }
    // string str5 = "tomato";
    // Debug.Log(str5.Substring(2)); //mato
    // Debug.Log(str5.Substring(str5.IndexOf("o"), 4)); // omat
    // int num = 43 * 72;
    // string newStr = string.Format("43 * 72 = {0}", num);
    // Debug.Log(newStr);
    // for (int i = 2;  i < 10; i++){
    //     for(int j = 1; j < 10; j++){
    //         Debug.Log(string.Format("{0} * {1} = {2}", i, j, i * j));
    //     }
    // }
    int num = 1;
    string Str1 = num.ToString();
    int num2 = int.Parse(Str1);
    float num3 = float.Parse(Str1);

}
}
