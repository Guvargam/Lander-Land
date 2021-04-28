
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("You hit Friendly object");
                break;
            case "Fuel":
                Debug.Log("You hit Fuel object");
                break;
            case "Finish":
                Debug.Log("You finish the level! ");
                break;
            default:
                LoadLevelAgain(0);
                break;
        }
    }

    void LoadLevelAgain(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
