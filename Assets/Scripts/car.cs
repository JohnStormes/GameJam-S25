using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    private Animator animator;
    public GameObject dialogue_prefab;
    public GameObject title_screen;
    int random;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GameObject dialogue = Instantiate(dialogue_prefab, title_screen.transform);
        StartCoroutine(GenerateRandom());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerateRandom() {
        while (true) {
            random = Random.Range(0, 4);
            if (random == 1)
                animator.SetTrigger("wag");
            yield return new WaitForSeconds(1f);
        }
    }
}
