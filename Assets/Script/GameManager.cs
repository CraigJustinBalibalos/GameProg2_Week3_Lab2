using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
// Write down your variables here
    public float Score=0;
    public float force = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void IncrementScore()
    {
        Score += 1;
        if ( Score == 4)
        {
            Debug.Log("You win !");
        }
    }
}
