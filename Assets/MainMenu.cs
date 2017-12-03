using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public GameObject jeu;

	public void PlayGame()
    {
        jeu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
