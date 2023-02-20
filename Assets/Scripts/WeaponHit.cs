using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour
{//put this on the WEAPON object, not PLAYER. Only active when WEAPON is active.
    public float raycastDistance = 5f;
    [SerializeField] private Animator anim;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//on left click, run hitdetect, if hitdetect true call DAMAGE function on OTHER.
        {
            HitDetect();
            anim.Play("Attack");
        }
    }

    void HitDetect() //raycast forward, check if object is DESTRUCTABLE. 
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f)); // center raycast to screen center
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.forward))
        {
            if (Physics.Raycast(ray, out hit, raycastDistance))
            {
                if (hit.collider.CompareTag("destructible"))
                {
                    hit.collider.GetComponent<Destructable>().Damage();
                }
                //do destructible check, call DAMAGE function
            }
        }
    }
}
