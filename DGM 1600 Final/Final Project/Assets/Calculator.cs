using UnityEngine;
using System.Collections;

public class Calculator : MonoBehaviour {
	string firstNumber;
	string secondNumber;
	int[] levelOne = new int[10];
	int[] levelTwo = new int[20];
	int[] levelThree = new int[30];
	double result;
	bool divideButton = true;
	bool multButton = true;
	bool addButton = true;
	bool subButton = true;
	const int LEV_ONE_RAN_NUMS = 10;
	const int LEV_TWO_RAN_NUMS = 20;
	const int LEV_THR_RAN_NUMS = 30;


		// Use this for initialization
		void Start () {
		//setting the values for the arrays for each level
		for (int i = 0; i < LEV_ONE_RAN_NUMS; i++) {
			levelOne [i] = Random.Range (1, 20);
		}
		for (int i = 0; i < LEV_TWO_RAN_NUMS; i++) {
			levelTwo [i] = Random.Range (1, 50);
		}
		for (int i = 0; i < LEV_THR_RAN_NUMS; i++) {
			levelThree [i] = Random.Range (1, 100);
		}

		}

		// Update is called once per frame
		void Update () {

		}
	void OnGUI (){
		//get the input from the text boxes
		firstNumber = GUI.TextField (Rect (-264, -226, 0), firstNumber);
		secondNumber = GUI.TextField (Rect (252, -226, 0), secondNumber);

		//
	}
}