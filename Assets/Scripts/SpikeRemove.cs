using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeRemove : MonoBehaviour
{
   // private float delayTime = 2f;
  //  public void Start()
  // {
        //GetComponent<SpikeRemove>();
   // }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
    //public IEnumerator WaitForSeconds()
    //{
    //    yield return new WaitForSeconds(delayTime);
    //    this.enabled = false;
    //}
}
