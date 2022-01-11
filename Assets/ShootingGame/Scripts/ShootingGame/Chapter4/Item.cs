using UnityEngine;
public abstract class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        DestroyAfterTime();

    }
        public abstract void DestroyAfterTime();
        public abstract void ApplyItem();
        public void DestroySelf(){
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.CompareTag("Player")){
            ApplyItem();
        }
    }
}
public interface IEffect{
    void GetOpaque();
}
