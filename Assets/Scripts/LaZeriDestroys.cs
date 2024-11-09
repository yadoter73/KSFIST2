using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaZeriDestroys : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag != "Ground")
        {
            Destroy(collision.gameObject);
        }
    }
}
