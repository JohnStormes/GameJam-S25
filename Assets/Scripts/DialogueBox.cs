using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialogue() {
        GameObject.Find("Text (TMP)").GetComponent<Dialogue>().StartDialogue();
    }

    void DisableDoorButton() {
        //button.interactable = false;
    }
}
