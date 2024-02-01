using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10 + Random.Range(-1f, 3f));
        rb.angularVelocity = Random.Range(-200f, 200f);
    }

    void Update()
    {
        if(transform.position.y < -6)
        {
            print(":(");
            Destroy(gameObject);
        }
    }
}