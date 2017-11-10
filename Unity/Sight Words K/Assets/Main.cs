using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    public Text text, color;
    private static int item = 0;
    string[] words = new string[] { "I", "a", "am", "at", "the", "see", "had", "as", "and", "it", "in", "is",
                                    "can", "do", "have", "go", "he", "has", "to", "on", "did", "all", "was",
                                    "what", "you", "we", "up", "she", "him", "her", "his", "look", "for", "boy",
                                    "girl", "said", "they", "with", "but", "of", "little", "then", "be", "were",
                                    "that", "down", "some", "there", "out", "when","99"
                                    };

    // Update is called once per frame
    void Update()
    {
        text.text = words[item];
        UserInput();
    }

    void UserInput()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.RightArrow)) && words[item + 1] != "99")
        
        {
            item++;
            RandColor();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && item > 0)
        {
            item--;
            RandColor();
        }
        else if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void RandColor()
    {
        int textColor = Random.Range(0,5);

        if (textColor == 0)
        {
            text.color = Color.red;
        }
        else if (textColor == 1)
        {
            text.color = new Color32(75, 75, 255, 255);  // brighter blue
        }
        else if (textColor == 2)
        {
            text.color = Color.green;
        }
        else if (textColor == 3)
        {
            text.color = Color.yellow;
        }
        else if (textColor == 4)
        {
            text.color = Color.cyan;
        }
        else
        {
            text.color = Color.magenta;
        }
    }
}
