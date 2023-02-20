using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour
{//put this on the WEAPON object, not PLAYER. Only active when WEAPON is active.
    void Update()
    {
        if (Input.GetMouseButton(0))//on left click, run hitdetect, if hitdetect true call DAMAGE function on OTHER.
        {
            HitDetect();
        }
    }

    void HitDetect() //raycast forward, check if object is DESTRUCTABLE. set 
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 3))
        {
            //do destructable check, call DAMAGE function
        }
    }
}
