using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public AudioClip[] Clips;
    private AudioSource[] audioSources;

    public Canvas Loose;

    public float RestartDelay = 2f;

    void Start()
    {
        Loose.enabled = false;
        audioSources = new AudioSource[Clips.Length];
        int i = 0;
        while (i < Clips.Length)
        {
            GameObject child = new GameObject("Player");

            child.transform.parent = gameObject.transform;

            audioSources[i] = child.AddComponent<AudioSource>() as AudioSource;

            audioSources[i].clip = Clips[i];

            i++;
        }
        audioSources[0].Play();
    }

	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Loose.enabled = true;
            audioSources[1].Play();
            gameHasEnded = true;
            Debug.Log("TA CHATTE");
            Invoke("Restart",RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
