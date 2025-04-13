using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(CloseGameRoutine());
        }
    }

    public IEnumerator CloseGameRoutine()
    {
        yield return new WaitForSeconds(1f);

        #if UNITY_EDITOR
                EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif



    }
}
