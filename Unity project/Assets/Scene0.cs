using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scene0 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Joueur")
        {
            SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        }

    }
}
