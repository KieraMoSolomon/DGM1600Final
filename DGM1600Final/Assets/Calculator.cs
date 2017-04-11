using UnityEngine;
using System.Collections;

public class Calculator : MonoBehaviour {
	double firstNumber;
	double secondNumber;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	double Addition (){
		double addit = firstNumber + secondNumber;
		return;
	}
	double Subtraction (){
		double subtract = firstNumber - secondNumber;
		return;
	}
	double Mult (){
		double mult = firstNumber * secondNumber;
		return;
	}
	double Divide (){
		double divide = firstNumber / secondNumber;
		return;
	}
}
