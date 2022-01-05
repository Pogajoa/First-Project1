using UnityEngine;
public class SpeedUp : Item, IEffect
{
     public override void DestroyAfterTime(){
        Invoke("DestroySelf", 5.0f);
        Invoke("GetOpaque", 3.0f);
     }
    public override void ApplyItem(){
    GameObject Player = GameObject.Find("Player");
    PlayerController controller = Player.GetComponent<PlayerController>();
    controller.speed *= 1.2f; 
    Debug.Log("Player의 Speed: " + controller.speed);
    DestroySelf();
    }
  public void GetOpaque(){
      Color32 color1 = GetComponent<SpriteRenderer>().color;
      GetComponent<SpriteRenderer>().color = new Color32(color1.r, color1.g, color1.b, 60);
  }
}
