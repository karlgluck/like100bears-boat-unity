using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveInFigure8s : MonoBehaviour
{
[Range (1f, 5f)]
public float Size = 2.5f;

[Range (0.05f, 1f)]
public float Speed = 0.12f;

void Update ()
    {

    var lastPosition = this.transform.position;
    this.transform.position = new Vector3 (
                this.Size * Mathf.Cos (Time.time * 3 * this.Speed),
                this.Size * Mathf.Sin (Time.time * 4 * this.Speed),
                0f
                );
    var delta = this.transform.position - lastPosition;
    this.transform.rotation = Quaternion.Euler (0f, 0f, Mathf.Atan2 (delta.y, delta.x) * Mathf.Rad2Deg);
		
	}
}
