using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mom : MonoBehaviour
{
    public GameObject HealthBar;
    public GameObject GameManager;

    private void Start()
    {
        StartCoroutine(AdjustHealth());
    }
    private IEnumerator AdjustHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            HP-=1;
        }
    }

    private int _hp = 100;

    public int HP
    {
        get
        {
            return _hp;
        }
        set
        {
            HealthBar.GetComponent<Slider>().value = _hp = value;
            if(value<=0)
            {
                GameManager.GetComponent<GameManager>().FinishGameLost();
            }
        }
    }
}
