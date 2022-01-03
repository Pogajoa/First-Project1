using UnityEngine;

public class StructExample : MonoBehaviour
{   
    void Start(){
    Point_Struct point1 = new Point_Struct(1,2);
    Debug.Log(point1.GetPoint());
    }
}

struct Point_Struct{
    public int x;
    public int y;
    public Point_Struct(int x, int y){
        this.x = x;
        this.y = y;
    }
    public string GetPoint(){
        return $"({x},{y})";
    } 
}

