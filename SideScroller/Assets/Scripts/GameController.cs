using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Castle player;
	public Castle enemy;

	public Unit unit;
	public Vector3 spawnValues;
	public int unitCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	private bool gameOver;
	private bool restart;
	private int score;


	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator SpawnWaves () 
	{
		yield return new WaitForSeconds(startWait);
		while(true) {
			for (int i = 0; i < unitCount; i++) {
				Vector3 spawnPosition = enemy.transform.position;
				Quaternion spawnRotation = Quaternion.identity;
			
				Unit unitNew = Instantiate (unit, spawnPosition, spawnRotation) as Unit;
				Mover mover = unitNew.GetComponent<Mover>();
				mover.Target = player.transform;
				unitNew.tag = "Enemy";
				yield return new WaitForSeconds(spawnWait);
				
			}
			yield return new WaitForSeconds(waveWait);
			
			if (this.gameOver) {
				this.restart = true;
				break;
			}
		}
	}
}
