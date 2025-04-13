using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAudio : MonoBehaviour
{
    public AudioSource src;
    public AudioSource click_src;
    public GameObject fan;

    public void ChangeFanSound()
    {
        if (src.isPlaying)
        {
            fan.GetComponent<Animator>().SetTrigger("stop");
            click_src.Play();
            src.Stop();
        }
        else
        {
            fan.GetComponent<Animator>().SetTrigger("start");
            click_src.Play();
            src.Play();
        }
    }
}
