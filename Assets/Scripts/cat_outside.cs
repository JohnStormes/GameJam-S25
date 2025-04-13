using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_outside : MonoBehaviour
{
    bool moving_left, moving_right;
    public GameObject dialogue_prefab;
    public GameObject background_screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moving_left)
            MoveTo(new Vector3(75, -111, 0), 150);
        if (moving_right)
            MoveTo(new Vector3(268, -108, 0), 150);
    }

    void StartMoveLeft() {
        moving_left = true;
    }
    void StopMoveLeft() {
        moving_left = false;
    }
    
    void StartMoveRight() {
        moving_right = true;
    }
    void StopMoveRight() {
        moving_right = false;
    }

    void MoveTo(Vector3 newPosition, float speed) {
        transform.GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(transform.GetComponent<RectTransform>().anchoredPosition, newPosition, speed * Time.deltaTime);
    }

    void StartCatDialogue() {
        GameObject dialogue = Instantiate(dialogue_prefab, background_screen.transform);
    }
}
