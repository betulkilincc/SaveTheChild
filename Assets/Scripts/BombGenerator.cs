using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGenerator : MonoBehaviour
{
    public GameObject bombprefab;
    public float bombLeft = -4;
    public float bombRight = 11;
    public float bombY = 4;
    void Start()
    {
        StartCoroutine(BombGeneratorRoutine());
        }
    IEnumerator BombGeneratorRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            float x = Random.Range(bombLeft, bombRight);
            GameObject bomb = Instantiate(bombprefab, new Vector3(x, bombY, 0), Quaternion.identity);
        }
    }
    void Update()
    {
        
    }
}
