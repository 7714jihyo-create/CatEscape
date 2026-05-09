using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

       // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 v=new Vector3(-0.4f,0,0);
            transform.Translate(v);
        }

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.4f,0,0); 
        }
    }

    public void LButtonDown()
    {
        transform.Translate(-1,0,0);
    }
    public void RButtonDown()
    {
        transform.Translate(1,0,0);
    }

}
