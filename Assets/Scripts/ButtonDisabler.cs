using UnityEngine;
using UnityEngine.UI;

public class ButtonDisabler : MonoBehaviour
{
    [SerializeField] Button button;

    void Start()
    {
        button.interactable = true;
    }


    private void Update()
    {

        button.onClick.AddListener(ButtonOff);


    }


    void ButtonOff()
    {
        button.interactable = false;
    }


}

