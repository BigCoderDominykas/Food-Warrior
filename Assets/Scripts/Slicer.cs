using UnityEngine;

public class Slicer : MonoBehaviour
{
    Rigidbody2D rb;
    
    void Start()
    {
        if(!Application.isEditor)
            Cursor.visible = false;

        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        rb.MovePosition(worldPos);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var fruit = collision.gameObject.GetComponent<Fruit>();
        fruit.Slice();
    }
}
