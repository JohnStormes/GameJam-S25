using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    private Animator cat_animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartCat() {
        cat_animator = GameObject.Find("Cat").GetComponent<Animator>();
        cat_animator.SetTrigger("cat_dialogue");
    }
}
