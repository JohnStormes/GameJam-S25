using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
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
}
