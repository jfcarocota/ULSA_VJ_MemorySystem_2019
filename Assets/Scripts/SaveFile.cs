using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class SaveFile : MonoBehaviour
{
    string gameName;

    Button myButton;
    [SerializeField]
    Text gameNameText;

    public string GameName { get => gameName; set => gameName = value; }

    private void Awake()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(LoadGame);
    }

    private void Start()
    {
        gameNameText.text = gameName;
    }

    void LoadGame()
    {
        GameManager.instance.LoadGame(gameName);
    }
}

