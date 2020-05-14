using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "start")
        {
            SceneManager.LoadScene("GameScene");
        }
        else if (collisionInfo.gameObject.tag == "charSelection")
        {
            SceneManager.LoadScene("SelectionScene");
        }
        else if (collisionInfo.gameObject.tag == "controls")
        {
            SceneManager.LoadScene("controlScene");
        }
    }
}
