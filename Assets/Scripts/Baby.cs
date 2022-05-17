using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baby : MonoBehaviour
{
    public bool inTheCart = true;

    public GameObject HealthBar;

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
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AdjustHealth());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator AdjustHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (inTheCart)
            {
                HP -= 5;
            }
        }
    }
}
