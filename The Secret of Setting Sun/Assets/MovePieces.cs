using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePieces : MonoBehaviour {
    
        void Update()
        {

          
            if (Input.GetButtonDown("Fire1"))
            {
                GetObject();
            }
        }

        private void GetObject()
        {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(transform.position, ray.direction, out hit, 100f)) {
                Debug.Log(hit.transform.name);
                Debug.DrawLine(ray.origin, hit.point);
            if (hit.transform.tag == "Moveable") {
                Debug.Log("Pode mexer essa desgraça");
            }
        }
        }

}
