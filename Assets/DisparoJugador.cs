using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;
    [SerializeField] private float tiempoEntreAtaques;
    [SerializeField] private float tiempoSiguienteAtaque;
    private Animator animator;

    private void Start() {
        
        animator = GetComponent<Animator>();}

    private void Update(){
        if (tiempoSiguienteAtaque > 0){
            tiempoSiguienteAtaque -= Time.deltaTime;
        }

        if(Input.GetButtonDown("Fire2") && tiempoSiguienteAtaque <=0){
            //disparar
            Disparar(); 
            tiempoSiguienteAtaque = tiempoEntreAtaques;
            
        }
    }

    private void Disparar(){
        animator.SetTrigger("Disparar");
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
