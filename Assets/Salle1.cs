using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salle1
{

    //Try to open the door
    public static void tryDoor(Enigme e)
    {

        if (e.getDifficulty() == 0 && e.clef == true)
        {
            //Open the door
            Debug.Log("Door opened !");
            Object.Destroy(GameObject.Find("Cailloux"));
        }
    }

    public static void divise7(Enigme e)
    {

        if (e.clef == false)
        {
            e.setDifficulty(e.getDifficulty() / 7); ;
        }
    }

    public static void swap(Enigme e1, Enigme e2)
    {

        if (e2.clef == true)
        {
            e2.clef = false;
            e1.clef = true;
        }
    }
    
}
