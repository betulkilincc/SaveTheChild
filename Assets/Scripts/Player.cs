using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Baby baby;


    public GameObject Cart;
    public GameObject Mom;

    public bool justPickedUpBaby = false;

    public bool justDroppedBaby = false;

    public GameSettingsSO gameSettings;

    public float Speed {
        get{
            float basespeed =  gameSettings.difficulty == GameSettingsSO.Difficulty.Easy ? 2f :
            gameSettings.difficulty == GameSettingsSO.Difficulty.Medium ? 1.8f : 1.3f;
            if(!baby.inTheCart)
                return basespeed * 0.5f;
            else
                return basespeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
#region  Movement
        Vector3 final;
        if (Input.GetKey(KeyCode.A) && transform.position.x > 0)
            final = new Vector3(-Speed, 0, 0);
        else if (Input.GetKey(KeyCode.D))
            final = new Vector3(Speed, 0, 0);
        else
            final = new Vector3(0, 0, 0);
        transform.Translate(final * Time.deltaTime);
#endregion



#region  DropBaby
        if (Input.GetKey(KeyCode.Space) && !baby.inTheCart && !justPickedUpBaby)
        {
            justDroppedBaby = true;
            baby.inTheCart = true;

            baby.gameObject.transform.parent = Cart.transform;
            baby.gameObject.transform.localPosition = new Vector3(0.047f,0.72f,0);
            baby.gameObject.transform.eulerAngles = new Vector3(0,0,104.08f);

            StartCoroutine(WaitForBabyToDrop());
        }
#endregion



#region PickupBaby
        if (Input.GetKey(KeyCode.Space) && baby.inTheCart && !justDroppedBaby)
        {
            justPickedUpBaby = true;
            baby.inTheCart = false;

            baby.gameObject.transform.parent = Mom.transform;
            baby.gameObject.transform.localPosition = new Vector3(0.08f, 0.05f, 0);
            baby.gameObject.transform.eulerAngles = new Vector3(0, 0, 185.3f);

            StartCoroutine(WaitForBaby());
        }
#endregion
    }

    IEnumerator WaitForBaby()
    {
        yield return new WaitForSeconds(0.2f);
        justPickedUpBaby = false;
    }

    IEnumerator WaitForBabyToDrop()
    {
        yield return new WaitForSeconds(0.2f);
        justDroppedBaby = false;
    }
}
