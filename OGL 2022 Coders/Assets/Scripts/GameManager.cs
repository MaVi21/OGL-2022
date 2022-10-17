using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioManager audioManager;
    private bool isPaused;
    
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        audioManager.SetGameMusic();
    }

    // Update is called once per frame
    void Update()
    {
        //ifdef android: KeyCode.Menu

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
            isPaused = !isPaused;
            if (isPaused)
            {
                audioManager.SetPauseMusic();
            }
            else
            {
                audioManager.SetGameMusic();
            }

        }
    }
}
