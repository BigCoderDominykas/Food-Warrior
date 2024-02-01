using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruit;
    public float spawnDelay = 1f;

    void Start()
    {
        InvokeRepeating("SpawnFruit", spawnDelay, spawnDelay);
    }

    void SpawnFruit()
    {
        var pos = transform.position;
        pos.x += Random.Range(-6f, 6f);
        Instantiate(fruit, pos, Quaternion.identity);
    }
}
