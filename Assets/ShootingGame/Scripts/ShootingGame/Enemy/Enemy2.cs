
using UnityEngine;

public class Enemy2 : Enemy
{
        void Start(){
            Move();
        }
       public override void Move(){
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * Speed);
        }
}
