using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class SerializationExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // User user = new User();
        // user.level = 100;
        // user.name = "chulsoo";

        // FileStream fs = new FileStream("D:/UnityHub/data.dat", FileMode.Create);
        // BinaryFormatter bf = new BinaryFormatter();
        // bf.Serialize(fs, user);
        // fs.Close();
    }
}
    [System.Serializable]
    class User{
        public int level;
        public string name;
}

