using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unbreakble : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zPos;

    private IEnumerator OnTriggerEnter(Collider collider)
    {
        transform.GetComponent<Collider>().isTrigger = false;
        if (collider.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(xPos, yPos + 0.2F, zPos);
            yield return new WaitForSeconds(0.06F);
            this.transform.position = new Vector3(xPos, yPos, zPos);
            yield return new WaitForSeconds(0.25F);
            transform.GetComponent<Collider>().isTrigger = true;
        }
    }

    void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
    }
}
