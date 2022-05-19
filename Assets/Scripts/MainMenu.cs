using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void HelpMenu(){
        SceneManager.LoadScene("Help Menu");
    }
    public void QuitGame(){
        Debug.Log("Oyundan ciktik");
        Application.Quit();
    }
    public void ReturntoMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
