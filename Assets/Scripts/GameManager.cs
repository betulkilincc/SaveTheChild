using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void FinishGameWon()
    {
        SceneManager.LoadScene("Game Won");
    }
    public void FinishGameLost()
    {
        SceneManager.LoadScene("Game Lost");
    }
}
