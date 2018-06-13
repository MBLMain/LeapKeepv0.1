using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private bool Dragging = false;
    private int Level = 0;
    private float ClickPointX;
    private float ClickPointY;

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
        if (Dragging)
            Aim();
	}

    void OnMouseDown()
    {
        Dragging = true;
        ClickPointX = Input.mousePosition.x;
        ClickPointY = Input.mousePosition.y;
        //ClickPointX = Camera.main.ScreenToWorldPoint(Input.mousePosition.x);
    }

    private void OnMouseUp()
    {
        Dragging = false;
    }

    private void Aim()
    {
        Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mouseWorldPoint.z = 0f;
        transform.position = mouseWorldPoint;
    }

    private void SpawnPlatform()
    {

    }
}
