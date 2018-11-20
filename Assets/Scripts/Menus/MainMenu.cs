using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void ButtonHistoria() {
        SceneManager.LoadScene("BaseHistoria", LoadSceneMode.Single);
    }

    public void ButtonNiveles() {
        SceneManager.LoadScene("Runner", LoadSceneMode.Single);
    }

    public void ButtonOpciones() {
        //Enlazar con menú de opciones cuando se cree.
    }

    public void ButtonMusic() {
        //Desactivar y activar musica, cambiando el icono del boton cuando se pulsa en el.
    }

    public void ButtonAds() {
        //Pagar para quitar los anuncios imagino (Inclusión por David y me parece bien).

    }
}
