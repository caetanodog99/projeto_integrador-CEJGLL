using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;

    [SerializeField]
    private float velocidadeMovimento;

    [SerializeField]
    private FixedJoystick joystick;

    private SpriteRenderer sprite;



    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    void Update()
    {
        //movimentação
        float horizontal = this.joystick.Horizontal;
        float vertical = this.joystick.Vertical;

        Flip(horizontal);
        

        Vector2 direcao = new Vector2(horizontal, vertical);
        direcao = direcao.normalized;

        Debug.Log(direcao + " => " + direcao.magnitude);

        this.rigidbody.linearVelocity = direcao * this.velocidadeMovimento;



    }
    //flip do sprite do personagem
    private void Flip(float horizontal)
    {
        if (horizontal > 0)
        {
            sprite.flipX = false;
        }
        else if (horizontal < 0)
        {
            sprite.flipX = true;
        }
    }
}
