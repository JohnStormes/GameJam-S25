using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private bool can_update = false;

    private int index;

    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (can_update && Input.GetKeyDown("return")) {
            if (textComponent.text == lines[index]) {
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
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine() {
        if (index < lines.Length - 1) {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        } else {
            gameObject.SetActive(false);
        }
    }
}
