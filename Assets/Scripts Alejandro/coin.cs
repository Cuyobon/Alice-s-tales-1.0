using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public Text Puntos_Texto;
    public Puntos puntos;
    [SerializeField] public int Puntos=0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            puntos.SumarPuntos();
            Destroy(this.gameObject);
        }
    }

    /*public void SumarPuntos()
    {
        puntos.Contador = puntos.Contador + puntos.puntosMoneda;
    }*/
}