using UnityEngine;

public class destruirLatas: MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject, 5f);
        }
    }

    void Update()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        if (viewPos.x < 0 || viewPos.x > 1 || viewPos.y < 0 || viewPos.y > 1)
        {
            Destroy(gameObject);
        }
    }
}
