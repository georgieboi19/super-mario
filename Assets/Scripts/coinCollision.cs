using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "Player")
        {
            Debug.Log("Hit coin");
            coinCount.countValue += 1;
            GameObject.Destroy(gameObject);
        }
    }
}