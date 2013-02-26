using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	private Color yell = new Color(.98F, .94F, 0);
	private Color mar = new Color(.47F, .106F, .106F);
	private Color gre = new Color(.118F, .251F, .07F);
	
	void Start()
	{
		renderer.material.color = gre;
	}
	
	void OnMouseOver()
	{
		renderer.material.color = mar;
	}
	
	void OnMouseExit()
	{
		renderer.material.color = gre;
	}
}
