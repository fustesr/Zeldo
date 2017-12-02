using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnigmeObject : MonoBehaviour {
    public CubeEnigme cubeEnigme;

    public void initialize(Enigme e)
    {
        cubeEnigme = new CubeEnigme(e);
    }
}
