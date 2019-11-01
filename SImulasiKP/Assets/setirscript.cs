using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setirscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 originalRotationValue; // declare this as a Quaternion
    float rotationResetSpeed = 4.0f;
    public float maxTurnAngle = 20f;
    public Quaternion initquat;
    void Start()
    {
        originalRotationValue = transform.localEulerAngles;
        initquat = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 newbase = transform.localEulerAngles;
        Quaternion newbasequat = transform.localRotation;
        Debug.Log(newbase);
        Debug.Log(originalRotationValue);
        newbase.x = originalRotationValue.x;
        newbase.z = originalRotationValue.z;
        //Debug.Log(newbase);
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            gameObject.transform.Rotate(0, -1, 0, Space.Self);
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            gameObject.transform.Rotate(0, 1, 0, Space.Self);
        }
        
        if(newbase.y - originalRotationValue.y < 180 && newbase.y - originalRotationValue.y !=0)
        {
            gameObject.transform.Rotate(0, 0.5f, 0, Space.Self);
        }
        else if(newbase.y - originalRotationValue.y >=180)
        {
            gameObject.transform.Rotate(0, -0.5f, 0, Space.Self);
        }
        

        
        
        /*
        float turnAngle = transform.eulerAngles.y + Input.GetAxisRaw("Horizontal");
        if (turnAngle > 180 && turnAngle  < 360 - maxTurnAngle)
            turnAngle = 360 - maxTurnAngle;
        else if (turnAngle < 180 && turnAngle > maxTurnAngle)
            turnAngle = maxTurnAngle;

        transform.rotation = transform.parent.rotation * Quaternion.Euler(0, turnAngle, 0);
        */
        
        
    }
}
