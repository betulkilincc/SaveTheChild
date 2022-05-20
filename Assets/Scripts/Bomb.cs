using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Mom")
        {
            collision.gameObject.GetComponent<Mom>().HP -= 20;
        }
        //Destroy this game object
        Destroy(gameObject);
    }
}
