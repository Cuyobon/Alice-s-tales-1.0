using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Peon : MonoBehaviour
{
    [SerializeField]  private float DeathTime;
    public Animator animator;
    /*[SerializeField] public int Puntos=0;
    [SerializeField] public Score score;*/
    public  AudioSource clip;
    private void OnCollisionEnter2D(Collision2D collision)
    {
      bool istaza  = collision.gameObject.GetComponent<Taza>();
        
        if (istaza)
        {
            //clip.Play();
            //score.SumarPuntos();
            Invoke("Destruir", DeathTime);
        }



        float crushThreshold = -0.5f;
        bool  isCrushed =collision.contacts[0].normal.y < -0.5f;

        if (isCrushed)
        {
            //clip.Play();
            //score.SumarPuntos();
            Invoke("Destruir",DeathTime);

        }

    }

   public void Destruir()
    {
        //score.SumarPuntos();
        Destroy(gameObject);
    
        animator.SetTrigger("Destruir");
    }

  
}