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
    Button newGameButton;
    [SerializeField]
    Button saveGameButton;

    [SerializeField]
    CurrentGameData currentGameData;

    public static GameManager instance;

    //Start
    void Awake()
    {
        instance = this;

        loadGameButton.onClick.AddListener(LoadGame);
        deleteButton.onClick.AddListener(DeleteGame);
        newGameButton.onClick.AddListener(NewGame);
        saveGameButton.onClick.AddListener(SaveGame);
    }

    //Start
    public void NewGame()
    {
        MemorySystem.NewGame("MyGame");
    }

    public void SaveGame()
    {
        MemorySystem.SaveGame(currentGameData.GameData);
    }

    public void LoadGame()
    {
        currentGameData.GameData = MemorySystem.LoadGame("MyGame");
    }

    public void DeleteGame()
    {
        MemorySystem.EreaseGame("MyGame");
    }
}

