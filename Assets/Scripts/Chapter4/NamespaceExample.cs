using UnityEngine;
public class NamespaceExample : UnityEngine.MonoBehaviour
{
    void Start(){
    UnityEngine.Debug.Log("sjfdlsjfl");
    exampleNS.A a = new exampleNS.A();
    }
}
namespace exampleNS{
    class A{

    }
    class B{

    }
}
