using UnityEngine;

public class ConstructorExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Human Jane = new Human("Jane", 175, 24);
        Debug.Log(Jane.Name);
        Debug.Log(Jane.Height);
        Debug.Log(Jane.Age);

    }
}
