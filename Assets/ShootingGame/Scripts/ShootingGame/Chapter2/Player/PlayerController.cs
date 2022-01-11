using UnityEngine;
public class PlayerController : MonoBehaviour
{   
    public GameObject BulletPrefab;
    public GameObject Gun;
    public float speed = 0.02f;
    public float BulletSpeed = 100;
    public float Player_health = 100;
    public void TakeDamage_Player(int value){
            Player_health -= value;
            Debug.Log("Player의 체력: " + Player_health);
            if(Player_health <= 0){
                Die();
            }
        }
        void Die(){
            Destroy(gameObject);
        }
    
    void Update()
    {
        if(gameObject.transform.position.x > 3.4){
            transform.Translate(-speed, 0, 0);
        }
        if(gameObject.transform.position.x < -3.4){
            transform.Translate(speed, 0, 0);
        }
        if(gameObject.transform.position.y < -4.6){
            transform.Translate(0, speed, 0);
        }
        if(gameObject.transform.position.y > 4.6){
            transform.Translate(0, -speed, 0);
        }

        if(Input.GetKey(KeyCode.A)){
            transform.Translate(-speed,0,0);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0,-speed,0);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.Translate(speed,0,0);
        }

        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0,speed,0);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            for(int i = 0; i < 3; i++){
            GameObject bullet = Instantiate(BulletPrefab);
            Vector3 BulletStartPos = Gun.transform.position;
            BulletStartPos.y += 0.3f * i;
            bullet.transform.position = BulletStartPos;
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);
            }
            }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.CompareTag("Enemy")){
            TakeDamage_Player(10);
        }
    }
}
