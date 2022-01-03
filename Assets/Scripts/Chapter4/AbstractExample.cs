using UnityEngine;

public class AbstractExample : MonoBehaviour
{
    void Start(){
        Bird eagle = new Bird();
        Fish shark = new Fish();
        eagle.Move();
        shark.Move();
    }
}
abstract class Animal{
    public abstract void Move();
}

class Fish : Animal{
    public override void Move(){
        Debug.Log("Swim!");
    }
}

class Bird : Animal {
    public override void Move(){
        Debug.Log("Fly!");
    }
}

