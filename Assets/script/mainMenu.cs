using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public string startScene;
    public string creditos;

    public void StartGame()
    {
        SceneManager.LoadScene(startScene);
    }
  
    public void Creditos()
    {
      SceneManager.LoadScene(creditos);
    }
}
