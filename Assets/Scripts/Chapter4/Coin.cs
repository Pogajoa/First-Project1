using UnityEngine;


public class Coin : Item, IEffect
{
     public override void DestroyAfterTime(){
      Invoke("DestroySelf", 5.0f); 
      Invoke("GetOpaque", 3.0f);
     }
    public override void ApplyItem(){
        GameObject Player = GameObject.Find("Player");
        PlayerController controller = Player.GetComponent<PlayerController>();
        controller.Player_health += 5;
        Debug.Log("Player의 체력: " + controller.Player_health);
        DestroySelf();
    }
    public void GetOpaque(){
        Color32 color1 = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color32(color1.r, color1.g, color1.b, 60);
    }
}
