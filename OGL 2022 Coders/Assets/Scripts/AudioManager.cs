using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixerSnapshot gameSnapshot;
    public AudioMixerSnapshot pauseSnapshot;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SetPauseMusic()
    {
        
        Debug.Log("pause music");
        pauseSnapshot.TransitionTo(2f);
    }

    public void SetGameMusic()
    {
        Debug.Log("game music");
        gameSnapshot.TransitionTo(2f);

    }
}
