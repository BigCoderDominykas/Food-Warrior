using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruit;
    public GameObject bomb;
    public float bombChance = 20;
    public float spawnDelay = 2f;
    float delay;

    void Start()
    {
        delay = spawnDelay;
        InvokeRepeating("SpawnFruit", spawnDelay, delay);
    }

    void SpawnFruit()
    {
        var prefab = Random.Range(0, 100) < 100 - bombChance ? fruit : bomb;

        delay = spawnDelay + Random.Range(-1f, 1f);
        var pos = transform.position;
        pos.x += Random.Range(-6f, 6f);
        Instantiate(prefab, pos, Quaternion.identity);
    }
}
