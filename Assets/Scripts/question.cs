using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question : MonoBehaviour

{
    public GameObject parent;
    public GameObject[] objects;
    public float offSet;

    void OnTriggerEnter(Collider collisionInfo)
    {
        
        if (collisionInfo.gameObject.tag == "Player")
        {
            parent.transform.GetChild(0).gameObject.SetActive(false);
            parent.transform.GetChild(1).gameObject.SetActive(true);
            pickObject();
        }
    }


    public void pickObject()
    {
        int rtd = Random.Range(0, objects.Length);
        GameObject.Instantiate(objects[rtd], new Vector3(transform.position.x, transform.position.y + offSet, transform.position.z), Quaternion.identity);
    }
}
