using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Enables efficient scene management
using UnityEngine.SceneManagement;


public class Button : MonoBehaviour
{
    // Reloads the "SampleScene" when the RestartGame method is called.
    public void RestartGame()
    {

        SceneManager.LoadScene("SampleScene");
    }
    
}
