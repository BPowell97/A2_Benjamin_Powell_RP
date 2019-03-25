using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquationGenerator : MonoBehaviour
{
    //List<tileValue> selected;
     

    public enum Difficulty {EASY, MEDIUM, HARD}

    public Difficulty difficulty;

    public TextMeshProUGUI statusText;
    public TextMeshProUGUI numberOneText;
    public TextMeshProUGUI numberTwoText;
    public TextMeshProUGUI answerText;
    public TextMeshProUGUI symbolText;

    public TextMeshProUGUI addText;
    public TextMeshProUGUI subText;
    public TextMeshProUGUI multText;

    List<int> currentNumbers;
    //int targetAnswer = 60;

    int numberOne;
    int numberTwo;
    int answer;


    void Start()
    {
        Generate();
        currentNumbers = new List<int>();

    }

    void Addition()
    {
        numberOne = Random.Range(0, 10);
        numberTwo = Random.Range(0, 10);

        answer = numberOne + numberTwo;

        Display("+");

        addText.gameObject.SetActive(true);
        multText.gameObject.SetActive(false);
        subText.gameObject.SetActive(false);
    }

    void Multiplication()
    {
        numberOne = Random.Range(0, 10);
        numberTwo = Random.Range(0, 10);

        answer = numberOne * numberTwo;

        Display("x");

        multText.gameObject.SetActive(true);
        subText.gameObject.SetActive(false);
        addText.gameObject.SetActive(false);
    }

    void Subtraction()
    {
        numberOne = Random.Range(10, 30);
        numberTwo = Random.Range(0, 10);

        answer = numberOne - numberTwo;

        Display("-");

        subText.gameObject.SetActive(true);
        addText.gameObject.SetActive(false);
        multText.gameObject.SetActive(false);
    }

    void Display(string symbol)
    {
        symbolText.text = symbol;
        numberOneText.text = numberOne.ToString();
        numberTwoText.text = numberTwo.ToString();
        answerText.text = "?";

    }

    public void AddNewNumber(int incomingNumber)
    {
        currentNumbers.Add(0);
        
        currentNumbers.Add(incomingNumber);
        CheckAnswer();
    }


   public void CheckAnswer()
    {
        int newInt = 0;
        for (int i = 0; i < currentNumbers.Count; i++)
            newInt += currentNumbers[i];

        Debug.Log(newInt);

        if (newInt == answer)
        {
            currentNumbers.Clear(); //Clears number list
            statusText.text = "Correct!";
            statusText.color = Color.green;
            answerText.color = Color.green;
        }
        else
        {
            statusText.text = "Incorrect!";
            statusText.color = Color.red;
            answerText.color = Color.red;
            //currentNumbers.Clear(); //says incorrect after one button press
        }
        
        StartCoroutine(NewQuestion());  
        //currentNumbers.Clear();
        //else
        //Destroy(currentNumbers.gameObject);

        /*Debug.Log(userChoice);

        if (userChoice == answer.ToString())
        {
            statusText.text = "Correct!";
            statusText.color = Color.green;
            answerText.color = Color.green;
           
        }
        else
        {
            statusText.text = "Incorrect!";
            statusText.color = Color.red;
            answerText.color = Color.red;
        }*/
        //StartCoroutine(NewQuestion());  
    }

    IEnumerator NewQuestion()
    {
        yield return new WaitForSeconds(3);
        Generate();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Generate();
        }
    }

    void Generate()
    {
        statusText.text = "";
        numberOne = GetNumber();
        numberTwo = GetNumber();

        int rnd = Random.Range(0, 3);
        if (rnd == 0)
            Addition();
        if (rnd == 1)
            Multiplication();
        if (rnd == 2)
            Subtraction();
    }

    int GetNumber()
    {
        int newNumber = 0;
        switch (difficulty)
        {
            case Difficulty.EASY:
                newNumber = Random.Range(0, 10);
                break;
            case Difficulty.MEDIUM:
                newNumber = Random.Range(0, 20);
                break;
            case Difficulty.HARD:
                newNumber = Random.Range(0, 50);
                break;

        }
        return newNumber;
    }
}
