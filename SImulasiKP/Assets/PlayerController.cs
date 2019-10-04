using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0;

    public float moveHorizontal = 0;
    public float moveVertical = 0;
    //public Text statustext;
    void Start()
    {
        //statustext.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            speed+= (float)0.5;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if(speed > 0)
            {
                speed -= (float)1.2;
            }
            speed -= (float)0.5;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }
        if(speed >= 0)
        {
            if(speed >= 0.01)
            {
                speed -= (float)0.3;
            }
            else
            {
                speed = 0;
            }
            
        }
        
        transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);
    }
    /*
    private void OnCollisionEnter(Collision other)
    {
       
        if (other.gameObject.tag == "Room")
        {
            statustext.text = other.gameObject.name;
            Debug.Log("Collide");
        }
    }
    private void OnCollisionExit(Collision other)
    {
        //Debug.Log("Collide");
        if (other.gameObject.tag == "Room")
        {
            statustext.text = "";
            Debug.Log("Collide Release");
        }
    }
    */
}
