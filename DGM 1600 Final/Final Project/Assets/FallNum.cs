using UnityEngine;
using System.Collections;

public class FallNum : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Operations(string type)
	{
		Calculator calc = new Calculator ();
		switch (type) {
		case "+":
			//adition
			break;
		case "-":
			//subtraction
			break;
		case "*":
			//mult
			break;
		case "/":
			//devide
			break;
		}
}
