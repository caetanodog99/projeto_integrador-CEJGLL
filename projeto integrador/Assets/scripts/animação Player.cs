using UnityEngine;

public class animaçãoPlayer : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidbody;

    [SerializeField]
    private Animator animator;


   

    void Update()
    {


        float velocidadeX = Mathf.Abs(this.rigidbody.linearVelocity.x);
        if (velocidadeX != 0) { 
            this.animator.SetBool("correndo", true);
          
        }
        else { 
        
            this.animator.SetBool("correndo", false);
        }
    }



}
