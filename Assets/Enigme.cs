using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigme {

    private int difficulty;
    public bool clef = false;


    public Enigme()
    {
        difficulty = 100;
    }

    public Enigme(int attr1)
    {
        difficulty = attr1 * 14;
    }

    public Enigme(int attr1, int attr2)
    {
        difficulty = (attr1 + 2) * (attr2 + 3);
    }

    public int getDifficulty()
    {

        return difficulty;
    }
    public void setDifficulty(int i)
    {
        this.difficulty = i;
    }

    public void divise10()
    {

        if (clef == false)
        {
            difficulty = difficulty / 10;
        }
    }

    public void setClef(int i)
    {
        if (i == 7)
        {
            clef = true;
            difficulty = difficulty + 1;
        }
    }
}
