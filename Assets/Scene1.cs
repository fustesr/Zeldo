using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scene1 : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Joueur")
        {
            SceneManager.LoadSceneAsync("Enigme1", LoadSceneMode.Single);
        }
    }
}
