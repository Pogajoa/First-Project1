using UnityEngine;
public class AccessModifierExample : MonoBehaviour
{
    void Start()
    {
        Human john = new Human();
        john.Age = 1;
        john.Eat();
    }
}
