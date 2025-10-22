using UnityEngine;

public class danoPlayer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Inimigo"))
        {
            inimigo boss = collider.GetComponent<inimigo>();
            boss.ReceberDano();

        }
    }

}
