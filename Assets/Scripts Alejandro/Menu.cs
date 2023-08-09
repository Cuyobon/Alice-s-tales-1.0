using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject POpciones;
    //public Button Cerrar;
    public GameObject PExtras;

    private void Start()
    {
        POpciones.SetActive(false);
        PExtras.SetActive(false);   
    }
    public void Jugar (){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void opciones()
    {
        POpciones.SetActive(true);
    }

    public void Cerrar()
    {
        POpciones.SetActive(false);
        PExtras.SetActive(false);
    }

    public void Extras()
    {
        PExtras.SetActive(true);
    }

    public void Salir(){
        Debug.Log("Salir...");
        Application.Quit();
    }
}
