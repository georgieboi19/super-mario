using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCount : MonoBehaviour
{
    public Text coinText;
    public static int countValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        coinText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: " + countValue;
    }
}
