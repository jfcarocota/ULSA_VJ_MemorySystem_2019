using System;
using System.Collections.Generic;
using UnityEngine;
using Core.MemorySystem;
using UnityEngine.UI;

class GameManager : MonoBehaviour
{

    [SerializeField]
    Button loadGameButton;

    [SerializeField]
    CurrentGameData currentGameData;

    //Start
    void Awake()
    {
        loadGameButton.onClick.AddListener(LoadGame);
    }

    //Start
    void Start()
    {
        MemorySystem.NewGame("Pablito sin dinero #elPingo");
    }

    void LoadGame()
    {
        currentGameData.GameData = MemorySystem.LoadGame();
    }
}

