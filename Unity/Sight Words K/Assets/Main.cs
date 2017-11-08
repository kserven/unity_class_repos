using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {

    public Text text;
    public int item = 0;

    string[] words = new string[] { "I", "a", "am", "at", "the", "see", "had", "as", "and", "it", "in", "is",
                                    "can", "do", "have", "go", "he", "has", "to", "on", "did", "all", "was",
                                    "what", "you", "we", "up", "she", "him", "her", "his", "look", "for", "boy",
                                    "girl", "said", "they", "with", "but", "of", "little", "then", "be", "were",
                                    "that", "down", "some", "there", "out", "when"
    };

	// Use this for initialization
	void Start () {
        text.text = words[item];	
	}
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.RightArrow)) && item < 49) {
            item++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && item > 0) {
            item--;
        }
        else if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }

        text.text = words[item];
	}
}
