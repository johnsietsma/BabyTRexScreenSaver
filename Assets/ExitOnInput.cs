using UnityEngine;
using System.Collections;

public class ExitOnInput : MonoBehaviour {

    Vector3 mousePos;

    void Start()
    {
        mousePos = Input.mousePosition;
    }

	void Update () {



        if (Input.anyKeyDown || Input.mousePosition != mousePos)
        {
            Application.Quit();
        }

	}
}
