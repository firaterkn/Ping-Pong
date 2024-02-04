using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody _rigidbody;
    private float zValue; // Declare zValue at the class level

    // Start is called before the first frame update
    void Start()
    {
        zValue = Random.Range(-1f, 1f);

        if (zValue > 0 && zValue < 0.2f)
        {
            zValue = 0.6f;
        }
        else if (zValue < 0 && zValue > -0.2f)
        {
            zValue = -0.6f;
        }

        _rigidbody = GetComponent<Rigidbody>();

        DelayedStartTheBall();
    }

    void StartTheBall()
    {
        _rigidbody.velocity = new Vector3(Random.Range(-0.25f, 0.25f), 0, zValue) * _speed;
    }

    void DelayedStartTheBall()
    {
        Invoke("StartTheBall", 2f);
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        DelayedStartTheBall();
    }
}
