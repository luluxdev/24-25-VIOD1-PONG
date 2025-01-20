using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Multijugador()
    {
        Debug.Log("Multiplayer");
        SceneManager.LoadScene("Multijugador");
    }

    public void UnJugador()
    {
        Debug.Log("Single-Player");
        SceneManager.LoadScene("UnJugador");
    }

    public void Salir()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
