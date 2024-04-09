using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePaddle : MonoBehaviour
{
    //public GameObject rotator;
    Vector2 touchStartPos;
    Vector2 movedTo;

    


    void Update()
    {
        //this.transform.Rotate(0,0,0.01f);
        

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchStartPos = touch.position;
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 startPos = this.transform.position;
                movedTo = startPos + (touch.position - touchStartPos);
                
                Debug.Log(movedTo);

                this.transform.Rotate(0,0,movedTo.x);
                //need to divide movedTo to get a sort of sensitivity system going
                //right now its moving by 10 units every time
            }

            if (touch.phase == TouchPhase.Ended)
            {

            }



        }

    }
}
