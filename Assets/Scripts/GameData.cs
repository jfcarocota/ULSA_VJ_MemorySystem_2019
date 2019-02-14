﻿using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
class GameData 
{
    [SerializeField]
    string gameName;
    [SerializeField]
    int playerlvl;
    [SerializeField]
    float currentHealth;

    public GameData(string gameName, 
        int playerlvl, float currentHealth)
    {
        this.gameName = gameName;
        this.playerlvl = playerlvl;
        this.currentHealth = currentHealth;
    }
}
