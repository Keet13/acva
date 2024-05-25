using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCont : MonoBehaviour
{
    public Vector3 dir;
    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(dir * speed * Time.deltaTime);
    }
    public void OnMoveButtonDown()
    {
        speed = 6f;
    }
    public void OnMoveButtonUp()
    {
        speed = 0f;
    }    

}
