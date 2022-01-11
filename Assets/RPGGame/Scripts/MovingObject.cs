using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    private Vector3 vector;
    public float speed;
    public float RunSpeed;
    private float ApplyRunSpeed;
    public int WalkCount;
    private int CurrentWalkCount;
    private bool CanMove = true;
    private bool ApplyRunFlag = false;
    
    IEnumerator MoveCoroutine(){
        if(Input.GetKey(KeyCode.LeftShift)){
            ApplyRunSpeed = RunSpeed;
            ApplyRunFlag = true;
        }
        else{
            ApplyRunSpeed = 0;
           ApplyRunFlag = false;
        }
    
        vector.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), transform.position.z);
        
       while(CurrentWalkCount < WalkCount){
        if(vector.x != 0){
            transform.Translate(vector.x * (speed + ApplyRunSpeed), 0, 0);
        }
        else if(vector.y != 0){
            transform.Translate(0, vector.y * (speed + ApplyRunSpeed), 0);
            }
            yield return new WaitForSeconds(0.01f);
                if(ApplyRunFlag)
                    CurrentWalkCount++;
            CurrentWalkCount++;
        }
            CurrentWalkCount = 0;
            CanMove = true;
    }
    void Update(){
        if(CanMove){
        CanMove = false;
        StartCoroutine(MoveCoroutine());
        }
    }
   
}
