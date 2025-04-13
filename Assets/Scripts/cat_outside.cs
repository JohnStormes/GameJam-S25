using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_outside : MonoBehaviour
{
    bool moving;
    public GameObject dialogue_prefab;
    public GameObject title_screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
            MoveTo(new Vector3(75, -111, 0), 150);
    }

    void StartMove() {
        moving = true;
    }
    void StopMove() {
        moving = false;
    }

    void MoveTo(Vector3 newPosition, float speed) {
        transform.GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(transform.GetComponent<RectTransform>().anchoredPosition, newPosition, speed * Time.deltaTime);
    }

    void StartCatDialogue() {
        GameObject dialogue = Instantiate(dialogue_prefab, title_screen.transform);
    }
}
