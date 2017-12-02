using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnigme
{
    public Enigme enigme;
    public int difficulty;
    public bool clef;
    public CubeEnigme(Enigme e)
    {
        this.enigme = e;
        difficulty = e.getDifficulty();
        clef = e.clef;
    }
}

