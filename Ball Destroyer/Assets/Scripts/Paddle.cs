using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	public int i=0;
    // Start is called before the first frame update
    void Start()
    {
        print("Welcome!");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 paddlePos = new Vector3 (16f, this.transform.position.y, 0f);
		float mousePos = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePos, -15.5f, 15.5f);
		this.transform.position = paddlePos;
    }
}
