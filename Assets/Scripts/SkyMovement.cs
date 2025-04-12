using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyMovement : MonoBehaviour
{
    int START_POS = -1450;
    int END_POS = 1450;
    float SPEED = 0.005f;
    [SerializeField] GameObject sky2;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(START_POS, 250, 0);
        sky2.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 250, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // move the images
        transform.position = new Vector3(transform.position.x + SPEED, transform.position.y, 0);
        sky2.transform.position = new Vector3(sky2.transform.position.x + SPEED, sky2.transform.position.y, 0);

        // reset an image if it goes too far
        if (transform.GetComponent<RectTransform>().anchoredPosition.x > END_POS)
            transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(START_POS, 250, 0);
        if (sky2.GetComponent<RectTransform>().anchoredPosition.x > END_POS)
            sky2.GetComponent<RectTransform>().anchoredPosition = new Vector3(START_POS, 200, 0);
    }
}
