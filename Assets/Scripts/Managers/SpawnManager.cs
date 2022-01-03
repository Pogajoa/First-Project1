using UnityEngine;
using System.Collections;
public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    void Start(){
        EventManager.EnemyDieEvent += OnEnemyDie;
        // SpawnRandom();
    //     for(int i = 0; i < 5; i++){
    //         for(int j = 0; j < 5; j++){
    //        if(j % 2 == 0){
    //            SpawnEnemy(EnemyPrefab1, new Vector3(i, j, 0));     
    //         }
    //         else{
    //         SpawnEnemy(EnemyPrefab2, new Vector3(i, j, 0));
    //         }
    //     }
    // }
    }

    
    public IEnumerator SpawnRandom(){
        while(true){
        GameObject prefab = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
        Vector2 pos = ItemManager.points[Random.Range(0, ItemManager.points.Count)].GetPos();
        SpawnEnemy(prefab, pos);
        yield return new WaitForSeconds(0.5f);
        }
    }
    public void SpawnEnemy(GameObject Prefab, Vector3 position){
        GameObject enemy = Instantiate(Prefab);
        enemy.transform.position  = position;
        enemy.GetComponent<Enemy>().Move();
    }
    void OnEnemyDie(){
        float x = Random.Range(-3.0f, 3.0f);
        float y = Random.Range(-5.0f, 5.0f);
        Point point = new Point(x, y);
        ItemManager.points.Add(point);     
    }
}
