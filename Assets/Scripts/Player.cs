using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    [SerializeField]
    private float _speed;


    void Update()
    {
        

        var horizontal = Input.GetAxis("Horizontal");
        

        if(horizontal < 0 && transform.position.x <= -5.85f)
            return;

        else if (horizontal > 0 && transform.position.x >= 5.85f)
            return;



        transform.position += new Vector3(horizontal, 0f, 0f) * Time.deltaTime * _speed;

    }
}
