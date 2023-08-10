using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public int Puntos=1;
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameManager.sumarPuntos(Puntos);
            Destroy(this.gameObject);
        }
    }

    /*public void SumarPuntos()
    {
        puntos.Contador = puntos.Contador + puntos.puntosMoneda;
    }*/
}