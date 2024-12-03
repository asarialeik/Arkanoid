using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    [SerializeField]
    public int brickPoints;
    [SerializeField]
    public int brickLife;

    void Start()
    {

    }

    void Update()
    {

    }

    public void SubstractLife()
    {
        brickLife = brickLife -1;
    }
}
