using System;
using System.Collections.Generic;
using UnityEngine;
using Core.MemorySystem;

class GameManager : MonoBehaviour
{

    void Start()
    {
        MemorySystem.NewGame();
    }
}

