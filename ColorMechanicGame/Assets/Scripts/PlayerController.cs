using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Color playerColor;
    public Color PlayerColor { get { return playerColor; } }
    private SpriteRenderer playerSpriteRenderer;


    private void Start()
    {
        playerSpriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();    
        playerColor = Color.white;
    }

    private void Update()
    {
        playerSpriteRenderer.color = playerColor;

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeColor(Color.red);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeColor(Color.green);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeColor(Color.yellow);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void ChangeColor(Color color)
    {
        playerColor = color;
    }
}
