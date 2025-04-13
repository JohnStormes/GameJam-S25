using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public static int solved_count = 0;
    public static bool just_solved = true;
    public Button shard1;
    public Button shard2;
    public Button shard3;
    public Button shard4;
    public Button shard5;

    public GameObject dialogue_prefab_1;
    public GameObject dialogue_prefab_3;
    public GameObject dialogue_prefab_4;
    public GameObject dialogue_prefab_5;

    public GameObject[] frame_prefab = new GameObject[5];

    // frame location constants
    private int[] FRAME_X = { -250, -124, -26, 100, 216 };

    private int Y_LESS_WIDTH = 21;
    private int Y_MORE_WIDTH = 15;

    public GameObject parent;
    // Start is called before the first frame update
    void Awake()
    {
        // change which buttons are interactable based on how many have been solved
        switch (solved_count)
        {
            case 0:
                shard2.interactable = false;
                shard3.interactable = false;
                shard4.interactable = false;
                shard5.interactable = false;
                break;
            case 1:
                shard1.interactable = false;
                shard3.interactable = false;
                shard4.interactable = false;
                shard5.interactable = false;
                break;
            case 2:
                shard1.interactable = false;
                shard2.interactable = false;
                shard4.interactable = false;
                shard5.interactable = false;
                break;
            case 3:
                shard1.interactable = false;
                shard2.interactable = false;
                shard3.interactable = false;
                shard5.interactable = false;
                break;
            case 4:
                shard1.interactable = false;
                shard2.interactable = false;
                shard3.interactable = false;
                shard4.interactable = false;
                break;
        }

        // destroy the corresponding button and place the completed photo prefab with the correct image
        // instantiate dialogues when an image is completed
        if (just_solved)
        {
            switch (solved_count)
            {
                case 1:
                    GameObject.Find("shard 1 button").SetActive(false);
                    SetFrame(0);
                    GameObject dialogue = Instantiate(dialogue_prefab_1, parent.transform);
                    break;
                case 2:
                    GameObject.Find("shard 1 button").SetActive(false);
                    GameObject.Find("shard 2 button").SetActive(false);
                    SetFrame(0);
                    SetFrame(1);
                    Destroy(shard2);
                    break;
                case 3:
                    GameObject.Find("shard 1 button").SetActive(false);
                    GameObject.Find("shard 2 button").SetActive(false);
                    GameObject.Find("shard 3 button").SetActive(false);
                    SetFrame(0);
                    SetFrame(1);
                    SetFrame(2);
                    Destroy(shard3);
                    dialogue = Instantiate(dialogue_prefab_3, parent.transform);
                    break;
                case 4:
                    GameObject.Find("shard 1 button").SetActive(false);
                    GameObject.Find("shard 2 button").SetActive(false);
                    GameObject.Find("shard 3 button").SetActive(false);
                    GameObject.Find("shard 4 button").SetActive(false);
                    SetFrame(0);
                    SetFrame(1);
                    SetFrame(2);
                    SetFrame(3);
                    Destroy(shard4);
                    dialogue = Instantiate(dialogue_prefab_4, parent.transform);
                    break;
                // winning the game case
                case 5:
                    GameObject.Find("shard 1 button").SetActive(false);
                    GameObject.Find("shard 2 button").SetActive(false);
                    GameObject.Find("shard 3 button").SetActive(false);
                    GameObject.Find("shard 4 button").SetActive(false);
                    GameObject.Find("shard 5 button").SetActive(false);
                    SetFrame(0);
                    SetFrame(1);
                    SetFrame(2);
                    SetFrame(3);
                    SetFrame(4);
                    Destroy(shard5);
                    break;
            }

            // UNCOMMENT THIS FOR ACTUAL USE
            //just_solved = false;
        }

        solved_count++;
    }

    void SetFrame(int index)
    {
        int x = FRAME_X[index];
        Sprite cat = FrameHandler.cat_sprites[index];
        Sprite frame = FrameHandler.frames[index];
        int asp_width = FrameHandler.aspect_ratios[index, 0];
        int asp_height = FrameHandler.aspect_ratios[index, 1];
        int y;
        if (asp_width >= asp_height)
            y = Y_LESS_WIDTH;
        else
        {
            y = Y_MORE_WIDTH;
        }
        
        GameObject new_frame = Instantiate(frame_prefab[index], parent.transform);
        new_frame.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
        new_frame.GetComponent<Image>().sprite = frame;
        new_frame.name = "frame " + index;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
