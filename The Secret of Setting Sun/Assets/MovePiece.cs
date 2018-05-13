using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour {

    public GameObject go;
    void Update()
    {


        Vector3 v3 = Input.mousePosition;

        v3.z = 10.0f;

        v3 = Camera.main.ScreenToWorldPoint(v3);


        Debug.Log(v3);
        //Current Position of mouse in world space

        gameObject.GetComponent<Rigidbody>().MovePosition(v3);


    }

}
