using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueBox : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public Animator cat_animator;
    public Animator door_animator;
    public AudioSource src;
    public AudioClip clip;
    public bool title_screen;
    public string[] lines;
    public float textSpeed;
    private bool can_update = false;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        cat_animator = GameObject.Find("Cat").GetComponent<Animator>();
        if (title_screen)
            door_animator = GameObject.Find("Frontdoor").GetComponent<Animator>();
        textComponent.text = string.Empty;
        src.clip = clip;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (can_update && Input.GetKeyDown("return")) {
            if (textComponent.text == lines[index]) {
                cat_animator.SetBool("is yapping", true);
                NextLine();
            } else {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void StartDialogue() {
        index = 0;
        StartCoroutine(TypeLine());
        can_update = true;
    }

    IEnumerator TypeLine() {
        foreach(char c in lines[index]) {
            textComponent.text += c;
            if (c != ' ')
                src.Play();
            yield return new WaitForSeconds(textSpeed);
        }

        cat_animator.SetBool("is yapping", false);
    }

    void NextLine() {
        if (index < lines.Length - 1) {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            cat_animator.SetBool("is yapping", false);
            if (title_screen)
            {
                cat_animator.SetTrigger("cat_leave");
                door_animator.SetTrigger("continue");
            }

            gameObject.SetActive(false);
        }
    }
}
