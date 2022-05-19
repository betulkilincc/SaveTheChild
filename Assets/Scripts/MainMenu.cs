using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("PlayGame");
        
    }
    public void HelpMenu(){
        SceneManager.LoadScene("Help Menu");
    }
    public void Story(){
        SceneManager.LoadScene("Story");
    }
    public void Settings(){
        SceneManager.LoadScene("Settings Menu");
    }
    public void Credits(){
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame(){
        Debug.Log("Oyundan ciktik");
        Application.Quit();
    }
    public void ReturntoMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
