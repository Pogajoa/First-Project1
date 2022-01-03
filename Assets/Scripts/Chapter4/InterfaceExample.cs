using UnityEngine;

public class InterfaceExample : MonoBehaviour
{
    
}
interface ISword{
        float Damage{get; set;}
        void Attack();
    }
interface IShield{
    float DefensivePower{get; set;}
    void Defend();
}
class Knight : ISword, IShield{
    public float Damage{get; set;}
    public float DefensivePower{get; set;}
    public void Attack(){}
    public void Defend(){}
}


