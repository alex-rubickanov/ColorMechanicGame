using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    private Color platformColor;
    private SpriteRenderer spriteRenderer;
    private PlayerController playerController;
    private BoxCollider2D col;

    private void Start()
    {
        playerController = GameObject.FindAnyObjectByType<PlayerController>();
        col = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        platformColor = RandomColor();
    }

    private void Update()
    {
        spriteRenderer.color = platformColor;
        CollisionEnabler();
    }

    private Color RandomColor()
    {
        int i = Random.Range(0, 3);
        switch(i)
        {
            case 0:
                return Color.red;
            case 1:
                return Color.green;
            case 2:
                return Color.yellow;
            default:
                return Color.white;
        }
    }

    private void CollisionEnabler()
    {
        if(playerController.PlayerColor != platformColor)
        {
            col.enabled = false;
        }
        else col.enabled = true;
    }
}
