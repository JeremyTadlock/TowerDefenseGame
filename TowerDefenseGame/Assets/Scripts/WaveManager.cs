using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour 
{
	int currentWaveCount;
	int maxWaveCount;

	int numberToSpawn;

	void Start () 
	{
		//implement waveOne
	}
		
	void Update ()
	{
		//check if all mobs are dead, if so call NextWave(); which will spawn the next wave
	}

	void NextWave()
	{
		numberToSpawn = currentWaveCount * 10; //random formula to figure out how many mobs you want to spawn per wave (wave number * 10)
		SpawnMobs ();//loop mob spawns
	}

	void SpawnMobs ()
	{
		for(int i = ; i < numberToSpawn)
		{
			//instantiate a monster on the spawn point, this monster will have a health script and a pathfinding script attached
		}
	}
}
