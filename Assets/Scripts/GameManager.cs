using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;

    public GameObject gamePanel;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPlayButtonClick()
    {
        mainMenu.SetActive(false);
        gamePanel.SetActive(true);
    }
}
