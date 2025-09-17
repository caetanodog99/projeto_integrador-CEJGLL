using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;

    [SerializeField]
    private float velocidadeMovimento;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direcao = new Vector2(horizontal, vertical);
        direcao = direcao.normalized;

        Debug.Log(direcao + " => " + direcao.magnitude);

        
        this.rigidbody.linearVelocity = direcao * this.velocidadeMovimento;

    }
}
