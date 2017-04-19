using UnityEngine;
using System.Collections;

public class Calculator : MonoBehaviour {
	public double firstNumber;
	public double secondNumber;
	public string operation;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
		double Addition (){
			double addIt = firstNumber + secondNumber;
			return addIt;
		}
		double Subtraction (){
			double subtract = firstNumber - secondNumber;
			return subtract;
		}
		double Mult (){
			double mult = firstNumber * secondNumber;
			return mult;
		}
		double Divide (){
			double divide = firstNumber / secondNumber;
			return divide;
		}
	void Operations(string type)
	{
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
}