using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    GameObject player;
    private void Start()
    {
        player = GameObject.FindAnyObjectByType<PlayerController>().gameObject;
    }
    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 0, -10);
    }
}
