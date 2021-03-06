﻿using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour {

	/*
	 * This script is responible for coin management
	 */
	public GameObject coin;
	public MazeGenerator mg;
	// Use this for initialization
	void Start () {

		for(int i = 0;i < PlayerPrefs.GetInt("Level") % LevelManager.levelChange / 2; i++){
			int temp = (mg.ySize/2 - 3) * mg.xSize;
			int temp2 = (mg.ySize/2 + 3) * mg.xSize;
			int temp3 = Random.Range (temp, temp2);
			Instantiate (coin, new Vector2(mg.cells[temp3].x, mg.cells[temp3].y), Quaternion.identity);
		}

	}

}
