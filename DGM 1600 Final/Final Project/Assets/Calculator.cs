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
	const string Add = "+";

	enum OperatorType {
		Add,
		Subtract,
		Multiply,
		Divide,
	};
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
		firstNumber = GUI.TextField (new Rect (-264, -226, 0), firstNumber);
		secondNumber = GUI.TextField (new Rect (252, -226, 0), secondNumber);
		//firstNumber = GUILayout.Button

		//start a for loop for level one
		for (int i = 0; i < LEV_ONE_RAN_NUMS; i++){
			//if +
			if (addButton == true){
				if((GUI.Button(new Rect(800, 75, 60, 25), "") || Input.GetKeyDown(KeyCode.KeypadPlus))){
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 + num2;
				}
			}

			//if -
			if (subButton == true){
				if (Input.GetKeyDown (KeyCode.KeypadMinus)) {
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 - num2;
				}
			}
			//if /
			if (divideButton == true){
				if (Input.GetKeyDown (KeyCode.KeypadDivide)) {
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 / num2;
				}
			}
			//if *
			if (multButton == true){
				if (Input.GetKeyDown (KeyCode.KeypadMultiply)) {
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 * num2;
				}
			}

			if (result == levelOne[i]){
			OperatorType oper = OperatorType.Add;
			//if result is equal to random number
				switch(oper){
				case OperatorType.Add:
					addButton = false;
					result = 0;
					break;
				case OperatorType.Subtract:
					subButton = false;
					result = 0;
					break;
				case OperatorType.Divide:
					divideButton = false;
					result = 0;
					break;
				case OperatorType.Multiply:
					multButton = false;
					result = 0;
					break;
				}
			//
			}
			//reset the operators
			if (addButton == false && subButton == false && divideButton == false && multButton == false){
				addButton = true;
				subButton = true;
				divideButton = true;
				multButton = true;

			}
		}
		//start a for loop for level two

		//start a for loop for level three

	}
}