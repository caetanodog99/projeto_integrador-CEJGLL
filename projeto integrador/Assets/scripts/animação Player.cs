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
        if (velocidadeX > 0) { 
            this.animator.SetBool("correndo", true);
          
        }
        else { 
        
            this.animator.SetBool("correndo", false);
        }
    }

    

    //private void LateUpdate()
    //{
    //  Vector2 velocidade = this.rigidbody2d.linearVelocity;

    //if ((velocidade.x != 0) || (velocidade.y != 0))
    //{
    //    this.animator.SetBool("andando", true);
    //}
    //else
    //  {
    //        this.animator.SetBool("andando", false);
    //      }
    //
    // if (velocidade.x > 0)   //Movendo para a direita
    //  {
    //    this.spriteRenderer.flipX = false;
    //  }
    // else if (velocidade.x < 0)  //Movendo para a esquerda
    //  {
    //        this.spriteRenderer.flipX = true;
    //    }
    // }
}
