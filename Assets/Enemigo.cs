using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] GameObject efectoMuerte;
    //private Animator animator;

    /*private void Start()
    {
        animator = GetComponent<Animator>();
    }*/

    public void Tomardaño(float daño)
    {
        vida -= daño;
        
        if (vida <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        //animator.SetTrigger("Muerte");
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
