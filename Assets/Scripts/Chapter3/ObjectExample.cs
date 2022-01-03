using UnityEngine;
public class ObjectExample : MonoBehaviour {
    void Start(){
        Human john = new Human();
        john.Name = "john";
        john.Age = 24;
        john.Height = 175;
        john.Eat();
        Debug.Log(john.Age);
    }    
}

