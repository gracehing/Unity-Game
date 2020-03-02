using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public Slider Volume;
    public AudioSource Music;

    // Update is called once per frame
    void Update()
    {
        Music.volume = Volume.value;
    }
}
