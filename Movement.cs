using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2[] _positions;
    int i = 0;

	void Update()
	{
		if (Input.GetButton("Jump")) {

            transform.position = _positions[i];
            i++;
            if (i >= _positions.Length)
            {
                i = 0;
            }
		}
	}
}
