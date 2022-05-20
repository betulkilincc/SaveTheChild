using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFlag : MonoBehaviour
{
    public GameObject GameManager;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Mom")
        {
            GameManager.GetComponent<GameManager>().FinishGameWon();
        }
    }
}
