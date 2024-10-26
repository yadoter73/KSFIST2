using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class CoinCollect : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player>().AddCoin();
            Destroy(gameObject);         
        }
    }
}