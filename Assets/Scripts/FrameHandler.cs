using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameHandler : MonoBehaviour
{
    [SerializeField]
    // source images for cats and frames
    public Sprite[] cat_src_sprites;
    public Texture2D[] cat_src_textures;
    public Sprite[] frame_src;
    // instantiated static sprite and texture2D arrays of 5 random cats and frames
    public static Texture2D[] cat_textures;
    public static Sprite[] cat_sprites;
    public static Sprite[] frames;
    // aspect ratio values: rows - image number, cols - x or y coord of aspect ratio
    public static int[,] aspect_ratios;
    
    // vars
    private static bool first_run = true;
    
    // constants
    private int NUM_CATS = 20;
    private int NUM_FRAMES = 5;
    
    void Awake()
    {
        first_run = false;
        // instantiate static variables with random values
        if (first_run)
        {
            cat_textures = new Texture2D[5];
            cat_sprites = new Sprite[5];
            frames = new Sprite[5];
            aspect_ratios = new int[5,2];
            for (int i = 0; i < 5; i++)
            {
                int random_cat = Random.Range(0, NUM_CATS);
                int random_frame = Random.Range(0, NUM_FRAMES);
                
                // set static cat Texture2D variables
                cat_textures[i] = cat_src_textures[random_cat];
                cat_sprites[i] = cat_src_sprites[random_cat];
                
                // set static frame and aspect ratio variables
                // FRAME ORDER: 1:1, 2:3, 3:4, 4:3, 3:2
                frames[i] = frame_src[random_frame];
                switch (random_frame)
                {
                    case 0:
                        aspect_ratios[i, 0] = 1;
                        aspect_ratios[i, 1] = 1;
                        break;
                    case 1:
                        aspect_ratios[i, 0] = 2;
                        aspect_ratios[i, 1] = 3;
                        break;
                    case 2:
                        aspect_ratios[i, 0] = 3;
                        aspect_ratios[i, 1] = 4;
                        break;
                    case 3:
                        aspect_ratios[i, 0] = 4;
                        aspect_ratios[i, 1] = 3;
                        break;
                    case 4:
                        aspect_ratios[i, 0] = 3;
                        aspect_ratios[i, 1] = 2;
                        break;
                }
            }
        }
    }
}
