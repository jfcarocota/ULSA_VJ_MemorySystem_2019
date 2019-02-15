using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Data", menuName = "Custom Objects/Game Data")]
class CurrentGameData : ScriptableObject
{
    [SerializeField]
    GameData gameData;

    internal GameData GameData { get => gameData; set => gameData = value; }
}

