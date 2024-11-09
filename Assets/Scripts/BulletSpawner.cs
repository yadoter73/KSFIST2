using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            enemyPrefab.SetActive(true);
        }
        else
        {
            enemyPrefab.SetActive(false);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position -= new Vector3(0,-1,1);
        }
        
    }
}
