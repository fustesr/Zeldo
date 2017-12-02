using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIntObject : MonoBehaviour {
    public CubeInt cubeInt;

    public void initialize(int i)
    {
        cubeInt = new CubeInt(i);
        this.GetComponentInChildren<TextMesh>().text = ""+i;
    }
    
}
