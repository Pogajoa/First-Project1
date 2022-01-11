using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ExampleClass ex1 = new ExampleClass();
        //  ExampleClass ex2 = new ExampleClass();
        // ex1.number = 1;
        // ex2.number = 2;
        // Debug.Log(ex1.number);
        //  Debug.Log(ex2.number);
        // ExampleClass.number = 1;
        // ExampleClass.number = 2;
        // Debug.Log(ExampleClass.number);
        Member chulsoo = new Member(17, "chulsoo");
        Member Sana = new Member(23, "Sana");
        Debug.Log(Member.numOfMembers);
    }
}

class ExampleClass{
    public int number;
}
class Member{
    public int age;
    public string name;
    public static int numOfMembers;
    public Member(int age, string name){
        this.age = age;
        this.name = name;
        numOfMembers++;
    }
}
