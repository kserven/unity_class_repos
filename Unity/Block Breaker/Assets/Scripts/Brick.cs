using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    
    public Sprite[] hitSprites;
    private int timesHit;
    private LevelManager levelManager;

    // Use this for initialization
    void Start () {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool isBreakable = (this.tag == "Breakable");
        print(this.tag);
        if (isBreakable)
        {
            HandleHits();
        }

    }

    void HandleHits()
    {
        timesHit++;
        int MaxHits = hitSprites.Length + 1;

        if (timesHit >= MaxHits)
        {
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }
}
