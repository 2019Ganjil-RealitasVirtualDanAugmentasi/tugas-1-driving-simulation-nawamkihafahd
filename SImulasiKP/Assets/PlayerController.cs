using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 0;

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
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        Vector3 position = transform.position;
        position.x += moveHorizontal * speed * Time.deltaTime;
        position.z += moveVertical * speed * Time.deltaTime;
        transform.position = position;
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
