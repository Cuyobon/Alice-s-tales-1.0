using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntos : MonoBehaviour
{
    public Canvas HUD;
    public int Contador;
    public int puntosMoneda;
    public Text Puntos_Texto;
    public GameObject M1;
    
    // Start is called before the first frame update
    void Start()
    {
        Contador=0;
        puntosMoneda=1;
    }

    // Update is called once per frame
    void Update()
    {
        Puntos_Texto.text = Contador.ToString("0");
    }

    

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            Destroy(M1);
            SumarPuntos();
        }
    }*/

    public void SumarPuntos()
    {
        Contador = Contador + puntosMoneda;
    }

}

