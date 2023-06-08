using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private int numOfPlatforms;
    private void Start()
    {
        for(int i = 0;i < numOfPlatforms; i++) {
            Instantiate(platformPrefab, new Vector3(gameObject.transform.position.x + i * 10, -4 , 0), Quaternion.identity);
        }
    }
}
