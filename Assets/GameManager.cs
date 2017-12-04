using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    bool BossDead = false;
    public AudioClip[] Clips;
    private AudioSource[] audioSources;

    public Canvas Loose;
    public Canvas Win;

    public float RestartDelay = 2f;

    void Start()
    {
        Loose.enabled = false;
        Win.enabled = false;
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

    }

	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            Loose.enabled = true;
            audioSources[1].Play();
            gameHasEnded = true;
            Invoke("Restart",RestartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BossDefeated()
    {
        Debug.Log("oui");
        if (BossDead == false)
        {
            Win.enabled = true;
            audioSources[2].Play();
            BossDead = true;
            Invoke("Restart", 5f);
        }
    }
}
