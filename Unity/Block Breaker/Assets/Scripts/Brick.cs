using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {


    public AudioClip click;
    public Sprite[] hitSprites;
    public static int breakableCount = 0;

    private int timesHit;
    private LevelManager levelManager;
    private bool isBreakable;

    // Use this for initialization
    void Start ()
    {
        isBreakable = (this.tag == "Breakable");
        // Keep track of breakable bricks
        if (isBreakable)
        {
            breakableCount++;
        }
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(click, transform.position, 1f);
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
            breakableCount--;
            levelManager.BrickDestroyed();
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
