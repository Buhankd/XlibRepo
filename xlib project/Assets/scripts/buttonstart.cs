using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonstart : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("gameee");
        
    }
}
