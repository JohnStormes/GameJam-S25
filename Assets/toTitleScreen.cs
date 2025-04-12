using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toTitleScreen : MonoBehaviour
{

    SceneLoader loader;

    // Start is called before the first frame update
    void Start()
    {
        loader = GameObject.FindGameObjectWithTag("Room").GetComponent<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            loader.HideUI();

            Invoke("PreviousScene", 2);
            
        }
    }

    void PreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
