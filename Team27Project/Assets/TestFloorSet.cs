using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFloorSet : MonoBehaviour {

    public GameObject originFloorBlock;
    public int blockStartPositionX;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < 20; i++)
        {
            Instantiate(originFloorBlock, new Vector2(blockStartPositionX + i, 0), Quaternion.identity);

            Instantiate(originFloorBlock, new Vector2(blockStartPositionX + i, 5), Quaternion.identity);
        }

        for (int i = 0; i < 6; i++)
        {
            Instantiate(originFloorBlock, new Vector2(-1, 0 + i), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
