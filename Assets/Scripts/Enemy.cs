using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private Ball _ball;

    void Update()
    {
        var enemyMove = Mathf.Sign(_ball.transform.position.x - transform.position.x);

        // Adjust buffer zone to avoid constant triggering near the edges
        if (enemyMove < 0 && transform.position.x <= -5.85f)
            return;
        else if (enemyMove > 0 && transform.position.x >= 5.85f)
            return;

        transform.position += new Vector3(enemyMove, 0f, 0f) * Time.deltaTime * _speed;
    }


}
