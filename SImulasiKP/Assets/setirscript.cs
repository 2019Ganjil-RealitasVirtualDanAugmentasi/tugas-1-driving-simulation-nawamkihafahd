using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setirscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Quaternion originalRotationValue; // declare this as a Quaternion
    float rotationResetSpeed = 4.0f;
    void Start()
    {
        originalRotationValue = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion newbase = transform.rotation;
        Debug.Log(newbase);
        Debug.Log(originalRotationValue);
        newbase.x = originalRotationValue.x;
        newbase.z = originalRotationValue.z;
        Debug.Log(newbase);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(0, 1,0, Space.Self);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(0, -1, 0, Space.Self);
        }
    }
}
