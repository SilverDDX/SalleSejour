using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public bool[] puzzleComplete;
    bool frozen;
    public int count, sizePuzzle;
    EcranControleTimer Ecran;
	// Use this for initialization
	void Start () {
        sizePuzzle = puzzleComplete.Length;
        Ecran = GetComponent<EcranControleTimer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!frozen)
        {
            count = 0;
            foreach (bool piece in puzzleComplete)
            {
                if (piece == true)
                {
                    count++;
                }

            }

            if (count == sizePuzzle)
            {
                FreezeTimer();
            }
        }

    }
  public void FreezeTimer()
    {
        Ecran.stopTime = true;
        Ecran.enabled = false;
        frozen = true;
    }

    public void resetTime()
    {
        Ecran.enabled = true;
        Ecran.ResetTimer();
    }
}
