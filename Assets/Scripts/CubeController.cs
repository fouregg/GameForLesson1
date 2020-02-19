using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speedMove = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal")*speedMove*Time.deltaTime, Input.GetAxis("Vertical")*speedMove*Time.deltaTime));
    }
}
