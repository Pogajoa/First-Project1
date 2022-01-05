using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
    string [] names = {"john", "chulsoo", "bbobbi", "noorungi"};
    void Start(){
        Debug.Log((int)Names.noorungi);
        Debug.Log((int)Names.bbobbi);
        
    }
}
    enum Days{
        Mon, Tue, Wed, Thu = 7, Fri, Sat, Sun
    }
    enum Names{
        john, bbobbi = 2, noorungi
        }
    