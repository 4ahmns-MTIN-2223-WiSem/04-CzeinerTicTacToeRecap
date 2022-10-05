using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject gameBoard;
    public Sprite[] images;
    bool unplayed = true;

    private void Start()
    {
        spriteRenderer.sprite = null;
    }

    private void OnMouseDown()
    {
        
        if (unplayed) 
        {
            int index = gameBoard.GetComponent<GameScripts>().turn();
            spriteRenderer.sprite = images[index];
            unplayed = false;
        }

    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("Board");
    }
}
