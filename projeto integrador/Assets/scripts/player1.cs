using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;

    [SerializeField]
    private float velocidadeMovimento;

    [SerializeField]
    private FixedJoystick joystick;





    // Update is called once per frame
    void Update()
    {
        
        float horizontal = this.joystick.Horizontal;
        float vertical = this.joystick.Vertical;
        

        Vector2 direcao = new Vector2(horizontal, vertical);
        direcao = direcao.normalized;

        Debug.Log(direcao + " => " + direcao.magnitude);

        this.rigidbody.linearVelocity = direcao * this.velocidadeMovimento;

    }
}
