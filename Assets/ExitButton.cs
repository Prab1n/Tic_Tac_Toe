using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public GameObject objectToExit;

    public void Awake()
    {
        GameObject ToStoreScoreOfX =GameObject.Find("ScoreOfX");
        DontDestroyOnLoad(ToStoreScoreOfX);
        GameObject ToStoreScoreOfO = GameObject.Find("ScoreOfO");
        DontDestroyOnLoad(ToStoreScoreOfO);
    }

    public void ExitGame()
    {
        // Check if objectToExit is null
        if (objectToExit == null)
        {
            Debug.LogWarning("objectToExit is null. Make sure it's assigned in the Inspector.");
            return; // Exit the method early to avoid further errors
        }

        // Find the "Canvas" in the hierarchy
        GameObject canvasTransform = GameObject.Find("Canvas");

        // Check if the canvasTransform is null
        canvasTransform.SetActive(false);
    }  
    
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
