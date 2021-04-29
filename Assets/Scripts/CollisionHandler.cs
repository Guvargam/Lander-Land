
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
            case "Finish":
                LoadNextLevel();
                break;
            default:
                LoadLevelAgain();
                break;
        }
    }

    void LoadLevelAgain()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void LoadNextLevel()
    {
        int currrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currrentSceneIndex + 1;
        
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        
        SceneManager.LoadScene(nextSceneIndex);    
        
    }
}
