using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Baby baby;

    public GameObject Cart;

    public bool justPickedUpBaby = false;

    public bool justDroppedBaby = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
#region  Movement
        Vector3 final;
        if (Input.GetKey(KeyCode.A))
            final = new Vector3(-1, 0, 0);
        else if (Input.GetKey(KeyCode.D))
            final = new Vector3(1, 0, 0);
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
            baby.gameObject.transform.localPosition = new Vector3(0, 1, 0);

            StartCoroutine(WaitForBabyToDrop());
        }
#endregion



#region PickupBaby
        if (Input.GetKey(KeyCode.Space) && baby.inTheCart && !justDroppedBaby)
        {
            justPickedUpBaby = true;
            baby.inTheCart = false;

            baby.gameObject.transform.parent = transform;
            baby.gameObject.transform.localPosition = new Vector3(0, 2, 0);

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
// RaycastHit hit;
// if (Physics.Raycast(transform.position, transform.forward, out hit))
// {
//     if (hit.collider.tag == "Baby")
//     {
//         Debug.Log("Raycast worked");
//         hit.collider.gameObject.GetComponent<Baby>().PickUpBaby();
//     }
//     else
//     {
//         Debug.Log("tag is not baby");
//     }
// }
// else{
//     Debug.Log("Raycast did not work");
// }
