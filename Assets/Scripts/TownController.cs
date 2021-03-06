﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownController : MonoBehaviour
{
    public GameObject townBlock;
    public int numBlocks;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numBlocks; i++)
        {
            var position = Vector3.right * 17.5f * i;
            position.y += i * 0.01f;
            Instantiate(townBlock, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
