﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;

    public void add(int newScore)
    {
        score = score + newScore;
    }
}
