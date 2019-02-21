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
    Button deleteButton;

    [SerializeField]
    CurrentGameData currentGameData;

    //Start
    void Awake()
    {
        loadGameButton.onClick.AddListener(LoadGame);
        deleteButton.onClick.AddListener(DeleteGame);
    }

    //Start
    void Start()
    {
        //MemorySystem.NewGame("Something important");
    }

    void LoadGame()
    {
        //currentGameData.GameData = MemorySystem.LoadGame();
    }

    void DeleteGame()
    {
        MemorySystem.EreaseGame();
    }
}

