// Joe Adams
using UnityEngine;
using System.Collections;

public class MasterScript : MonoBehaviour {
	
	public string playerFile = "Player";
	public GameObject player;
	// Use this for initialization
	void Start () {		
		if(player == null){
			player = (GameObject)Instantiate(Resources.Load(playerFile));
			MagneticSphere sph = (MagneticSphere)player.GetComponent(typeof(MagneticSphere));
			sph.setCharge(Charge.POSITIVE);
			this.SendMessage("startCamera", player);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Death(){
		Destroy(player);
		player = (GameObject)Instantiate(Resources.Load(playerFile));MagneticSphere sph = (MagneticSphere)player.GetComponent(typeof(MagneticSphere));
		sph.setCharge(Charge.POSITIVE);
		this.SendMessage("startCamera", player);
	}
}
