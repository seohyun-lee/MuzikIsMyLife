using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    // float time;
    public float moveSpeed;
    // public float scaleSize;

    void Update()
    {
        // transform.localScale = new Vector3 (scaleSize, scaleSize, 0) * (1+time);
        transform.position += Vector3.right * moveSpeed * Time.deltaTime; 
        // time += Time.deltaTime;
    }

    // public void resetAnim()
    // {
    //     time = 0;
    //     transform.localScale = Vector3.one;
    // }
}
