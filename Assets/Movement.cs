using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator myAnim;
    bool returning = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetBool("MovementShip", true);
            Debug.Log("yendo");

            if (returning)
            {

                myAnim.SetBool("MovementShip", false);
                myAnim.SetBool("ReturningShip", true);
                Debug.Log("volviendo");
            }


        }
        else if (!returning)
        {
            myAnim.SetBool("MovementShip", false);
            myAnim.SetBool("ReturningShip", false);
            Debug.Log("iddle");
        }

    }


    public void Returning()
    {
        returning = true;
    }

    public void Iddle()
    {
        returning = false;
    }
}
