using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_outside : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveCat() {
        Debug.Log("bruh");
        transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(75, -111, 0);
    }
}
