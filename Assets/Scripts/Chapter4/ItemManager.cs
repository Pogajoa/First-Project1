using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemPrefabs;
    public static List<Point> points = new List<Point>{
       new Point(0,0),
        new Point(1,0),
        new Point(0,1),
        new Point(1,1),
        new Point(-1,0),
        new Point(0,-1),
        new Point(-1,-1),
        new Point(2,0),
        new Point(0,2),
        new Point(-2,0),
        new Point(0,-2),
        new Point(2,-2),
        new Point(2, 2),
        new Point(-2,2),
        new Point(-2,-2),
        new Point(2,-4),
        new Point(2, 4),
        new Point(-2,-4),
        new Point(-2, 4)
    };
    public IEnumerator SpawnRandom(){
        while(true){
             GameObject prefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
            Vector2 pos = points[Random.Range(0, points.Count)].GetPos();
            SpawnItem(prefab, pos);
            yield return new WaitForSeconds(1.0f);
        }
    }
    void SpawnItem(GameObject itemPrefab, Vector2 pos){
        GameObject item = Instantiate(itemPrefab);
        item.transform.position = pos;
    }
    void Start(){

        // SpawnRandom();
    //     for(int i = 0; i < 5; i++){
    //         GameObject itemPrefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
    //         Vector2 pos = points[Random.Range(0, points.Length)].GetPos();
    //         SpawnItem(itemPrefab, pos);
    }
    }
public struct Point{
        float x;
        float y;
        public Point(float x, float y){
            this.x = x;
            this.y = y;
        }
        public Vector2 GetPos(){
            return new Vector2(this.x, this.y);  
    }
}
