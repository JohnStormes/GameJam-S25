using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public AudioSource src;
    public AudioClip door_opening;
    private Animator cat_animator;
    public static int first_load = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartCat()
    {
        Debug.Log(first_load);
        if (first_load == 1)
        {
            cat_animator = GameObject.Find("Cat").GetComponent<Animator>();
            cat_animator.SetTrigger("cat_dialogue");
        } 
        else 
        {
            GetComponent<Animator>().SetTrigger("continue");
        }
    }
    
    public void OpenDoor()
    {
        StartCoroutine(PlayDoorSound());
    }

    IEnumerator PlayDoorSound()
    {
        yield return new WaitForSeconds(0.8f);
        src.clip = door_opening;
        src.Play();
    }
}
