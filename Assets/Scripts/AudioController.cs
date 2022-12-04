using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
     AudioSource m_MyAudioSource;
     public Win w;
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }


    void Update()
    {
         if (w.endAudio)
        {
            //Stop the audio
            m_MyAudioSource.Stop();

        }
    }
}
