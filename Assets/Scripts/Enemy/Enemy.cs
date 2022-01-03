using UnityEngine;

public class Enemy : MonoBehaviour
{   
    private float health = 50.0f;
    public float Speed = 1000f;
    public float Health{
        get{return health;}
    }
        public void TakeDamage(int value){
            health -= value;
            Debug.Log("Enemy의 체력: " + health);
            if(health <= 0){
                Die();
            }
        }
        void Die(){
            Destroy(gameObject);
            EventManager.RunEnemyDieEvent();
        }
        public float GetHealth() {
            return health;
        }

        void OnCollisionEnter2D(Collision2D coll){
            if(coll.gameObject.CompareTag("Bullet"))
            {
                 TakeDamage (10);
            coll.gameObject.SetActive(false);
            }
        }
        public virtual void Move(){
        }
        public void Update(){
            if(transform.position.x < -3.5 || transform.position.x > 3.5){
            Destroy(gameObject);
        }
        }

 }
