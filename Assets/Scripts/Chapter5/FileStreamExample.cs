using UnityEngine;
using System.IO;
public class FileStreamExample : MonoBehaviour
{
    void Start()
    {
    //   FileStream fs = new FileStream("D:/UnityHub/GameFile", FileMode.Create);
    //   StreamWriter sw = new StreamWriter(fs);
    //   sw.Write("Hello World~!");
    //   sw.Close();

    //   fs = new FileStream("D:/UnityHub/GameFile", FileMode.Open);
    //   StreamReader sr = new StreamReader(fs);
    //   string Line = sr.ReadLine();
    //   Debug.Log(Line);

    FileStream fs2 = new FileStream("D:/UnityHub/examplebin.txt", FileMode.Create);
    BinaryWriter bw = new BinaryWriter(fs2);
    bw.Write("Hello World!2");
    bw.Write(264);
    bw.Close();

    fs2 = new FileStream("D:/UnityHub/examplebin.txt", FileMode.Open);
    BinaryReader br = new BinaryReader(fs2);
    string str = br.ReadString();
    int a = br.ReadInt32();
    Debug.Log(str);
    Debug.Log(a);
    br.Close();
    }
}
