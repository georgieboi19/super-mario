using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {
    private GameObject[] playerList;
    private int index;

    private void Start()
    {
        index = PlayerPrefs.GetInt("SelectedCharacter");

        playerList = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            playerList[i] = transform.GetChild(i).gameObject;

            foreach (GameObject go in playerList)
                go.SetActive(false);

        if (playerList[index])
            playerList[index].SetActive(true);
    }

    public void ToggleLeft()
    {

        playerList[index].SetActive(false);

        index--;
        if (index < 0)
            index = playerList.Length - 1;

        playerList[index].SetActive(true);
    }

    public void ToggleRight()
    {

        playerList[index].SetActive(false);

        index++;
        if (index == playerList.Length)
            index = 0;

        playerList[index].SetActive(true);
    }

    public void ConfirmToggle()
    {
        PlayerPrefs.SetInt("SelectedCharacter", index);
        SceneManager.LoadScene("GameScene");
    }

}
