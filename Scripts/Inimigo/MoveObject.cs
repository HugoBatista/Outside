using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float objectSpeed;

    int nextPosIndex;
    Transform nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if (transform.position == nextPos.position)
        {
            nextPosIndex++;

            if (nextPosIndex >= Positions.Length)
            {
                nextPosIndex = 0;
            }
            nextPos = Positions[nextPosIndex];
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, nextPos.position, objectSpeed * Time.deltaTime);
        }
    }
}