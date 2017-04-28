using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {
	string firstNumber;
	string secondNumber;
	int[] levelOne = new int[10];
	int[] levelTwo = new int[20];
	int[] levelThree = new int[30];
	double result;
	//bool divideButton = true;
	//bool multButton = true;
	//bool addButton = true;
	//bool subButton = true;
	const int LEV_ONE_RAN_NUMS = 10;
	const int LEV_TWO_RAN_NUMS = 20;
	const int LEV_THR_RAN_NUMS = 30;
	OperatorType oper = OperatorType.Add;



	enum OperatorType {
		Add,
		Subtract,
		Multiply,
		Divide,
	};
	public Button addButton;
	public Button subButton;
	public Button multButton;
	public Button divideButton;

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
		firstNumber = GUI.TextField (new Rect (-264, -256, 122, 30), firstNumber);
		secondNumber = GUI.TextField (new Rect (252, -256, 122, 30), secondNumber);

		//start a for loop for level one
		for (int i = 0; i < LEV_ONE_RAN_NUMS; i++){
			//if +
			if (addButton.interactable == true){
				if (addButton || Input.GetKeyDown (KeyCode.KeypadPlus)) {
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 + num2;

				}
				oper = OperatorType.Add;
			}

			//if -
			if (subButton.interactable == true) {
				if (subButton || Input.GetKeyDown (KeyCode.KeypadMinus)) {
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 - num2;

				}
				oper = OperatorType.Subtract;
			}
			//if /
			if (divideButton.interactable == true){
				if (divideButton || Input.GetKeyDown (KeyCode.KeypadDivide)) {
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 / num2;
				}
				oper = OperatorType.Divide;
			}
			//if *
			if (multButton.interactable == true){
				if (multButton ||Input.GetKeyDown (KeyCode.KeypadMultiply)) {
					double num1 = double.Parse (firstNumber);
					double num2 = double.Parse (secondNumber);

					result = num1 * num2;
				}
				oper = OperatorType.Multiply;
			}

			if (result == levelOne[i]){
			//if result is equal to random number
				switch(oper){
				case OperatorType.Add:
					addButton.interactable = false;
					result = 0;
					break;
				case OperatorType.Subtract:
					subButton.interactable = false;
					result = 0;
					break;
				case OperatorType.Divide:
					divideButton.interactable = false;
					result = 0;
					break;
				case OperatorType.Multiply:
					multButton.interactable = false;
					result = 0;
					break;
				}
			//
			}
			else {
				firstNumber = "";
				secondNumber = "";
			}
			//reset the operators
			if (addButton.interactable == false && subButton.interactable == false && divideButton.interactable == false && multButton.interactable == false){
				addButton.interactable = true;
				subButton.interactable = true;
				divideButton.interactable = true;
				multButton.interactable = true;

			}
		}
		//start a for loop for level two

		//start a for loop for level three

	}
}